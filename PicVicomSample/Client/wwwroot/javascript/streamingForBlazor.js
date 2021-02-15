var serverHostNmae = "pickvideocommunication.icu";
var server = null;
if(window.location.protocol === 'http:')
	server = "http://" + serverHostNmae + ":8088/janus";
else
	server = "https://" + serverHostNmae + ":8089/janus";

var janus = null;
var streaming = null;
var opaqueId = null;
var selectedStream = null;
var janusinitsuccess = false;
var StreamingType = null;

function SetJanusValues(roomId, ID, type) {
    selectedStream = roomId;
    opaqueId = ID;
    StreamingType = type;
}

function JanusInit() {
    Janus.init({debug: "all", callback: function() {
        if(!Janus.isWebrtcSupported()) {
            bootbox.alert("No WebRTC support... ");
            return;
        }
        janus = new Janus(
            {
                server: server,
                success: function () {
                    Janus.log("============ selectedStream = " + selectedStream + " opaqueId = " + opaqueId + " StreamingType = " + StreamingType + " ============");
                    StreamingAttach()
                },
                error: function(error) {
                    Janus.error(error);
                    bootbox.alert(error, function() {
                        window.location.reload();
                    });
                },
                destroyed: function() {
                    window.location.reload();
                }
            }
        );

    }});
}

function StreamingAttach() {
    janus.attach(
        {
            plugin: "janus.plugin.streaming",
            opaqueId: opaqueId,
            success: function(pluginHandle) {
                streaming = pluginHandle;
                Janus.log("Plugin attached! (" + streaming.getPlugin() + ", id=" + streaming.getId() + ")");
                startStream()
            },
            error: function(error) {
                Janus.error("  -- Error attaching plugin... ", error);
                bootbox.alert("Error attaching plugin... " + error);
            },
            iceState: function(state) {
                Janus.log("ICE state changed to " + state);
            },
            webrtcState: function(on) {
                Janus.log("Janus says our WebRTC PeerConnection is " + (on ? "up" : "down") + " now");
            },
            onmessage: function(msg, jsep) {
                Janus.debug(" ::: Got a message :::", msg);
                onMsg(msg, jsep);
            },
            onremotestream: function(stream){
                Janus.log(" ::: Got a remote stream :::", stream);
                onRemoteStream(stream);
            }, 
            ondataopen: function(data) {
                Janus.log("The DataChannel is available!");
                $('#waitingvideo').remove();
                $('#stream').append(
                    '<input class="form-control" type="text" id="datarecv" disabled></input>'
                );
            },
            ondata: function(data) {
                Janus.debug("We got data from the DataChannel!", data);
                $('#datarecv').val(data);
            },  
            oncleanup: function() {
                Janus.log(" ::: Got a cleanup notification :::");
                $('#waitingvideo').remove();
                $('#remotevideo').remove();
                $('#datarecv').remove();
                $('.no-video-container').remove();
            }         
        }
    );
}

function onMsg(msg, jsep) {
    var result = msg["result"];
    if(result) {
        if(result["status"]) {
            var status = result["status"];
            if(status === 'starting')
                Janus.log("Starting, please wait...");
            else if(status === 'started')
                Janus.log("Started");
            else if(status === 'stopped')
                stopStream();
        }
    }else if(msg["error"]) {
        bootbox.alert(msg["error"]);
        stopStream();
        return;
    }
    if(jsep) {
        Janus.debug("Handling SDP as well...", jsep);
        var stereo = (jsep.sdp.indexOf("stereo=1") !== -1);
        // 대답
        streaming.createAnswer(
            {
                jsep: jsep,
                // 받기만함
                media: { audioSend: false, videoSend: false, data: true },
                customizeSdp: function(jsep) {
                    if(stereo && jsep.sdp.indexOf("stereo=1") == -1) {
                        // 오디오에 스테리오 설정 있으면
                        jsep.sdp = jsep.sdp.replace("stereo=1");
                    }
                },
                success: function(jsep) {
                    Janus.log("Got SDP!", jsep);
                    var body = { request: "start" };
                    streaming.send({ message: body, jsep: jsep });
                },
                error: function(error) {
                    Janus.error("WebRTC error:", error);
                    bootbox.alert("WebRTC error... " + error.message);
                }
            });
    }
}

function onRemoteStream(stream) {
    if($('#remotevideo').length === 0) {
        Janus.log(" ::: remotevideo == 0 :::");
        addButtons = true;
        if (StreamingType == 2) {
            $('#stream').append('<audio class="rounded centered hide" id="remotevideo" width="100%" playsinline controls/>')
        }
        else {
            $('#stream').append('<video class="rounded centered hide" id="remotevideo" width="100%" playsinline controls autoplay/>');
        }
        $('#remotevideo').get(0).volume = 0.5;
        $("#remotevideo").bind("playing", function () {
            Janus.log(" ::: playing stream :::");
            $('#waitingvideo').remove();
            if(this.videoWidth)
                $('#remotevideo').removeClass('hide').show();
            var videoTracks = stream.getVideoTracks();
            if(!videoTracks || videoTracks.length === 0)
                return;
        });
    }
    Janus.attachMediaStream($('#remotevideo').get(0), stream);
    if (StreamingType == 2) {
        return;
    }
    var videoTracks = stream.getVideoTracks();
    if (!videoTracks || videoTracks.length === 0) {
        // 비디오가 없을때
        if($('#stream .no-video-container').length === 0) {
            $('#stream').append(
                '<div class="no-video-container">' +
                '<span class="no-video-text">No streaming!! pls upload file!!</span>' +
                '</div>');
        }
    } else {
        $('#stream .no-video-container').remove();
    }
}

function startStream() {
	Janus.log("Selected Stream id #" + selectedStream);
	var body = { request: "watch", id: parseInt(selectedStream) || selectedStream};
	streaming.send({ message: body });
}

function stopStream() {
	var body = { request: "stop" };
	streaming.send({ message: body });
	streaming.hangup();
}

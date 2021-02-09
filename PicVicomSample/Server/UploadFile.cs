using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PicVicomSample.Server
{
    public class UploadFIle
    {
        public UploadFIle(IFormFile file, bool ismusic)
        {
            File = file;
            OriginalName = file.FileName;
            Extension = "." + OriginalName.Split('.')[OriginalName.Split('.').Length - 1];
            IsMusic = ismusic;

        }

        public IFormFile File { get; set; }
        public string OriginalName { get; private set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string FileBaseFolder { get; set; } = @"C:\samplevideo";
        public bool IsMusic { get; private set; }

        public async Task WriteFile()
        {
            try
            {
                Name = DateTime.Now.Ticks + Extension;

                if (!Directory.Exists(FileBaseFolder))
                {
                    Directory.CreateDirectory(FileBaseFolder);
                }

                var path = Path.Combine(FileBaseFolder, Name);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public bool CheckIfExcelFile()
        {
            if (IsMusic)
                return (Extension == ".mp3");

            return (Extension == ".mp4");
        }

    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public string Upload(IFormFile file, string root)//verdiğin dosya istenilen yere yükleniyor.
        {
            if (file.Length > 0)//Dosya boyutu 0 dan büyük olmalı ki resim olsun
            {
                if (!Directory.Exists(root))//yüklenilecek yer var mı yoksa yarat diyor
                {
                    Directory.CreateDirectory(root);
                }
                
                string extension = Path.GetExtension(file.FileName);//dosyanın uzantısını alıyor
                string guid = Guid.NewGuid().ToString();//dosyanın ismini rastgele isim yapıyor
                string filePath = guid + extension;//resmin bütününü  oluşturuyor

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();//belleğe kaydediyor
                    return filePath;
                }
            }

            return null;
        }

        public void Delete(string filePath)
        {
            if (File.Exists(filePath))//verilen dosya yolu varsa siler
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            Delete(filePath);   //dosya yolunu siler yenisini yükler

            return Upload(file, root);
        }
    }
}

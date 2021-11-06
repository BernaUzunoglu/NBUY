using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiEnvanteri
{
    public static class KisiContext//Static bir tane olacak. Devamlı instance almadan yapmak için.Helper metodlar genelde static tanımlanır.
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/NBUY/WebForm/KisiEnvanteri/db.json";
        public static List<Kisi> Kisiler { get; set; } = new List<Kisi>();

        public static void Load()
        {

            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    Kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);   
                }
            }
            
           
        }
        public static void Save()
        {
            try
            {
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(Kisiler, Formatting.Indented));
                writer.Close();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
        }
        
    }
}

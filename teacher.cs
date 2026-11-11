using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    public class teacher
    {
        public bool fun1(string? d, string? f,out string msg, ref int sumOfFiles)
        {
            if (File.Exists(f))
            {
                if (!File.Exists(d))
                { 
                    d= Path.Combine(Path.GetDirectoryName(f), "new folder");
                }
                Directory.CreateDirectory(d);
                string txt = File.ReadAllText(f, Encoding.UTF8);
                string[] arr = txt.Split(',');
                string newPath;
                for (int i = 0; i < arr.Length; i++)
                {
                    newPath = Path.Combine(Path.GetDirectoryName(f), "new folder", arr[i].Trim());
                    File.Create(newPath);
                }
                sumOfFiles = arr.Length - 1;
            }
            msg = "the file not found";
            return false;
        }
    }
}

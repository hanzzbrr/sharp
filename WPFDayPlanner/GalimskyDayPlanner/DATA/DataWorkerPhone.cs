using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GalimskyDayPlanner
{
    public class DataWorkerPhone
    {
        string phonesFile;

        public void Run()
        {
            /*
            phonesFile = Path.Combine(Data.dataDir, "0phones.txt");
            if(File.Exists(phonesFile))
            {
                Console.WriteLine("Файл номеров {0} существует",Path.GetFileName(phonesFile));
            }
            else
            {
                Console.WriteLine("Файл номеров {0} не существует", Path.GetFileName(phonesFile));
                File.CreateText(phonesFile);
            }
            */
        }

        public void OverWriteAllFiles()
        {
            string phonesFile = Data.dataDir + @"\" + "0phones" + ".txt";
            string tmpStr;
            Console.WriteLine(phonesFile);
            //writing to file

            StringBuilder sb = new StringBuilder();
            foreach (var item in Data.numbers)
            {
                Console.WriteLine(item);
                sb.Append(item);
            }

            using (FileStream fs = File.Open(phonesFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }
    }
}

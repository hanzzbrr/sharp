using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GalimskyDayPlanner
{
    public class DataWorker
    {
        private static DataWorker inst;
        private DataWorkerPhone dwp;
        public string dataDir;

        private DataWorker()
        { }

        public static DataWorker get()
        {
            if (inst == null)
                inst = new DataWorker();
            return inst;
        }
        //вызывается в Form1
        public void Run()
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Data.dataDir = Path.Combine(Environment.CurrentDirectory, "DATA");
            if (Directory.Exists(Data.dataDir))
            {
                Console.WriteLine("Директория существует");
                dataDir = Data.dataDir;
                Console.WriteLine(Data.dataDir);
            }
            else
                Directory.CreateDirectory(Data.dataDir);
            dwp = new DataWorkerPhone();
            dwp.OverWriteAllFiles();
            //OverWriteAllFiles();
        }
        //вызывается в Form1
        public void OverWriteAllFiles()
        {
            foreach (var item in Data.days)
            {
                string tmpPth = dataDir +@"\"+ "d"+item.Key + ".txt";
                Console.WriteLine(tmpPth);
                //writing to file
                
                using(FileStream fs = File.Open(tmpPth, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(item.Value.ToString());
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
        }

        //вызывается в Form1
        public void ReadAllFiles()
        {
            string[] files = Directory.GetFiles(dataDir, "d*.txt");
            
            foreach (var file in files) {
                int counter = 0;
                string line;
                string tmpDate;
                Console.WriteLine("file name: "+Path.GetFileName(file));
                tmpDate = GetDate(Path.GetFileName(file));
                tmpDate = tmpDate.Substring(1, tmpDate.Length-1);
                Console.WriteLine("file date: "+tmpDate);

                Day tmpDay = new Day();
                tmpDay.tasks = new Dictionary<int, CalendTask>();


                //Data.days.Add
                //Console.WriteLine("date: "+Utils.GetDateFromCode(tmpDate));
                Console.WriteLine("tmpDate: "+tmpDate);
                tmpDay.dateTime = Utils.GetDateFromCode(tmpDate);
                StreamReader reader = new StreamReader(file);
                while((line = reader.ReadLine()) != null){
                    //Console.WriteLine(line);
                    TaskTmp task = new TaskTmp();
                    task = GetTask(line);
                    //Console.WriteLine("lineStr "+line);
                    Console.WriteLine(task);
                    CalendTask calTskTmp = new CalendTask(task.task,task.isDone);
                    tmpDay.tasks.Add(task.num, calTskTmp);
                    counter++;
                }

                Data.days.Add(tmpDate, tmpDay);
                reader.Close();
                Console.WriteLine();
            }
        }
        //метод принимает название текстового файла. ИЗ его названия возвращает ключ
        //для Dictionary<string,Day>
        private string GetDate(string str)
        {
            int lBoard=-1;
            int hBoard=1;
            int k=0;
            string searchStr = "___";
            StringBuilder sb = new StringBuilder();
            for(int i=0;i < str.Length; i++)
            {
                if (str[i] == searchStr[k])
                {
                    string tmp = str.Substring(lBoard+1,hBoard-1);
                    Console.WriteLine("GetDate DEBUG: "+tmp);
                    sb.Append(tmp);
                    sb.Append("_");
                    lBoard = i;
                    hBoard = 0;
                    k++;
                    if (k >= searchStr.Length)
                        break;
                }
                hBoard++;
            }
            return sb.ToString();
        }
        private TaskTmp GetTask(string str)
        {
            //Console.WriteLine("initStr: "+str);
            string searchStr = ":::";
            int lBoard=-1;
            int hBoard=1;
            int k = 0;  //порядковый номер текщуего символа-разграничителя
            TaskTmp task = new TaskTmp();
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == searchStr[k])
                {
                    string tmp = str.Substring(lBoard+1, hBoard-1);
                    
                    lBoard = i;
                    hBoard = 0;
                    //Console.WriteLine(k);
                    switch (k)
                    {
                        case 0:
                            //Console.WriteLine("tmpTaskNum: " + tmp);
                            task.SetNum(tmp);
                            break;
                        case 1:
                            //Console.WriteLine("tmpTaskTASK: " + tmp);
                            task.SetTask(tmp);
                            break;
                        case 2:
                            //Console.WriteLine("tmpTaskISDONE: " + tmp);
                            task.SetDone(tmp);
                            break;
                        default:
                            break;
                    }
                    k++;
                    if (k >= searchStr.Length)
                        break;
                }
                hBoard++;
            }
            return task;
        }
    }

    public class TaskTmp
    {
        public string task;
        public int num;
        public bool isDone;
        

        public void SetTask(string str)
        {
            task = str;
        }
        public void SetNum(string str)
        {
            num = Int32.Parse(str);
        }
        public void SetDone(string str)
        {
            if (str[0] == '1')
                isDone = true;
            else
                isDone = false;
        }

        public override string ToString()
        {
            return task + " | " + num + " | " + isDone;
        }
    }
}

/* энкрипт здесь хорошо работает, надо запомнить
                using (FileStream fs = File.Open(file,FileMode.Open,FileAccess.Read,FileShare.None))
                {
                    byte[] buffer;
                    int length = (int)fs.Length;  // get file length
                    buffer = new byte[length];            // create buffer
                    int count;                            // actual number of bytes read
                    int sum = 0;                          // total number of bytes read

                    // read until Read method returns 0 (end of the stream has been reached)
                    while ((count = fs.Read(buffer, sum, length - sum)) > 0)
                        sum += count;  // sum is a buffer offset for next reading
                    string res = Encoding.UTF8.GetString(buffer);
                    Console.WriteLine(res);
                }
                */

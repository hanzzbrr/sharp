using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalimskyDayPlanner
{
    public static class Utils
    {
        public static string GetDateCode(DateTime d)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(d.Year);
            sb.Append("_");
            sb.Append(d.Month);
            sb.Append("_");
            sb.Append(d.Day);
            sb.Append("_");
            return sb.ToString();
        }

        public static DateTime GetDateFromCode(string date)
        {
            string searchStr = "___";

            int lBoard=-1;
            int hBoard=1;
            int k=0;

            int year=0;
            int month=0;
            int day=0;

            for(int i=0; i < date.Length; i++)
            {
                //Console.WriteLine("DEBUG: " + date[i]);
                if (date[i] == searchStr[k])
                {
                    string tmpStr = date.Substring(lBoard + 1, hBoard - 1);
                    Console.WriteLine(tmpStr);
                    switch (k)
                    {
                        case 0:
                            year = int.Parse(tmpStr);
                            break;
                        case 1:
                            month = int.Parse(tmpStr);
                            break;
                        case 2:
                            day = int.Parse(tmpStr);
                            break;
                        default:
                            break;
                    }
                    lBoard = i;
                    hBoard = 0;
                    k++;
                }
                hBoard++;
                if (k >= searchStr.Length)
                    break;
            }
            return new DateTime(year, month, day);
        }
    }
}

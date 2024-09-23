using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalimskyDayPlanner
{

    public class PhoneNumber : IComparable<PhoneNumber>
    {
        public string number; //сам номер
        public string name;  //обладатель номера
        public char firstLetter;

        public static readonly string chars = "abcdefghijklmnopqrstuvwxyzабвгдежзийклмнопрстуфхцшщъьыэюя";
        public static readonly string p_chars = "0123456789-";

        public override string ToString()
        {
            return name + ":" + number+":"+Environment.NewLine;
        }

        public int CompareTo(PhoneNumber other)
        {
            return this.name.CompareTo(other.name);
        }

        public PhoneNumber() { }
        public PhoneNumber(string number, string name)
        {
            this.number = number;
            this.name = name;
        }

        static Random rand = new Random();
        public void SetRandomName(char _char)
        {
            char[] _name = new char[5];
            _name[0] = _char;

            for (int i = 1; i < _name.Length; i++)
            {
                _name[i] = chars[rand.Next(chars.Length)];
            }
            name = new string(_name);
        }
        static Random n_ran = new Random();

        public void SetRandomNumber(char _char)
        {
            char[] _number = new char[8];
            _number[0] = _char;
            for (int i = 1; i < _number.Length; i++)
            {
                _number[i] = p_chars[rand.Next(p_chars.Length)];
            }
            number = new string(_number);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAlphabetedList
{
    public class PhoneNumber : IComparable<PhoneNumber>
    {
        public string name;
        public string number;
        public char firstLetter;
        public static readonly string chars =  "abcdefghijklmnopqrstuvwxyz";
        public static readonly string p_chars = "0123456789-";

        public int CompareTo(PhoneNumber other)
        {
            return this.name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return "    | "+name + " | " + number;
        }
        static Random rand = new Random();
        public void SetRandomName(char _char)
        {
            char[] _name = new char[5];
            _name[0] = _char;
            
            for(int i=1; i < _name.Length; i++)
            {
                _name[i] = chars[rand.Next(chars.Length)];
            }
            name = new string(_name);
        }
        static Random n_rand = new Random();
        public void SetRandomNumber(char _char)
        {
            char[] _number = new char[8];
            _number[0] = _char;
            for(int i=1; i< _number.Length; i++)
            {
                _number[i] = p_chars[n_rand.Next(p_chars.Length)];
            }
            number = new string(_number);
        }

        //private Random random = new Random();
        //public string RandomString(int length)
        //{
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    return new string(Enumerable.Repeat(chars, length)
        //      .Select(s => s[random.Next(s.Length)]).ToArray());
        //}
    }
}

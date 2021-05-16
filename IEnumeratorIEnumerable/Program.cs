using System;
using System.Collections;

namespace IEnumeratorIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContainer container = new DataContainer();
            foreach(Data elem in container)
            {
                System.Console.WriteLine(elem.Value1 + " " + elem.Value2);
            }
        }
    }

    public class DataContainer : IEnumerator, IEnumerable
    {
        private Data[] _dataArray;
        int _position = -1;

        public DataContainer()
        {
            _dataArray = new Data[]
            {
                new Data(1, 2.4f),
                new Data(2, 2.5f),
                new Data(3, 3.6f),
                new Data(15, 25.0f)
            };
        }

       public IEnumerator GetEnumerator()
       {
           return (IEnumerator)this;
       }

       public bool MoveNext()
       {
           _position++;
           return (_position < _dataArray.Length);
       }
       //IEnumerable
       public void Reset()
       {
           _position = 0;
       }
       //IEnumerable
       public object Current
       {
           get { return _dataArray[_position];}
       }
    }

    public class Data
    {
        public int Value1 {get; set;}
        public float Value2 { get; set;}

        public Data(int value1, float value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}

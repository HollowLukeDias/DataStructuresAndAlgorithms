using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class MyList
    {
        public object[] Data { get; private set; }
        public int Length { get; private set; }
        private int _arraySize = 1;

        public MyList()
        {
            Data = new object[_arraySize];
            Length = 0;
        }

        public object Push(object item)
        {
            if (_arraySize == Length)
            {
                CreateBiggerArray();
            }
            Data[Length] = item;
            Length++;
            return Data[Length - 1];
        }

        private void CreateBiggerArray()
        {
            var temp = new object[Length];
            Array.Copy(Data, temp, Length);

            Data = new object[Length + 1];
            Array.Copy(temp, Data, Length);
            _arraySize++;
        }

        public object Get(int index)
        {
            return Data[index];
        }
    }
}

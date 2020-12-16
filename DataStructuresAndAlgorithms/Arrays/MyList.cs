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

        public object Pop()
        {
            var lastItem = Data[Length - 1];
            Data[Length - 1] = null;
            Length--;

            return lastItem;
        }

        public object Delete(int index)
        {
            var item = Data[index];

            ShiftItems(index);

            return item;
        }

        private void ShiftItems(int index)
        {
            for (int i = index; i < Length - 1; i++)
            {
                Data[i] = Data[i + 1];
            }
            Data[Length - 1] = null;
            Length--;
        }
    }
}

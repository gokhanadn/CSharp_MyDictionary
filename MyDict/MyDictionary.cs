using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDict
{
    class MyDictionary<T,A>
    {
        T[] keys;
        A[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new A[0];
        }
        public void Add(T key, A value)
        {
            T[] tempArrayKeys = keys;
            A[] tempArrayValues = values;
            keys = new T[keys.Length + 1];
            values = new A[values.Length + 1];
            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
                values[i] = tempArrayValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int Count
        {
            get { return values.Length; }
        }
    }
}

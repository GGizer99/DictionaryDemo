using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T1,T2>
    {
        T1[] _tempkeys;
        T2[] _tempvalues;
       
        T1[] _keys;
        T2[] _values;
        
        public MyDictionary()
        {
            _keys = new T1[0];
            _values = new T2[0];
        }

        public void Add(T1 key,T2 value)
        {
            _tempkeys = _keys;
            _tempvalues = _values;

            _keys = new T1[_keys.Length + 1];
            _values = new T2[_values.Length + 1];

            for (int i = 0; i < _tempkeys.Length; i++)
            {
                _keys[i] = _tempkeys[i];
                _values[i] = _tempvalues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;



        }

       

        public int Count
        {
            get { return _values.Length; }
        }

        public T1[] Keys
        {
            get { return _keys; }
        }

        public T2[] Value
        {
            get { return _values; }
        }

   


    }
}

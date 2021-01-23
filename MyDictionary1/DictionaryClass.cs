﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary1
{
    class DictionaryClass<TKey,TValue>
    {
        public TKey[] keys;
        public TValue[] values;

        public DictionaryClass()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}

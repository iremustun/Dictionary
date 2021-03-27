using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKeys, TValues>
    {
        TKeys[] Keys;
        TValues[] Values;

        public MyDictionary()
        {
            Keys = new TKeys[0];
            Values = new TValues[0];

        }
        
        public void Add(TKeys Key, TValues Value)
        {
            TKeys[] tempKeys = Keys;
            Keys = new TKeys[Keys.Length + 1];

            TValues[] tempValues = Values;
            Values = new TValues[Values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                Keys[i] = tempKeys[i];
            }
            Keys[Keys.Length - 1] = Key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                Values[i] = tempValues[i];
            }
            Values[Keys.Length - 1] = Value;
        }
        public TValues GetValuesByKeys(TKeys Key)
        {
            int index = Array.IndexOf(Keys, Key);
            return Values[index];

        }

    }
}

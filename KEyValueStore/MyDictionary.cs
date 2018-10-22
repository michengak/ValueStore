using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEyValueStore
{
   
        class MyDictionary
        {
            private KeyValue[] arr = new KeyValue[15];
            private int counter = 0;

            public object this[string key]
            {
               
                set
                {
                    bool exists = true;
                    for (int i = 0; i < counter; i++)
                    {
                        if (arr[i].key == key)
                        {
                            arr[i] = new KeyValue(key, value);
                            exists = false;
                        }
                    }
                    if (exists && counter != 15)
                    {
                        arr[counter++] = new KeyValue(key, value);
                    }
                    else
                    {
                        throw new Exception("You are out of the recommend number");
                    }
                }
                get
                {
                    foreach (KeyValue x in arr)
                    {
                        if (x.key == key)
                        {
                            return x.value;
                        }
                    }
                    throw new KeyNotFoundException();
                }

            }
        }
    

}


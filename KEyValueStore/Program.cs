using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEyValueStore
{
    struct KeyValue
    {
        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public readonly string key;
        public readonly object value;
    }

    class Program
    {
        static void Main()
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
   


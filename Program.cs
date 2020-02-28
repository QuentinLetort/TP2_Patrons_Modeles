using System;
using Sample;
using Encoder;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercice 1 */
            B instance = new B();
            Dictionary<string, object> test = MyJSON.Serialize(instance);
            string json = JsonConvert.SerializeObject(test, Formatting.Indented);
            Console.Write(json);

        }
    }
}

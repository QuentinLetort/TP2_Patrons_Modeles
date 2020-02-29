using System;
using Sample;
using Encoder;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TP2
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Exercice 1 */
            D d = new D();
            Dictionary<string, object> dict = MyJSON.Serialize(d);
            Console.Write(JsonConvert.SerializeObject(dict, Formatting.Indented));
        }
    }

}

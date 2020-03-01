using System;
using Sample;
using Encoder;
using System.Collections.Generic;
using Newtonsoft.Json;
using SmartHome.Sensor.USA;
using SmartHome.Sensor.Europe;

namespace TP2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Exercice1();
            Exercice2();
        }
        public static void Exercice1()
        {
            Console.WriteLine("Exercice 1 : Encodeur JSON");
            D d = new D();
            Dictionary<string, object> dict = MyJSON.Serialize(d);
            Console.WriteLine(JsonConvert.SerializeObject(dict, Formatting.Indented));
            Console.WriteLine();
        }
        public static void Exercice2()
        {
            Console.WriteLine("Exercice 2 : Flux de données dynamiques de capteurs");
            EuropeThermometer th = new EuropeThermometer();
            th.Sense();
            Console.WriteLine(th.Temperature);
            Console.WriteLine();
        }

    }
}

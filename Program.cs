using System;
using Sample;
using Encoder;
using System.Collections.Generic;
using Newtonsoft.Json;
using SmartHome;
using SmartHome.Sensors.USA;


namespace TP2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Exercice1();
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
            SensorManager manager = new SensorManager();
            USASensorFactory usaFactory = new USASensorFactory();
            
            manager.AddSensor(usaFactory.CreateThermometer());
            manager.RunSensors();

        }

    }
}

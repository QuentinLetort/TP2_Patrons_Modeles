using System;
using SmartHome.Enumerations;
using Extension;

namespace SmartHome.Sensor.Europe
{
    [Sensor(PhysicalProperty.Temperature, PhysicalUnit.Celsius)]
    public class EuropeThermometer : Thermometer
    {
        public override void Sense()
        {
            Random random = new Random();
            this.Temperature = random.NextDouble(15.0, 25.0);
        }
    }
}
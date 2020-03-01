using System;
using SmartHome.Enumerations;
using Extension;

namespace SmartHome.Sensor.USA
{
    [Sensor(PhysicalProperty.Temperature, PhysicalUnit.Fahrenheit)]
    public class USAThermometer : Thermometer
    {
        public override void Sense()
        {
            Random random = new Random();
            this.Temperature = random.NextDouble(59.0, 77.0);
        }
    }
}
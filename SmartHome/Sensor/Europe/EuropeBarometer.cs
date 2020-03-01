using System;
using SmartHome.Enumerations;
using Extension;

namespace SmartHome.Sensor.Europe
{
    [Sensor(PhysicalProperty.Pressure, PhysicalUnit.Pascal)]
    public class EuropeBarometer : Barometer
    {
        public override void Sense()
        {
            Random random = new Random();
            this.Pressure = random.NextDouble(99500.0, 103000.0);
        }
    }
}
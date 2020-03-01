using System;
using SmartHome.Enumerations;
using Extension;

namespace SmartHome.Sensor.USA
{
    [Sensor(PhysicalProperty.Pressure, PhysicalUnit.InchOfMercury)]
    public class USABarometer : Barometer
    {
        public override void Sense()
        {
            Random random = new Random();
            this.Pressure = random.NextDouble(29.4, 30.4);
        }
    }
}
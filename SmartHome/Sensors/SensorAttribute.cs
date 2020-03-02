using System;
using SmartHome.Enumerations;
namespace SmartHome.Sensors
{
    public class SensorAttribute : Attribute
    {
        public PhysicalProperty property;
        public PhysicalUnit unit;

        public SensorAttribute(PhysicalProperty property, PhysicalUnit unit)
        {
            this.property = property;
            this.unit = unit;
        }
    }
}
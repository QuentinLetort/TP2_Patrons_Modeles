using System;
using SmartHome.Enumerations;
namespace SmartHome.Visualizers
{
    public class VisualizerAttribute : Attribute
    {
        public PhysicalProperty property;
        public PhysicalUnit unit;

        public VisualizerAttribute(PhysicalProperty property, PhysicalUnit unit)
        {
            this.property = property;
            this.unit = unit;
        }
    }
}
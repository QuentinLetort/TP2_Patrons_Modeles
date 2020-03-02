using System;
using SmartHome.Enumerations;

namespace SmartHome.Visualizers
{
    [Visualizer(PhysicalProperty.Temperature, PhysicalUnit.Celsius)]
    public class TemperatureVisualizer : Visualizer
    {
        public override void Visualize()
        {
            Console.WriteLine("La température est : " + this.Data + " degré " + this.Unit);
        }
    }
}
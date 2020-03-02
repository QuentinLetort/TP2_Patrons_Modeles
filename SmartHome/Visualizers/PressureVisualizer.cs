using System;
using SmartHome.Enumerations;
namespace SmartHome.Visualizers
{
    [Visualizer(PhysicalProperty.Pressure, PhysicalUnit.Pascal)]
    public class PressureVisualizer : Visualizer
    {
        public override void Visualize()
        {
            Console.WriteLine("La pression est : " + this.Data + " " + this.Unit);
        }
    }
}
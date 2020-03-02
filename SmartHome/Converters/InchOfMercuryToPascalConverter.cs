using SmartHome.Sensors;
using SmartHome.Visualizers;
using SmartHome.Enumerations;

namespace SmartHome.Converters
{
    [Converter(PhysicalUnit.InchOfMercury, PhysicalUnit.Pascal)]
    public class InchOfMercuryToPascalConverter : Converter
    {
        public InchOfMercuryToPascalConverter(Barometer barometer, PressureVisualizer visualizer) : base(barometer, visualizer)
        { 
        }
        protected override object Convert()
        {
            return (sensor as Barometer).Pressure * 3386;
        }
    }
}
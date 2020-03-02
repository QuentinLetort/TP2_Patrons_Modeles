using SmartHome.Sensors;
using SmartHome.Visualizers;
using SmartHome.Enumerations;
namespace SmartHome.Converters
{
    [Converter(PhysicalUnit.Fahrenheit, PhysicalUnit.Celsius)]
    public class FahrenheitToCelsiusConverter : Converter
    {
        public FahrenheitToCelsiusConverter(Thermometer thermometer, TemperatureVisualizer visualizer) : base(thermometer, visualizer)
        { 
        }
        protected override object Convert()
        {
            return ((sensor as Thermometer).Temperature - 32.0) / 1.8;
        }
    }
}
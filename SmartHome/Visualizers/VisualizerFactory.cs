using SmartHome.Enumerations;

namespace SmartHome.Visualizers
{
    public class VisualizerFactory
    {
        public Visualizer CreateVisualizer(PhysicalProperty property)
        {
            Visualizer result = null;
            switch (property)
            {
                case PhysicalProperty.Temperature:
                    result = new TemperatureVisualizer();
                    break;
                case PhysicalProperty.Pressure:
                    result = new PressureVisualizer();
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
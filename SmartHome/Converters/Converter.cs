using SmartHome.Sensors;
using SmartHome.Visualizers;
namespace SmartHome.Converters
{
    public abstract class Converter : Visualizer, Sensor
    {
        protected Sensor sensor;
        protected Visualizer visualizer;
        protected Converter(Sensor sensor, Visualizer visualizer)
        {
            this.sensor = sensor;
            this.visualizer = visualizer;
        }
        protected abstract object Convert();
        public void Sense()
        {
            this.sensor.Sense();
        }
        public override void Visualize()
        {
            visualizer.Data = Convert();
            visualizer.Visualize();
        }

    }
}
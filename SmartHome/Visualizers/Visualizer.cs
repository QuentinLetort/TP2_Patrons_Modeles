using SmartHome.Enumerations;

namespace SmartHome.Visualizers
{
    public abstract class Visualizer
    {
        private object data;
        private PhysicalUnit unit;
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public PhysicalUnit Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }
        public abstract void Visualize();
    }
}
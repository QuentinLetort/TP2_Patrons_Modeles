namespace SmartHome.Sensor
{
    public abstract class Barometer : Sensor
    {
        private double pressure;
        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
        public abstract void Sense();
    }
}
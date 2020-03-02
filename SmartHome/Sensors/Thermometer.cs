namespace SmartHome.Sensors
{
    public abstract class Thermometer : Sensor
    {
        private double temperature;
        public double Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }
        }
        public abstract void Sense();
    }
}
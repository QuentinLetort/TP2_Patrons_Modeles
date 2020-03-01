namespace SmartHome.Sensor.USA
{
    public class USASensorFactory : SensorFactory
    {
        public Sensor CreateThermometer()
        {
            return new USAThermometer();
        }
        public Sensor CreateBarometer()
        {
            return new USABarometer();
        }
    }
}
namespace SmartHome.Sensor.USA
{
    public class USASensorFactory : SensorFactory
    {
        public Thermometer CreateThermometer()
        {
            return new USAThermometer();
        }
        public Barometer CreateBarometer()
        {
            return new USABarometer();
        }
    }
}
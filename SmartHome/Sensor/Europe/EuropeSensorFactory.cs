namespace SmartHome.Sensor.Europe
{
    public class EuropeSensorFactory : SensorFactory
    {
        public Sensor CreateThermometer()
        {
            return new EuropeThermometer();
        }
        public Sensor CreateBarometer()
        {
            return new EuropeBarometer();
        }
    }
}
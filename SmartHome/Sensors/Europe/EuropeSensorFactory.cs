namespace SmartHome.Sensors.Europe
{
    public class EuropeSensorFactory : SensorFactory
    {
        public Thermometer CreateThermometer()
        {
            return new EuropeThermometer();
        }
        public Barometer CreateBarometer()
        {
            return new EuropeBarometer();
        }
    }
}
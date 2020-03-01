namespace SmartHome.Sensor
{
    public interface SensorFactory
    {
        Thermometer CreateThermometer();
        Barometer CreateBarometer();
    }
}
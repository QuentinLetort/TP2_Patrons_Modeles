namespace SmartHome.Sensors
{
    public interface SensorFactory
    {
        Thermometer CreateThermometer();
        Barometer CreateBarometer();
    }
}
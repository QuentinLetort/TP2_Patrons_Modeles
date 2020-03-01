namespace SmartHome.Sensor
{
    public interface SensorFactory
    {
        Sensor CreateThermometer();
        Sensor CreateBarometer();
    }
}
using System.Reflection;

namespace SmartHome
{
    public class SensorFactory
    {
        public Sensor createSensor(Unity unity, Type type)
        {
            MemberInfo memberInfo = typeof(Sensor);
            SensorAttribute sensorAttribute = (SensorAttribute)memberInfo.GetCustomAttribute(typeof(SensorAttribute));
            sensorAttribute.type = type;
            sensorAttribute.unity = unity;
            return null;
        }
    }
}
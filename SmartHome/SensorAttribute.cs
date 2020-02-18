using System;
namespace SmartHome
{
    public enum Unity
    {
        Celsius,
        Fahrenheit
    }
    public enum Type
    {
        Temperature,
        Pressure
    }
    
    [AttributeUsage(AttributeTargets.Class)]
    public class SensorAttribute : System.Attribute 
    {
        public Unity unity;
        public Type type;

        public SensorAttribute(Unity unity, Type type)
        {
            this.unity = unity;
            this.type = type;
        }
    }
}
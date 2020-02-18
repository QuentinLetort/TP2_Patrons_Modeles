using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace SmartHome
{
    public class SensorManagement 
    {
        private List<Sensor> sensors;

        public SensorManagement() 
        {
            sensors = new List<Sensor>();
        }

        public void addSensor(Sensor sensor) 
        {
            sensors.Add(sensor);
        }

        public void removeSensor(Sensor sensor) 
        {
            sensors.Remove(sensor);
        }

        public void run() 
        {
            
        }
    }
}
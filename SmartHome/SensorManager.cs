using System;
using System.Collections.Generic;
using SmartHome.Sensors;
using SmartHome.Visualizers;
using System.Threading;
using System.Reflection;
using SmartHome.Converters;

namespace SmartHome
{
    public class SensorManager
    {
        private Dictionary<Sensor, Visualizer> dictSensorsVisualizer;
        private Dictionary<Enumerations.PhysicalUnit, Type> converterTypes;
        private VisualizerFactory factory;
        private bool running;
        public SensorManager()
        {
            this.dictSensorsVisualizer = new Dictionary<Sensor, Visualizer>();
            this.converterTypes = new Dictionary<Enumerations.PhysicalUnit, Type>();
            this.factory = new VisualizerFactory();
            this.running = false;
            findConverters();
        }
        public void AddSensor(Sensor sensor)
        {
            if (sensor != null)
            {
                Visualizer visualizer = createVisualizer(sensor);
                if (IsConverterRequired(sensor, visualizer))
                {
                    visualizer = createConverter(sensor, visualizer);
                    ConverterAttribute converterAttribute = (ConverterAttribute)visualizer.GetType().GetCustomAttribute(typeof(ConverterAttribute));
                }
                dictSensorsVisualizer.Add(sensor, visualizer);
            }
        }
        public void RemoveSensor(Sensor sensor)
        {
            this.dictSensorsVisualizer.Remove(sensor);
        }
        public void RunSensors()
        {
            running = true;
            while (running)
            {
                foreach (KeyValuePair<Sensor, Visualizer> pair in dictSensorsVisualizer)
                {
                    ThreadStart threadDelegate = delegate ()
                    {
                        pair.Key.Sense();
                        pair.Value.Visualize();
                    };
                    new Thread(threadDelegate).Start();
                }
                Thread.Sleep(1000);
            }

        }
        public void StopSensors()
        {
            running = false;
        }

        private Visualizer createVisualizer(Sensor sensor)
        {
            Visualizer result = null;
            SensorAttribute sensorAttribute = (SensorAttribute)sensor.GetType().GetCustomAttribute(typeof(SensorAttribute));
            if (sensorAttribute != null)
            {
                result = factory.CreateVisualizer(sensorAttribute.property);
            }
            return result;
        }
        private void findConverters()
        {
            foreach (Type converterType in typeof(Converter).Assembly.GetTypes())
            {
                ConverterAttribute converterAttribute = (ConverterAttribute)converterType.GetCustomAttribute(typeof(ConverterAttribute));
                if (converterAttribute != null)
                {
                    converterTypes.Add(converterAttribute.input, converterType);
                }
            }
        }
        private bool IsConverterRequired(Sensor sensor, Visualizer visualizer)
        {
            bool res = false;
            SensorAttribute sensorAttribute = (SensorAttribute)sensor.GetType().GetCustomAttribute(typeof(SensorAttribute));
            VisualizerAttribute visualizerAttribute = (VisualizerAttribute)visualizer.GetType().GetCustomAttribute(typeof(VisualizerAttribute));
            if (sensorAttribute.unit != visualizerAttribute.unit)
            {
                res = true;
            }
            return res;
        }
        private Converter createConverter(Sensor sensor, Visualizer visualizer)
        {
            SensorAttribute sensorAttribute = (SensorAttribute)sensor.GetType().GetCustomAttribute(typeof(SensorAttribute));
            Type converterType = converterTypes[sensorAttribute.unit];
            ConverterAttribute converterAttribute = (ConverterAttribute)converterType.GetCustomAttribute(typeof(ConverterAttribute));
            visualizer.Unit = converterAttribute.output;
            return (Converter)Activator.CreateInstance(converterType, sensor, visualizer);
        }
    }
}
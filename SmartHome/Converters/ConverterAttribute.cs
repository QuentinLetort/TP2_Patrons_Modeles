using System;
using SmartHome.Enumerations;
namespace SmartHome.Converters
{
    public class ConverterAttribute : Attribute
    {
        public PhysicalUnit input;
        public PhysicalUnit output;

        public ConverterAttribute(PhysicalUnit input, PhysicalUnit output)
        {
            this.input = input;
            this.output = output;
        }
    }
}
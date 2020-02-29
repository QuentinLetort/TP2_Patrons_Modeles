using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Extension
{
    public static class TypeExtensions
    {
        public static IEnumerable<FieldInfo> getAllFields(this Type type)
        {
            List<FieldInfo> fields = new List<FieldInfo>();
            for (Type t = type; t != null; t = t.BaseType)
            {
                fields.AddRange(t.GetRuntimeFields());
            }
            return fields.GroupBy(field => field.Name).Select(group => group.First());
        }
    }
}

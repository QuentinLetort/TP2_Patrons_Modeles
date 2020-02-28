using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;


namespace Encoder
{
    public class MyJSON
    {

        public static Dictionary<string, object> Serialize(object obj)
        {
            return (Dictionary<string, object>)SerializeInternal(obj);

        }

        private static object SerializeInternal(object obj)
        {
            Type objType = obj.GetType();
            if (objType.IsPrimitive || objType.Equals(typeof(string)))
            {
                return obj;
            }
            Dictionary<string, object> result = new Dictionary<string, object>();
            IEnumerable<FieldInfo> fieldsInfo = objType.GetRuntimeFields();
            foreach (FieldInfo field in fieldsInfo)
            {
                object fieldValue = field.GetValue(obj);
                if (!(fieldValue is String) && (fieldValue is Array || fieldValue is IEnumerable))
                {
                    List<object> data = new List<object>();
                    IEnumerator enumerator = ((IEnumerable)fieldValue).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        data.Add(SerializeInternal(enumerator.Current));
                    }
                    result.Add(field.Name, data.ToArray());
                }
                else
                {
                    result.Add(field.Name, SerializeInternal(fieldValue));
                }
            }
            return result;
        }

    }
}
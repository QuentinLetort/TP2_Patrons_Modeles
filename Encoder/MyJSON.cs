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

        private static object SerializeInternal(object obj) {
            Type objType = obj.GetType();
            if (objType.IsPrimitive)
            {
                return obj;
            }
            Dictionary<string, object> result = new Dictionary<string, object>();
            IEnumerable<FieldInfo> fieldsInfo = objType.GetRuntimeFields();
            foreach (FieldInfo field in fieldsInfo)
            {
                if (field.GetValue(obj) is Array || field.GetValue(obj) is IEnumerable)
                {
                    List<object> data = new List<object>();
                    IEnumerator enumerator = ((IEnumerable)field.GetValue(obj)).GetEnumerator();
                    enumerator.Reset();
                    while (enumerator.MoveNext())
                    {
                        data.Add(SerializeInternal(enumerator.Current));
                    }
                    result.Add(field.Name, data.ToArray());
                }
                result.Add(field.Name, SerializeInternal(field.GetValue(obj)));
            }
            return result;

        }

    }
}
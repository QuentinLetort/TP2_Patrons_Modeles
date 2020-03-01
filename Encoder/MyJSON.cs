using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using Extension;

namespace Encoder
{
    public class MyJSON
    {
        public static Dictionary<string, object> Serialize(object obj)
        {
            Dictionary<string, object> result = null;
            if (obj != null)
            {
                result = new Dictionary<string, object>();
                // Récupération de tous les champs définis sur le type spécifié y compris les champs hérités et privés (extension proposée)
                IEnumerable<FieldInfo> fields = obj.GetType().GetAllFields();
                foreach (FieldInfo field in fields)
                {
                    result.Add(field.Name, SerializeInternal(field.GetValue(obj)));
                }
            }
            return result;
        }
        private static object SerializeInternal(object data)
        {
            object result = null;
            if (data != null)
            {
                Type dataType = data.GetType();
                // Condition d'arrêt de la récursion: data est un type primitif ou une string
                if (dataType.IsPrimitive || dataType.Equals(typeof(string)))
                {
                    result = data;
                }
                // cas où data est un IEnumerable (tableau compris)
                else if (typeof(IEnumerable).IsAssignableFrom(dataType))
                {
                    List<object> dataList = new List<object>();
                    IEnumerator enumerator = ((IEnumerable)data).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        dataList.Add(SerializeInternal(enumerator.Current));
                    }
                    result = dataList.ToArray();
                }
                // cas où data est un autre type d'objet
                else
                {
                    result = Serialize(data);
                }
            }
            return result;
        }
    }
}
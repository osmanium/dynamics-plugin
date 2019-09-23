﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kipon.Xrm.DI.Reflection
{
    public class CommonPropertyCache
    {
        private static readonly Dictionary<Type, CommonPropertyCache[]> cache = new Dictionary<Type, CommonPropertyCache[]>();

        public static CommonPropertyCache[] ForType(Type interfaceType, Type entityType)
        {
            if (cache.ContainsKey(interfaceType))
            {
                return cache[interfaceType];
            }

            var interfaceProperties = interfaceType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            var instanceProperties = entityType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            var result = new List<CommonPropertyCache>();

            foreach (var interfaceProp in interfaceProperties)
            {
                var instanceProp = (from i in instanceProperties where i.Name == interfaceProp.Name select i).SingleOrDefault();
                if (instanceProp != null)
                {
                    var customProp = (Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute)instanceProp.GetCustomAttributes(typeof(Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute), false).FirstOrDefault();
                    if (customProp != null)
                    {
                        var attr = new CommonPropertyCache { LogicalName = customProp.LogicalName };
                        attr.Required = interfaceProp.GetCustomAttributes(typeof(Kipon.Xrm.Attributes.RequiredAttribute), false).Any();

                        result.Add(attr);
                    }
                }
            }
            cache[interfaceType] = result.ToArray();
            return cache[interfaceType];
        }

        public string LogicalName { get; private set; }
        public bool Required { get; private set; }
    }
}
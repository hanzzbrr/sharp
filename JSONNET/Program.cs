using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JSONNET
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                FirstName = "James",
                LastName = "Newton-King",
                Roles = new List<string>
                {
                    "Admin"
                }
            };

            string json = JsonConvert.SerializeObject(employee, Formatting.Indented, new KeysJsonConverter(typeof(Employee)));

            Console.WriteLine(json); ;
        }

    }

    public class KeysJsonConverter : JsonConverter
    {
        private readonly Type[] _types;

        public KeysJsonConverter(params Type[] types)
        {
            _types = types;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);
            Console.WriteLine(t.Type);

            if(t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
            }
            else
            {                
                JObject jObject = (JObject)t;
                IList<string> propertyNames = jObject.Properties().Select(prop => prop.Name).ToList();

                jObject.AddFirst(new JProperty("Keys", new JArray(propertyNames)));

                jObject.WriteTo(writer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new Employee();
        }

        public override bool CanRead => false;
        public override bool CanConvert(Type objectType)
        {
            return _types.Any(t => t == objectType);
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<string> Roles { get; set; }
    }
}

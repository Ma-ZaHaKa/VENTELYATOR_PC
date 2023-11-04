using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.IO.Ports;
using System.Reflection;
using System.Threading.Tasks;

namespace Project
{
    public partial class Form1
    {
        class MyObject
        {
            [JsonProperty("string")]
            public string MyString { get; set; }
        }

        static string GetHelloJSON()
        {
            var jsonObject = new
            {
                mode = "hello",
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }

        static string GetSetValueJSON(string _vent, string _value)
        {
            var jsonObject = new
            {
                mode = "set_val",
                vent = _vent,
                value = _value,
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }
        static string GetGetValueJSON(string _vent)
        {
            var jsonObject = new
            {
                mode = "get_val",
                vent = _vent,
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }
        static string GetGetValuesJSON()
        {
            var jsonObject = new
            {
                mode = "get_val",
                //offsets = new[] { "0x2C0" },
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            return json;
        }

    }
}

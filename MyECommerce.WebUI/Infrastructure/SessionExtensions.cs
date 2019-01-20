using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Infrastructure
{
    public static class SessionExtensions
    {
        public static void setJSON(this ISession session,string key,object value) {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T getJSON<T>(this ISession session, string key)
        {
            var data = session.GetString(key);
            return data == null ? default(T) : JsonConvert.DeserializeObject<T>(data);
        }
    }
}

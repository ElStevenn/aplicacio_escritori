using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritori
{
    public class JsonDataManager
    {
        private string filePath;

        public JsonDataManager(string filePath)
        {
            this.filePath = filePath;
        }

        public List<dynamic> LeerJson()
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<dynamic>>(json);
            }
        }

        public void EscribirJson(List<dynamic> data)
        {
            using (StreamWriter w = new StreamWriter(filePath))
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                w.Write(json);
            }
        }

        public void AgregarElemento(dynamic elemento)
        {
            var data = LeerJson();
            data.Add(elemento);
            EscribirJson(data);
        }
    }
}

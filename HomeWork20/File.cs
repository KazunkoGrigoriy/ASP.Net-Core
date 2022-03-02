using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork20
{
    public class File
    {
        public List<Record> Getinfo()
        {
            string json = System.IO.File.ReadAllText("records.json");
            return JsonConvert.DeserializeObject<List<Record>>(json);
        }
    }
}

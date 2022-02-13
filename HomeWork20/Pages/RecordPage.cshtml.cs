using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace HomeWork20.Pages
{
    public class RecordPageModel : PageModel
    {
        public Record record { get; set; }
        public void OnGet(int id)
        {
            string json = System.IO.File.ReadAllText("records.json");
            List<Record> records = JsonConvert.DeserializeObject<List<Record>>(json);
            record = records.FirstOrDefault(e => e.ID == id);
        }
    }
}

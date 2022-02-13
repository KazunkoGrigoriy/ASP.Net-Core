using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace HomeWork20.Pages
{
    public class RecordsBookModel : PageModel
    {
        public List<Record> records { get; set; }
        public void OnGet()
        {
            string json = System.IO.File.ReadAllText("records.json");
            records = JsonConvert.DeserializeObject<List<Record>>(json);
        }
    }
}

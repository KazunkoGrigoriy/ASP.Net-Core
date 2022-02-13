using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork20
{
    public class Record
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string NumberPhone { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }

        public Record(int ID, string LastName, string FirstName, string MiddleName, string NumberPhone, string Adress, string Description)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.NumberPhone = NumberPhone;
            this.Adress = Adress;
            this.Description = Description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
    public class City
    {
        public int ID { get; set; }

        [Display(Name="City Name")]
        public string CityName { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
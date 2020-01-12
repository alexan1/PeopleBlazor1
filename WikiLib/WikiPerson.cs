using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.AspNetCore.Components;
//using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WikiLib
{
    public class WikiPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public DateTime? Birthday { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public DateTime? Death { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        //public decimal Rating { get; set; }
    }
}

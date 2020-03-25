using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApplication.Models
{
    public class DeveloperInformation
    {

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public DeveloperInformation()
        {
            Name = "";
            CreationDate = DateTime.Now;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudMVC.Web.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        public string login { get; set; }

        public string senha { get; set; }

        public string nome { get; set; }

        public string idade { get; set; }

        public string email { get; set; }

        public string endenreco { get; set; }

    }
}
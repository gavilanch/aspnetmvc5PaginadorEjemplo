using PaginadorMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginadorMVC5.ViewModels
{
    public class IndexViewModel : BaseModelo
    {
        public List<Persona> Personas { get; set; }
    }
}
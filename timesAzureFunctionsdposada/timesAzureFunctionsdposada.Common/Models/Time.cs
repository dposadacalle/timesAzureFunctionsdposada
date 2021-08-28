using System;
using System.Collections.Generic;
using System.Text;

namespace timesAzureFunctionsdposada.Common.Models
{
    public class Time
    {
        public int IdEmpleo { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Tipo { get; set; }
        public bool Consolidado { get; set; }
    }
}

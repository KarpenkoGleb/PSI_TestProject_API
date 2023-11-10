using PSI_WebForms.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI_WebForms
{
    internal static class StaticClass
    {
        internal static ClientsDTO ClientObject { get; set; }
        internal static int InvoiceId { get; set;  }
        internal static InvoicesDTO InvoiceObject { get; set; }
    }
}
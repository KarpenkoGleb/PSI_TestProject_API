using System.ComponentModel.DataAnnotations.Schema;

namespace PSI_TestProject_API.Models
{
    [Table("Services")]
    public class Services
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Service")]
        public string Service { get; set; }
        //public ICollection<Invoices> Invoices { get; set; }
    }
}

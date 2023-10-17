using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSI_TestProject_API.Models
{
    [Table("Clients")]
    public class Clients
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Login")]
        public string Login { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Surname")]
        public string Surname { get; set; }

        [Column("Patronymic")]
        public string Patronymic { get; set; }

        [Column("PhoneNumber")]
        public int PhoneNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }
        //public ICollection<Invoices> Invoices { get; set; }
    }
}

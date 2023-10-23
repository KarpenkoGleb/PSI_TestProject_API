using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_WinForms.DTO
{
    internal class ClientsDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

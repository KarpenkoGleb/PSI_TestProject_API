

using System.Windows.Documents;

namespace PSI_WebForms.DTO
{
    internal class ClientsDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; } //int
        public string Email { get; set; }

        public bool Equals(ClientsDTO other)
        {
            if(other == null)
                return false;

            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

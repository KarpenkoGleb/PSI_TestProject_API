

namespace PSI_WebForms.DTO
{
    internal class ServicesDTO
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Service_Descr { get; set; }

        public bool Equals(ServicesDTO other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

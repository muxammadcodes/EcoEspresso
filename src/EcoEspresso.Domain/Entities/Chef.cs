using EcoEspresso.Domain.Commons;

namespace EcoEspresso.Domain.Entities
{
    public class Chef : Auditable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }


        public virtual ICollection<Meal> Meals { get; set; }
    }
}

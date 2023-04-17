using EcoEspresso.Domain.Commons;

namespace EcoEspresso.Domain.Entities
{
    public class Chef : Auditable
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;

        public virtual ICollection<Meal> Meals { get; set; }
    }
}

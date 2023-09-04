using System.Collections.Generic;

namespace autosales.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public virtual ICollection<Car> CarNavigation { get; set; } = new List<Car>();
        public virtual Login? LoginNavigation { get; set; }
    }
}

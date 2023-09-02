using System.Collections.Generic;

namespace autosales.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public virtual Brand? BrandNavigation { get; set; }
        public virtual ICollection<Creation> CreationNavigation { get; set; } = new List<Creation>();
    }
}

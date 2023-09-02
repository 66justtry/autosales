using System.Collections.Generic;

namespace autosales.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Creation> CreationNavigation { get; set; } = new List<Creation>();
        public virtual ICollection<Model> ModelNavigation { get; set; } = new List<Model>();
    }
}

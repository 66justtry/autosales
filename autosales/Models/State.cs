﻿using System.Collections.Generic;

namespace autosales.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public virtual ICollection<Info> InfoNavigation { get; set; } = new List<Info>();
    }
}

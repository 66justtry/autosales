namespace autosales.Models
{
    public class Info
    {
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public int CarId { get; set; }
        public int TypeId { get; set; }
        public int ColorId { get; set; }
        public int StateId { get; set; }
        public virtual Car? CarNavigation { get; set; }
        public virtual Type? TypeNavigation { get; set; }
        public virtual Color? ColorNavigation { get; set; }
        public virtual State? StateNavigation { get; set; }
    }
}

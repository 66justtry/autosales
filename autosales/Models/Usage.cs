namespace autosales.Models
{
    public class Usage
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }
        public bool IsDamaged { get; set; }
        public int Mileage { get; set; }
        public int CarId { get; set; }
        public virtual Car? CarNavigation { get; set; }
    }
}

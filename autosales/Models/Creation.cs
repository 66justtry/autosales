namespace autosales.Models
{
    public class Creation
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public virtual Brand? BrandNavigation { get; set; }
        public virtual Model? ModelNavigation { get; set; }
        public virtual Car? CarNavigation { get; set; }
    }
}

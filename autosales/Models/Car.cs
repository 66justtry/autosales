namespace autosales.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public virtual Creation? CreationNavigation { get; set; }
        public virtual Usage? UsageNavigation { get; set; }
        public virtual Info? InfoNavigation { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}

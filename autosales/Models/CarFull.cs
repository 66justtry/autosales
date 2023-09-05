namespace autosales.Models
{
    public class CarFull
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public bool IsDeleted { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsNew { get; set; }
        public bool IsDamaged { get; set; }
        public int Mileage { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string State { get; set; }
    }
}

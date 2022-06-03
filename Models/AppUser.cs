namespace RunGroupWebApplicationTeddySmith.Models
{
    public class AppUser 
    {
        public int? Pace { get; set; }

        public int? Mileage { get; set; }
        public Address? MyProperty { get; set; }

        public ICollection<Clubs> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}

namespace FootballPlayer
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }


        public void ValidateName()
        {
            if(Name.Length < 2)
                throw new ArgumentException(nameof(Name));
        }

        public void ValidateAge()
        {
            if (Age < 1)
                throw new ArgumentOutOfRangeException(nameof(Age));
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 2 || ShirtNumber > 100)
                throw new ArgumentOutOfRangeException(nameof(ShirtNumber));
        }
    }
}
namespace Rental.Models.Movie
{
    public interface IMovie : IItem
    {
        
        int ID { get; set; }
        string Title { get; set; }
        
        string Description { get; set; }
        

        int Duration { get; set; }

        double Rating { get; set; }
    }


    public class Movie : IMovie{
        public int ID { get; set; }
        public string Title { get; set; }

        public  string Description { get; set; }


        public int Duration { get; set; }

        public double Rating { get; set; }
    }
}
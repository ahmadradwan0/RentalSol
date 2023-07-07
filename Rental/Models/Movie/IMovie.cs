namespace Rental.Models.Movie
{
    public interface IMovie : IItem
    {
        /*
        int ID { get; set; }
        string Title { get; set; }
        
        string Description { get; set; }
        */

        //its own ... 

        int Duration { get; set; }

        double Rating { get; set; }
    }
}
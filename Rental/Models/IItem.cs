namespace Rental.Models
{
    public interface IItem
    {
        
        int ID { get; set; }
        
        string Title { get; set; }

        string Description { get; set; }
        
    }
}
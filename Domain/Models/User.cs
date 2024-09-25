namespace Domain.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string HashPassword { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; }
    public string? Code { get; set; }
    public DateTime CodeTime { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<Car> Cars { get; set; }
    public List<Bid> Bids { get; set; }
    public List<Payment> Payments { get; set; }
}

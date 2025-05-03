namespace ApiProject.WebApi.Entities;

public class Reservation
{
    public int Id { get; set; }
    public int CountofPeople { get; set; }
    public string? NameSurname { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ReservationTime { get; set; }
    public string? Massage { get; set; }
    public string? ReservationStatus { get; set; }
    public DateTime ReservationDate { get; set; }
}

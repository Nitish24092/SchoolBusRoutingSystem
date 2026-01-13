namespace SchoolBusRoutingSystem.Models;
public class School
{
    public int SchoolId { get; set; }
    public string Name { get; set; } = "";

    public  Location Loaction { get; set; }
}
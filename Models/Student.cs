namespace SchoolBusRoutingSystem.Models;
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; } = "";
    public int SchoolId { get; set; }
    public Location HomeLocation { get; set; }   
}
using System.Collections.Generic;
namespace SchoolBusRoutingSystem.Models;
public class Route
{
    public Bus Bus { get; set; } = new();
    public Driver Driver { get; set; } = new();
    public School School { get; set; } = new();
    public List<Student> Students { get; set; } = new();

    public double TotalDistance { get; set; }   
}
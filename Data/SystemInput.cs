using System.Collections.Generic;
using SchoolBusRoutingSystem.Models;
namespace SchoolBusRoutingSystem.Data;
public class SystemInput
{
    public List<Student> Students { get; set; } = new();
    public List<School> Schools { get; set; } = new();
    public List<Bus> Buses { get; set; } = new();
    public List<Driver> Drivers { get; set; } = new();
}
using SchoolBusRoutingSystem.Data;
using SchoolBusRoutingSystem.Models;
using SchoolBusRoutingSystem.Services;

Console.WriteLine("=== School Bus Routing System ===\n");

var input = SampleData.Build();
var planner = new RoutePlanner();

var morningRoutes = planner.GenerateMorningRoutes(input);
var eveningRoutes = planner.GenerateEveningRoutes(morningRoutes);

foreach (var route in morningRoutes)
{
    PrintRoute("Morning", route);
}

foreach (var route in eveningRoutes)
{
    PrintRoute("Evening", route);
}

static void PrintRoute(string type, Route route)
{
    Console.WriteLine($"[{type} Route]");
    Console.WriteLine($"Bus: {route.Bus.BusId}");
    Console.WriteLine($"Capacity: {route.Bus.Capacity}");
    Console.WriteLine($"Driver: {route.Driver.Name}");
    Console.WriteLine($"Total Students: {route.Students.Count}");
    Console.WriteLine("Route:");
    if (type == "Morning")
    {
        Console.WriteLine(" - Depot");
        foreach (var s in route.Students)
            Console.WriteLine($" - {s.StudentId} | {s.Name} | Home");
        Console.WriteLine($" - {route.School.Name} (SchoolId: {route.School.SchoolId})");
    }
    else
    {
        Console.WriteLine($" - {route.School.Name} (SchoolId: {route.School.SchoolId})");
        foreach (var s in route.Students.AsEnumerable().Reverse())
            Console.WriteLine($" - {s.StudentId} | {s.Name} | Home");
        Console.WriteLine(" - Depot");
    }
    Console.WriteLine();
}
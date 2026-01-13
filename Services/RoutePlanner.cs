using SchoolBusRoutingSystem.Data;
using SchoolBusRoutingSystem.Models;
namespace SchoolBusRoutingSystem.Services;
public class RoutePlanner
{
    public List<Route> GenerateMorningRoutes(SystemInput input)
    {
        var routes = new List<Route>();
        int studentIndex = 0;

        foreach (var bus in input.Buses)
        {
            if (studentIndex >= input.Students.Count)
                break;

            var route = new Route
            {
                Bus = bus,
                Driver = input.Drivers[routes.Count],
                School = input.Schools[routes.Count % input.Schools.Count]
            };

            while (route.Students.Count < bus.Capacity &&
                   studentIndex < input.Students.Count)
            {
                route.Students.Add(input.Students[studentIndex]);
                studentIndex++;
            }
            route.TotalDistance = 0;
            for (int i = 0; i < route.Students.Count - 1; i++)
            {
                route.TotalDistance += DistanceCalculater.Calculate(
                    route.Students[i].HomeLocation,
                    route.Students[i + 1].HomeLocation
                );
            }

            route.TotalDistance += DistanceCalculater.Calculate(
                route.Students[^1].HomeLocation,
                route.School.Loaction
            );

            routes.Add(route);

        }
        return routes;
    }

        public List<Route> GenerateEveningRoutes(List<Route> morningRoutes)
    {
        var eveningRoutes = new List<Route>();

        foreach (var morningRoute in morningRoutes)
        {
            var eveningRoute = new Route
            {
                Bus = morningRoute.Bus,
                Driver = morningRoute.Driver,
                School = morningRoute.School
            };

            //  revers (School to Home student )
            for (int i = morningRoute.Students.Count - 1; i >= 0; i--)
            {
                eveningRoute.Students.Add(morningRoute.Students[i]);
            }

            eveningRoutes.Add(eveningRoute);
        }

        return eveningRoutes;
    }
}
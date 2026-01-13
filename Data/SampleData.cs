using SchoolBusRoutingSystem.Models;
namespace SchoolBusRoutingSystem.Data;
public static class SampleData
{
    public static SystemInput Build()
    {
        var input = new SystemInput();

        input.Schools.Add(new School { SchoolId = 1, Name = "GreenValley" });
        input.Schools.Add(new School { SchoolId = 2, Name = "HillSide" });

        input.Buses.Add(new Bus { BusId = 1, Capacity = 20 });
        input.Buses.Add(new Bus { BusId = 2, Capacity = 15 });
        input.Buses.Add(new Bus { BusId = 3, Capacity = 10 });

        input.Drivers.Add(new Driver { DriverId = 1, Name = "John Carter" });
        input.Drivers.Add(new Driver { DriverId = 2, Name = "Mike Ross" });
        input.Drivers.Add(new Driver { DriverId = 3, Name = "David Clark" });

        string[] names = {
            "Alice","Bob","Charlie","Emma","Olivia","Noah","Liam","Sophia","James","Mia",
            "Lucas","Ava","Ethan","Isabella","Logan","Amelia","Daniel","Harper","Henry","Ella",
            "Jack","Grace","Leo","Chloe","Ryan","Lily","Nathan","Zoe","Owen","Hannah",
            "Caleb","Nora","Isaac","Lucy","Aaron","Aria","Samuel","Ruby","Adam","Eva"
        };

        for (int i = 0; i < 40; i++)
        {
            input.Students.Add(new Student
            {
                StudentId = i + 1,
                Name = names[i],
                SchoolId = (i < 20) ? 1 : 2
            });
        }

        return input;
    }
}
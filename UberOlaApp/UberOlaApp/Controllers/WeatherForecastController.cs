using Microsoft.AspNetCore.Mvc;
using UberOlaApp.Common.Enums;
using UberOlaApp.Managers;
using UberOlaApp.Models;

namespace UberOlaApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    Rider ramRider = new Rider("Ram", EnRATING.FIVE_STARS);
        //    Rider shamRider = new Rider("Sham", EnRATING.FIVE_STARS);
        //    RiderManager riderMgr = RiderManager.GetRiderManager();
        //    riderMgr.AddRider("Ram", ramRider);
        //    riderMgr.AddRider("Sham", shamRider);

        //    Driver shivDriver = new Driver("Shiv", EnRATING.THREE_STARS);
        //    Driver rajDriver = new Driver("Raj", EnRATING.FOUR_STARS);
        //    DriverManager driverMgr = DriverManager.GetDriverManager();
        //    driverMgr.AddDriver("Shiv", shivDriver);
        //    driverMgr.AddDriver("Raj", rajDriver);


        //    TripManager tripMgr = TripManager.GetTripManager();
        //    Console.WriteLine("Creating Trip for Ram from location (10,10) to (30,30)");

        //    tripMgr.CreateTrip(ramRider, new Location(10, 10), new Location(30, 30));
        //    Console.WriteLine();

        //    Console.WriteLine("Creating Trip for Sham from location (200,200) to (500,500)");

        //    tripMgr.CreateTrip(shamRider, new Location(200, 200), new Location(500, 500));

        //    Dictionary<int, Trip> tripsMap = tripMgr.GetTripsMap();

        //    foreach (var mapVal in tripsMap)
        //    {
        //        mapVal.Value.displayTripDetails();
        //    }





        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //    //return Enumerable.Range(1, 1).Select(index => new Trip
        //    //{
        //    //    Rider = new Rider("TestRider", EnRATING.THREE_STARS),
        //    //    Driver = new Driver("TestDriver", EnRATING.THREE_STARS),
        //    //    srcLoc = new Location(0.053, 0.072),
        //    //    dstLoc = new Location(0.033, 0.052),
        //    //    Price = 100
        //    //})
        //    //.ToArray();



        //}

        [HttpGet(Name = "GetWeatherForecast")]
        public Dictionary<int, Trip> Get()
        {
            Rider ramRider = new Rider("Ram", EnRATING.FIVE_STARS);
            Rider shamRider = new Rider("Sham", EnRATING.FIVE_STARS);
            RiderManager riderMgr = RiderManager.GetRiderManager();
            riderMgr.AddRider("Ram", ramRider);
            riderMgr.AddRider("Sham", shamRider);

            Driver shivDriver = new Driver("Shiv", EnRATING.THREE_STARS);
            Driver rajDriver = new Driver("Raj", EnRATING.FOUR_STARS);
            DriverManager driverMgr = DriverManager.GetDriverManager();
            driverMgr.AddDriver("Shiv", shivDriver);
            driverMgr.AddDriver("Raj", rajDriver);


            TripManager tripMgr = TripManager.GetTripManager();
            Console.WriteLine("Creating Trip for Ram from location (10,10) to (30,30)");

            tripMgr.CreateTrip(ramRider, new Location(10, 10), new Location(30, 30));
            Console.WriteLine();

            Console.WriteLine("Creating Trip for Sham from location (200,200) to (500,500)");

            tripMgr.CreateTrip(shamRider, new Location(200, 200), new Location(500, 500));


            Dictionary<int, Trip> tripsMap = tripMgr.GetTripsMap();

            foreach (var mapVal in tripsMap)
            {
                mapVal.Value.displayTripDetails();
            }

            return tripsMap;

            //return Enumerable.Range(1, 2).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();

        }
    }
}
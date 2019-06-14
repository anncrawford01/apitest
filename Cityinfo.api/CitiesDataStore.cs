using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cityinfo.api.Models;

namespace Cityinfo.api
{
    
    public class CitiesDataStore
    {

        public static CitiesDataStore Current { get; } = new CitiesDataStore();  // auto properties initializer
        public List<CityDto> Cities { get; set; }
  
        public CitiesDataStore()
        {
            // init dumm data
            Cities = new List<CityDto>()
            { 
            new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                    new PointOfInterestDto() {
                        Id = 1,
                        Name = "Central Park",
                        Description = "The most vistied urban part in the United States." },
                    new PointOfInterestDto() {
                        Id = 2,
                        Name = "Empire State Bilding",
                        Description = "A 102 story skyscraper located in Maidtown Manhattan." },
                    }

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the catheral that was never really finished."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with the big tower."
                },
            };
        }
    }
}

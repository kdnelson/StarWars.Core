using System.Collections.Generic;

namespace StarWars.Dtos.Response.Vehicle
{
    public class VehicleSearchResponseDto
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<VehicleResults> results { get; set; }

        VehicleSearchResponseDto()
        {
            results = new List<VehicleResults>();
        }
    }

    public class VehicleResults
    {
        public string name { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string cost_in_credits { get; set; }
        public string length { get; set; }
        public string max_atmosphering_speed { get; set; }
        public string crew { get; set; }
        public string passengers { get; set; }
        public string cargo_capacity { get; set; }
        public string consumables { get; set; }
        public string vehicle_class { get; set; }
        public List<string> pilots { get; set; }
        public List<string> films { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }

        public VehicleResults()
        {
            pilots = new List<string>();
            films = new List<string>();
        }
    }
}
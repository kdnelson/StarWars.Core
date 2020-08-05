using StarWars.Models.Vehicle;
using System.Collections.Generic;

namespace StarWars.Models
{
    public class ManufacturerModel
    {
        public string Name { get; set; }
        public string GroupListCount { get; set; }
        public int CostInCreditsPerGroupAverage { get; set; }
        public List<VehicleModel> GroupList { get; set; }

        public ManufacturerModel()
        {
            GroupList = new List<VehicleModel>();
        }
    }
}

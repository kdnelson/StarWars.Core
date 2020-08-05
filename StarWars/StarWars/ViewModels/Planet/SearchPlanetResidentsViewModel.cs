using StarWars.Models;
using System.Collections.Generic;

namespace StarWars.ViewModels.Planet
{
    public class SearchPlanetResidentsViewModel
    {
        public string Name { get; set; }
        public List<PeopleModel> ResidentlList { get; set; }

        public SearchPlanetResidentsViewModel()
        {
            ResidentlList = new List<PeopleModel>();
        }
    }
}

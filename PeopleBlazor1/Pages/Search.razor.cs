using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WikiLib;

namespace PeopleBlazor1.Pages
{
    public partial class Search : ComponentBase
    {
        string SearchName;

        public Collection<WikiPerson> People { get; set; }  



        protected override async Task OnInitializedAsync()
        {

        }

        private void SearchPeople()
        {
            People = Wiki.WikiSearch(SearchName).Result;
        }
    }
}

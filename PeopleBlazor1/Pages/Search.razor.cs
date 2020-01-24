using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WikiLib;

namespace PeopleBlazor1.Pages
{
    public partial class Search : ComponentBase
    {
        string SearchName;

        private Collection<WikiPerson> People { get; set; }



        protected override async Task OnInitializedAsync()
        {

        }

        private async void SearchPeople()
        {
            //var name = e.Value.ToString();
            People = await Wiki.WikiSearch(SearchName);

        }
    }
}

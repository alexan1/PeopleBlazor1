using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WikiLib;

namespace PeopleBlazor1.Pages
{
    public partial class Search : ComponentBase
    {
        string SearchName;

        Collection<WikiPerson> People => Wiki.WikiSearch(SearchName).Result;

        protected override async Task OnInitializedAsync()
        {

        }
    }
}

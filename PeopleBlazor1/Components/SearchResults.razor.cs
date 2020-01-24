using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using WikiLib;

namespace PeopleBlazor1.Components
{
    public partial class SearchResults : ComponentBase
    {
        [Parameter]
        public Collection<WikiPerson> People { get; set; }
    }
}

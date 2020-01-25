using Microsoft.AspNetCore.Components;
using WikiLib;

namespace PeopleBlazor1.Components
{
    public partial class PersonShort : ComponentBase
    {
        [Parameter]
        public WikiPerson Person { get; set; }
    }
}

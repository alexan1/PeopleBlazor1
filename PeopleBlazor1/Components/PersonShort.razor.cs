using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiLib;

namespace PeopleBlazor1.Components
{
    public partial class PersonShort : ComponentBase
    {
        [Parameter]
        public WikiPerson Person { get; set; }
    }
}

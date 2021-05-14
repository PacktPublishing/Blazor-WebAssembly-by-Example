using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Pages
{
    public partial class Counter
    {
        [Parameter] public int? Increment { get; set; }
        private int increment = 1;

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount += increment;
        }

        protected override void OnParametersSet()
        {
            if (Increment.HasValue)
                increment = Increment.Value;
        }
    }
}

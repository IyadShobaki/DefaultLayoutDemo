using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class CounterBase : ComponentBase
    {
        
        protected int currentCount = 0;

        [Inject]
        public ILogger<CounterBase> Log { get; set; }


        protected void IncrementCount()
        {
            currentCount+=2;
            Log.LogInformation("The new value is {CounterValue}", currentCount);
        }
    }
}

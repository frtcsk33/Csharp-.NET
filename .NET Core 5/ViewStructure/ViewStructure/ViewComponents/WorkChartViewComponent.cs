using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
    public class WorkChartViewComponent: ViewComponent
    {
        List<WorkChart> workChart = new List<WorkChart>()
        {
            new WorkChart("Abdullah", new List<bool>(){true,true,false,true,false}),
            new WorkChart("Hakan", new List<bool>(){false,true,false,false,true}),
            new WorkChart("Esma", new List<bool>(){true,true,false,false,false}),
            new WorkChart("Feyza", new List<bool>(){false,true,false,true,false}),
                
        };
        public IViewComponentResult Invoke(int id)
        {
            return View(workChart);
        }
    }
}

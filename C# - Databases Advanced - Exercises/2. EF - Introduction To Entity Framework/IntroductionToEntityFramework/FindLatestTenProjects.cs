﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToEntityFramework
{
    class FindLatestTenProjects
    {
        public static void FindingLatestTenProjects(SoftuniContext context)
        {
            var projects = context.Projects.OrderByDescending(x => x.StartDate)
                                           .Take(10);

            foreach (var project in projects.OrderBy(x => x.Name))
            {
                string dateTimeFormat = "M/d/yyyy h:mm:ss tt";
                Console.WriteLine($"{project.Name} {project.Description} {project.StartDate.ToString(dateTimeFormat, CultureInfo.InvariantCulture)} {project.EndDate}");
            }
        }
    }
}

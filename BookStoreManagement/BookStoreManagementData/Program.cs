using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementData
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<StudentPlanManagementContext>(new StudentPlanManagementInitializer());
            StudentPlanManagementContext context = new StudentPlanManagementContext();
            context.StudentEntities.Select(st => st);
        }
    }
}

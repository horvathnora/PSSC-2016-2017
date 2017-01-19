using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var subjects = new List<Models.Subject>
            {
                 new Models.Subject{RegistrationNumber="123",Name="Alexander",StudyYear=2}
            };

            //subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DAL
{
    public class SchoolContext : System.Data.Entity.DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

        
    }
}
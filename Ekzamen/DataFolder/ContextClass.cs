﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ekzamen.DataFolder
{
    internal class ContextClass
    {
        public partial class DBEntities : DbContext
        {
            private static DBEntities context;

            public static DBEntities GetContext()
            {
                if (context == null)
                {
                    context = new DBEntities();
                }
                return context;
            }
        }
    }
}

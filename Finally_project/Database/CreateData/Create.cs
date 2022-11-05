using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Finally_project.Database.Models;
using System.Windows.Forms;
using System.Drawing;

namespace Finally_project.Database.CreateData
{
    public class Create
    {
        private static void VerifyDatabaseExists()
        {
            using (var context = new ModelQuanLyCuaHangQuanAo())
            {
                context.Database.CreateIfNotExists();
            }
        }
        public static void Start()
        {           
            VerifyDatabaseExists();
        }
    }
   
}

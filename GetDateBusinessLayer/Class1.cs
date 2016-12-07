using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDateDatabaseLayer;

namespace GetDateBusinessLayer
{
    public class BusinessLogic
    {
        public DateTime GetDate()
        {
            Database database = new Database();
            return database.GetDate();
        }
    }
}

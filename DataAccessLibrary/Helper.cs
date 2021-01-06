using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DataAccessLibrary
{
    public static class Helper
    {
        public static String CnnVal(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

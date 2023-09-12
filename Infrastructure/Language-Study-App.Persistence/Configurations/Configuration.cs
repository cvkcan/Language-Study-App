using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Persistence.Configurations
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get 
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Directory.GetCurrentDirectory());
                configurationManager.AddJsonFile("json1.json");
                return configurationManager.GetConnectionString("SqlServer");
            }
        }
    }
}

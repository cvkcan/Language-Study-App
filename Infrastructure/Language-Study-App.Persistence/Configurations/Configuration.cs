using Microsoft.Extensions.Configuration;

namespace Language_Study_App.Persistence.Configurations
{
    public static class Configuration
    {
        public static  string ConnectionString
        {
            get 
            {
                string jsonPath = @"C:\\Users\\safac\\Source\\Repos\\Language-Study-App\\Infrastructure\\Language-Study-App.Persistence\\";
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(jsonPath);
                configurationManager.AddJsonFile("json1.json");
                return configurationManager.GetConnectionString("SqlServer");
            }
        }
    }
}

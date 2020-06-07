using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConnectionFactoryDb
{
    public sealed class DatabaseFactory
    {
        public static DatabaseFactorySectionHandler sectionHandler /*= 
            (DatabaseFactorySectionHandler)ConfigurationManager.GetSection("DatabaseFactoryConfiguration") */;
        /// <summary>
        /// Constructor de objeto
        /// </summary>
        private DatabaseFactory() { }

        public static Database CreateDatabase()
        {
            try
            {
                sectionHandler =
                (DatabaseFactorySectionHandler)ConfigurationManager.GetSection("DatabaseFactoryConfiguration");

                // Verify a DatabaseFactoryConfiguration line exists in the web.config.
                if (sectionHandler.Name.Length == 0)
                {
                    throw new Exception("Database name not defined in DatabaseFactoryConfiguration section of web.config.");
                }


                // Find the class
                Type database = Type.GetType(sectionHandler.Name);

                // Get it's constructor
                ConstructorInfo constructor = database.GetConstructor(new Type[] { });

                // Invoke it's constructor, which returns an instance.
                Database createdObject = (Database)constructor.Invoke(null);

                // Initialize the connection string property for the database.
                createdObject.connectionString = sectionHandler.ConnectionString;

                // Pass back the instance as a Database
                return createdObject;
            }
            catch (Exception excep)
            {
                throw new Exception("Error instantiating database " + sectionHandler.Name + ". " + excep.Message);
            }
        }

    }
}

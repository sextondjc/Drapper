using Drapper;
using Newtonsoft.Json;
using System.IO;
using Drapper.Configuration;
using Drapper.Configuration.Json;

namespace Sample.Repositories.Tests
{
    /// <summary>
    /// Utility class to return an instance of the IDbCommander.
    /// Bootstrapping the IDbCommander with your IoC framework of choice
    /// would follow a conceptually similar approach.
    /// </summary>
    public static class CommanderHelper
    {
        /// <summary>
        /// Creates a commander instance.
        /// </summary>
        /// <returns></returns>
        public static IDbCommander CreateCommander()
        {
            var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Drapper.Settings.json"));
            var reader = new JsonFileCommandReader(settings);
            var connector = new DbConnector(settings);
            return new DbCommander(connector, reader);
        }
    }
}

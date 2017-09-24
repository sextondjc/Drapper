using System.Collections.Generic;
using Drapper.Readers.Databases.Unit.Tests.DatabaseCommandReaderTests;
using Drapper.Settings.Databases;

namespace Drapper.Readers.Databases.Unit.Tests
{
    public static class SettingsDouble
    {
        public static IDatabaseCommanderSettings GetSettings()
        {
            return new DatabaseCommanderSettings(
                new List<DatabaseCommandNamespaceSetting> {
                    new DatabaseCommandNamespaceSetting(
                        typeof(GetCommand).Namespace,
                        new List<DatabaseCommandTypeSetting>
                        {
                            new DatabaseCommandTypeSetting(
                                typeof(Constructor).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] = new DatabaseCommandSetting("test_alias", "select 'Readers.Test.Settings'")
                                }),
                            new DatabaseCommandTypeSetting(
                                typeof(GetCommand).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] = new DatabaseCommandSetting("test_alias", "select 'Readers.Test.Settings'")
                                })
                        })
                        }
                , new List<ConnectionStringSetting>
                {
                    new ConnectionStringSetting("test_alias", "providerName", "connectionString")
                });
        }
    }
}

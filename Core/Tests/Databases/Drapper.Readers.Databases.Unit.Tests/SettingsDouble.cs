//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

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
                new List<DatabaseCommandNamespaceSetting>
                {
                    new DatabaseCommandNamespaceSetting(
                        typeof(GetCommand).Namespace,
                        new List<DatabaseCommandTypeSetting>
                        {
                            new DatabaseCommandTypeSetting(
                                typeof(Constructor).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] =
                                    new DatabaseCommandSetting("test_alias", "select 'Readers.Test.Settings'")
                                }),
                            new DatabaseCommandTypeSetting(
                                typeof(GetCommand).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] =
                                    new DatabaseCommandSetting("test_alias", "select 'Readers.Test.Settings'")
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
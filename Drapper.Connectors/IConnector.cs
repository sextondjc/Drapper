using Drapper.Settings;

namespace Drapper.Connectors
{
    /// <summary>
    /// Defines a contract for all connectors. The contract depends 
    /// on the type of <see cref="ICommandSetting"/> defined for
    /// this connection to use.
    /// </summary>
    /// <typeparam name="TConnection">The connection to be returned.</typeparam>
    /// <typeparam name="TCommandSetting"></typeparam>
    public interface IConnector<out TConnection, in TCommandSetting> where TCommandSetting : ICommandSetting
    {
        TConnection CreateConnection(TCommandSetting commandSetting);
    }
}
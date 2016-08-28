// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    [ConfigurationCollection(typeof(CommandSettingCollectionElement))]
    public class CommandSettingElementCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "command";

        public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMapAlternate;

        protected override string ElementName => PropertyName;
                
        public override bool IsReadOnly() => false;

        protected override ConfigurationElement CreateNewElement() => new CommandSettingCollectionElement();

        protected override object GetElementKey(ConfigurationElement element) => ((CommandSettingCollectionElement)(element)).Name;

        public new CommandSettingCollectionElement this[string name] => (CommandSettingCollectionElement)BaseGet(name);
    }
}

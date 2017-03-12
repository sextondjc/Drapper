// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    [ConfigurationCollection(typeof(NamespaceSettingElement))]
    public class NamespaceSettingElementCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "namespace";

        public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMapAlternate;

        protected override string ElementName => PropertyName;

        public override bool IsReadOnly() => false;

        protected override ConfigurationElement CreateNewElement() => new NamespaceSettingElement();

        protected override object GetElementKey(ConfigurationElement element) => ((NamespaceSettingElement)(element)).Namespace;

        public new NamespaceSettingElement this[string name] => (NamespaceSettingElement)BaseGet(name);
    }
}

// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    [ConfigurationCollection(typeof(TypeSettingElement))]
    public class TypeSettingElementCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "type";

        public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMapAlternate;

        protected override string ElementName => PropertyName;

        public override bool IsReadOnly() => false;

        protected override ConfigurationElement CreateNewElement() => new TypeSettingElement();

        protected override object GetElementKey(ConfigurationElement element) => ((TypeSettingElement)(element)).Name;

        public new TypeSettingElement this[string name] => (TypeSettingElement)BaseGet(name);
    }
}

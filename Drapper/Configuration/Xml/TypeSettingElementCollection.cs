// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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

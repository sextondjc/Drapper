// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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

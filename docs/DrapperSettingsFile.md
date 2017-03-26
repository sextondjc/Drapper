# Drapper Settings File

When you install Drapper via nuget, it will include a file called `Drapper.Settings.json` in the assembly chosen for installation. This file serves as a 
template for building a json configuration file. This file can be renamed to whatever you choose and can be stored anywhere accessible to your application. 
For consistency and familiarity, it's recommended to keep this file in your application root, like where you might keep your Web.config or App.config files.

The settings file can act as a centralised store of command settings or it can define where a command setting can be found. You can split your command settings at the 
namespace or type level. In other words, you could have all command settings for a given namespace in a completely separate file or, if you need to be more 
granular, you can change the command settings for a given type stored in a separate file. 
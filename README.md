# Drapper
An abstraction layer for Dapper

1.1.0 under development and not yet stable.

[![Build status](https://ci.appveyor.com/api/projects/status/u0jfhnuc0jm348xj/branch/1.1.0?svg=true)](https://ci.appveyor.com/project/sextondjc/drapper)

##Goals for 1.1.0

###Must haves: 

* Reduce test setup friction by removing .sql database creation scripts. Test database and it's relevant objects/data must be created/destroyed by the tests themselves. [Issue 6](https://github.com/sextondjc/Drapper/issues/6)
* Correct single level namespace bug. 
* Improve JsonFileCommandReader CommandSetting resolution. 
* Write tests to prove support for relative paths to JSON command files (it is supported, but tests don't reflect it.). 
* Make type argument mandatory for Async methods OR find a reliable means to derive caller type for parameterless Async methods. [Issue 2](https://github.com/sextondjc/Drapper/issues/2)
* Support parameterless Execute overload. 
* Unseal command readers & provide virtual methods for overriding. 

###Nice to haves:
* Provide a reliable means to derive caller type for Async methods. This would preserve the parameterless Async methods (which would be nice). 
* Remove dependency on System.Diagnostics namespace. Not sure this is possible while still preserving parameterless methods. 
* Support the /optimize switch. [Issue 1](https://github.com/sextondjc/Drapper/issues/1)

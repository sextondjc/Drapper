# Drapper
A data access / object composition library built on top of Dapper

* Available on nuget: https://www.nuget.org/packages/Drapper/
* Supports .NET 4.5.2/4.6.1.
* Built on top of [Dapper](https://github.com/StackExchange/dapper-dot-net).
* Keeps .NET and SQL code separate from each other.
* async/await support.
* Read the [wiki](https://github.com/sextondjc/Drapper/wiki).

Ever just wanted to execute a bit of SQL without jumping through the hoops imposed by other frameworks? Are you annoyed by the quirks of the monolithic ORM's? Tired of the limitations their design impose on your code? Tired of [fighting the framework](https://www.epiphanysearch.co.uk/news/2012/dont-fight-the-framework/)?

Then Drapper is for you. Drapper deliberately stays out of your way allowing you the choice of how to build _your_ application _your_ way. 

You provide Drapper with the SQL to be executed. There is no auto-generated SQL. You will know the needs of your application better than any auto-generated SQL provider. That said, if you really do want auto-generated SQL you can plug this into Drapper by implementing an _ICommandReader_ that will return a _CommandSetting_ for you.



***Quick Look***

The heart of Drapper is the IDbCommander. It's an interface which exposes overloads of only 2 methods - _Query_ and _Execute_. _Query_ is used for data retrieval operations while _Execute_ is used for persistence/data changing operations. Both methods come in Async flavours as well. 

_Query_
```
IDbCommander _commander;

// retrieve all
_commander.Query<Country>()

// retrieve with parameters
_commander.Query<Country>(new { language = "English" });

// retrieve single
_commander.Query<Country>(new { code = "ZA" }).SingleOrDefault();

// map complex types
_commander.Query<Country, Currency, Country>(
    (country, currency) => 
    { 
        country.Currency = currency; 
        return country; 
    });

// map _really_ complex types
_commander.Query(Map.ReallyComplexMapping); // where Map.ComplexMapping is a Func<> with up to 16 inputs!

```
_Execute_
```
// all persistence operations are transactional. 
// transactions spanning multiple instances are automatically
// escalated to DTC. 

// persist a complex type
_commander.Execute(country);

// persist an object graph. each Execute call
// can target a different database instance if 
// you need it to! 
_commander.Execute(() => 
    {
        _commander.Execute(country);
        _commander.Execute(country.Currency, method:"SaveCurrency");
        _commander.Execute(country.States, method:"SaveStates");
    });
```

Drapper allows you to build complex object graphs from your data with ease as well as persist objects in a consistent, predictable and reliable way. 

Drapper was built on top of the [Dapper Micro ORM](https://github.com/StackExchange/dapper-dot-net) and works across all the same providers supported by Dapper including SQLite, SQL CE, Firebird, Oracle, MySQL, PostgreSQL and SQL Server. 

**Drapper?**
This project started as a "wrapper for Dapper". The portmanteau kinda wrote itself. 

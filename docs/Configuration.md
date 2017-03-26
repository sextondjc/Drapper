# Configuration

Drapper is highly configurable. It supports configuration from JSON files, XML files, in-memory implementation, custom implementation or - if you 
choose - a combination of any type. All configuration is to support a common objective - to resolve a CommandSetting for a given method.

The rationale behind the configuration in Drapper is that once a repository class has been written, it should not need to change if the circumstances 
surrounding the underlying database technology changes. For instance, if you need to change from using text direct to a stored procedure there is no
need to alter the repository code. All that would be required is a change to the configuration source. Likewise, if the change is more severe - such 
as switching from SQL Server to Oracle (or vice versa), there should be no recompiliation needed. 

## Configuration Overview

The basic premise behind configuring Drapper is the idea that the majority of methods in a repository can be mapped, virtually 1-to-1, with the SQL
statements they are intended to execute. You could think of it conceptually as:

<table>
	<tr>
		<td>Code structure</td>
		<td>Configuration structure</td>
	</tr>
	<tr>
		<td>
		<pre>
Namespace
  --Type
    -- Method
		</pre>
		</td>
		<td>
		<pre>
NamespaceSetting
  --TypeSetting
    -- CommandSetting
		</pre>
		</td>
	</tr>
</table>

### Example

For instance, consider a repository which handles the persistence needs for the `Department` type based on the AdventureWorks database.
Such a repository would likely have methods for persistence and retrieval operations. This example shows a C# repository class with a single 
retrieval method along with the choice of either JSON or XML configuration for this repository. Notice that in this example how 
the Command name matches the method name. 

<table>
<tr>
	<td>Code</td>
	<td>JSON Configuration</td>
	<td>XML Configuration</td>
</tr>
<tr valign='top'>
<td>
   <pre lang="csharp">
namespace AdventureWorks.HumanResources.Repositories
{
    public sealed class CurrencyRepository : ICurrencyRepository
    {
        private readonly IDbCommander _commander;
        public CurrencyRepository(IDbCommander commander)
        {
            _commander = commander;
        }


            public IEnumerable<Currency> RetrieveAll ()
            {
                return _commander.Query<Currency>(typeof(CurrencyRepository));
            }

            public void Dispose()
            {
                _commander.Dispose();
		}
        }
}
</pre>
</td>
<td>
  <pre lang="json">
  {
  "Namespaces": [    
    {
      "Namespace": "AdventureWorks.HumanResources.Repositories",
      "ConnectionString": {
        "ProviderName": "System.Data.SqlClient",
        "ConnectionString": "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=AdventureWorks2014;Integrated Security=true"
      },
      "Types": [
        {
          "Name": "AdventureWorks.HumanResources.Repositories.CurrencyRepository",
          "Commands": {
            "RetrieveAll": {
              "CommandText": "select * from [HumanResources].[Department];",
              "CommandTimeout": 30,
              "CommandType": 1,
              "Flags": 0
            }
          }
        }
      ]
    }
  ]
}
  </pre>
</td>
<td>
  <pre lang="xml">
  &lt;Drapper&gt;
  &lt;namespaces&gt;
    &lt;namespace namespace="AdventureWorks.HumanResources.Repositories"&gt;
      &lt;connectionString providerName="System.Data.SqlClient" 
                        connectionString="Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=AdventureWorks2014;Integrated Security=true;"/&gt;
      &lt;types&gt;
        &lt;type name="AdventureWorks.HumanResources.Repositories.CurrencyRepository"&gt;
          &lt;commands&gt;
            &lt;command name="RetrieveAll"&gt;
              &lt;commandSetting commandText="select * from [HumanResources].[Department];" 
                              commandTimeout="30" 
                              commandType="Text" 
                              flags="None"&gt;
              &lt;/commandSetting&gt;
            &lt;/command&gt;
          &lt;/commands&gt;
        &lt;/type&gt;
      &lt;/types&gt;
    &lt;/namespace&gt;
  &lt;/namespaces&gt;
&lt;/Drapper&gt;
  </pre>
</td>
</tr>
</table>

## Method Overloading

Overloaded methods are a common occurence in .NET code. Drapper supports overloaded methods by offering an additional parameter to 
explicitly name the command setting for the method. Using the same example from above, the method is overloaded to expect a group name
parameter to filter the result set on the database. 

<table>
<tr>
	<td>Code</td>
	<td>JSON Configuration</td>
	<td>XML Configuration</td>
</tr>
<tr valign='top'>
<td>
   <pre lang="csharp">
namespace AdventureWorks.HumanResources.Repositories
{
    public sealed class CurrencyRepository : ICurrencyRepository
    {
        private readonly IDbCommander _commander;
        public CurrencyRepository(IDbCommander commander)
        {
            _commander = commander;
        }


            public IEnumerable<Currency> RetrieveAll ()
            {
                return _commander.Query<Currency>(typeof(CurrencyRepository));
            }

            public IEnumerable<Currency> RetrieveAll (string groupName)
            {
                return _commander.Query<Currency>({ groupName },typeof(CurrencyRepository));
            }

            public void Dispose()
            {
                _commander.Dispose();
		}
        }
}
</pre>
</td>
<td>
  <pre lang="json">
  {
  "Namespaces": [    
    {
      "Namespace": "AdventureWorks.HumanResources.Repositories",
      "ConnectionString": {
        "ProviderName": "System.Data.SqlClient",
        "ConnectionString": "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=AdventureWorks2014;Integrated Security=true"
      },
      "Types": [
        {
          "Name": "AdventureWorks.HumanResources.Repositories.CurrencyRepository",
          "Commands": {
            "RetrieveAll": {
              "CommandText": "select * from [HumanResources].[Department];",
              "CommandTimeout": 30,
              "CommandType": 1,
              "Flags": 0
            },
            "RetrieveAllByGroup": {
              "CommandText": "select * from [HumanResources].[Department] where [GroupName] = @groupName;",
              "CommandTimeout": 30,
              "CommandType": 1,
              "Flags": 0
            }
          }
        }
      ]
    }
  ]
}
  </pre>
</td>
<td>
  <pre lang="xml">
  &lt;Drapper&gt;
  &lt;namespaces&gt;
    &lt;namespace namespace="AdventureWorks.HumanResources.Repositories"&gt;
      &lt;connectionString providerName="System.Data.SqlClient" 
                        connectionString="Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=AdventureWorks2014;Integrated Security=true;"/&gt;
      &lt;types&gt;
        &lt;type name="AdventureWorks.HumanResources.Repositories.CurrencyRepository"&gt;
          &lt;commands&gt;
            &lt;command name="RetrieveAll"&gt;
              &lt;commandSetting commandText="select * from [HumanResources].[Department];" 
                              commandTimeout="30" 
                              commandType="Text" 
                              flags="None"&gt;
              &lt;/commandSetting&gt;
            &lt;/command&gt;
	    &lt;command name="RetrieveAllByGroup"&gt;
              &lt;commandSetting commandText="select * from [HumanResources].[Department] where [GroupName] = @groupName;" 
                              commandTimeout="30" 
                              commandType="Text" 
                              flags="None"&gt;
              &lt;/commandSetting&gt;
            &lt;/command&gt;
          &lt;/commands&gt;
        &lt;/type&gt;
      &lt;/types&gt;
    &lt;/namespace&gt;
  &lt;/namespaces&gt;
&lt;/Drapper&gt;
  </pre>
</td>
</tr>
</table>
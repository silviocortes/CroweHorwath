The current solution is organized in two projects:

HelloWorldAPI
=============
A .NET Core Rest API project, with just one end point: http://localhost:61732/api/Hello

This end point is setup to return a greeting message. The greeting message is obtained from an IGreeting object

The solution makes use of dependecy injection. When the application is loaded (startup), a dependecy to IGreeting is added, and a default
instance is set to HelloGreeting.


Note: this solution also contains some basic xUnit testing.

HelloWorldConsole
=================
A .NET Core Console project that currently retrieves a greeting from a URI (defined in the appsettings.json file), and displays it to the console.

The solution makes use of dependency injection, adding a dependency to IWriter. 

By default, a reference is set to ConsoleWriter, that writes a greeting to the console. This behavior can be changed by injecting a different class, 
as long as it implements IWriter (Example: DBWriter mockup class)

The concrete type to be created during run time is define in the appsettings.json file, usingv the "WriterType" key.

using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using DependenctInjectedCommandLineApplication.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection();

services.AddLogging(x => x.AddConsole()) ;
services.AddSingleton<Command, HelloWorldCommand>();

var serviceProvider = services.BuildServiceProvider();
var rootCommand = new RootCommand();
foreach (Command command in serviceProvider.GetServices<Command>())
    rootCommand.AddCommand(command);

var commandLineBuilder = new CommandLineBuilder(rootCommand);
var parser = commandLineBuilder.UseDefaults().Build();

return parser.Invoke(args);
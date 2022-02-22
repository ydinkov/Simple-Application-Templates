using Microsoft.Extensions.Logging;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;


namespace DependenctInjectedCommandLineApplication.Commands
{
    public class HelloWorldCommand : Command
    {
        private readonly ILogger logger;

        public HelloWorldCommand(ILogger<HelloWorldCommand> logger) 
            : base(name: "hello", description: "Greets the user")
        {
            this.logger = logger;

            AddOption(new Option<string>(new[] { "--name", "-n" }, getDefaultValue: () => "Mr. User")
            {
                Description = "The user's name. Used to personalise message",
                IsRequired = false
            });


            Handler =  CommandHandler.Create<string>((string name) => 
            {
             
                this.logger.LogInformation($"Hello {name}!");
            });
        }       
    }
}

using Common;
using NetworkMediatorPattern.Interfaces;
using NetworkMediatorPattern.Services;

namespace NetworkMediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISwitch sSwitch = new Switch();
            ILogger consoleLogger = new ConsoleLogger();

            IComputer computerX = new Computer.Computer("X", consoleLogger, sSwitch);
            IComputer computerY = new Computer.Computer("Y", consoleLogger, sSwitch);
            IComputer computerZ = new Computer.Computer("Z", consoleLogger, sSwitch);

            computerZ.SendingMessage("X", "Hej");
            computerY.BroadCastMessage("Hej");
        }
    }
}

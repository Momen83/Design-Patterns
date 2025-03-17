
using Design_Patterns.Singleton;

Logger logger1, logger2;

Task.Run(() => logger1 = Logger.getInstance());
Task.Run(() => logger1 = Logger.getInstance());



string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory , "logger.txt");
Console.WriteLine(filePath);
Logger.InfoMessage("Hello in Logger sytem\n", filePath);
Logger.WarningMessage("Don't Touch Anything\n", filePath);
Logger.ErrorMessage("Logger system terminated\n", filePath);


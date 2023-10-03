using Microsoft.Win32;

object? type = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Dojo", "Type", "Unknown");

Console.WriteLine($"Welcome to the {type} ConsoleApp1");
Console.ReadKey();

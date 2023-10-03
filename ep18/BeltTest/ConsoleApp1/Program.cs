using Microsoft.Win32;

object? edition = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\BeltTest", "Edition", null);
object? customer = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\BeltTest", "Customer", null);

Console.WriteLine($"Welcome to the {edition} ConsoleApp1.");
Console.WriteLine($"  Registered our {customer} customer.");

Console.ReadKey();
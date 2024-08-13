// See https://aka.ms/new-console-template for more information

// Prior to C# 13
Console.WriteLine("\u001b[1mThis is a bold text\u001b[0m");

// With C# 13
Console.WriteLine("\e[1mThis is a bold text\e[0m");

Console.ReadLine();
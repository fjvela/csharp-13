// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Todo GetTodo() => new(Id: 0, Name: "Name");
var f = GetTodo; // the type of f is Func<ToDo>

internal class Todo(int Id, string Name)
{
    public int Id;
    public string Name;
}

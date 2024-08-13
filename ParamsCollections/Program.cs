// See https://aka.ms/new-console-template for more information

var persons = new List<Person>
{
   new Person("Mads", "Torgersen"),
   new Person("Dustin", "Campbell"),
   new Person("Kathleen", "Dollard")
};

// C# 13 before
//static void WriteNames(params string[] names)
//  => Console.WriteLine(String.Join(", ", names));

//WriteNames(persons.Select(person => person.FirstName).ToArray());

// C# 13
static void WriteNames(params IEnumerable<string> names)
  => Console.WriteLine(String.Join(", ", names));

WriteNames(persons.Select(person => person.FirstName));
WriteNames(from p in persons select p.FirstName);


internal class Person( string Name, string FirstName)
{
    public string Name { get; set; }
    public string FirstName { get; set; }
}

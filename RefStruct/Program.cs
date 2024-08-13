// See https://aka.ms/new-console-template for more information

T Identity<T>(T p)
    where T : allows ref struct
    => p;


var local = Identity(new User());


Console.ReadLine();

ref struct User
{

}

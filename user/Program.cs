// See https://aka.ms/new-console-template for more information
String? username = null;
while (username == null)
{
    Console.WriteLine("Username: ");
    username = Console.ReadLine();
}
String? password = null;
while (password == null)
{
    Console.WriteLine("Password: ");
    password = Console.ReadLine();
}
User user = new(username, password);
Console.WriteLine(user);

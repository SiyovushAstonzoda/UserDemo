using Domain.Models;
using Infrastructure.Services;

var userList = new List<User>();
Console.Write("How many users do you want to add? ");
var userSize = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < userSize; i++)
{
    Console.WriteLine($"{Environment.NewLine}User #{i+1}{Environment.NewLine}");
    var user = new User();

    Console.Write("Enter your fuckin FirstName: ");
    user.FirstName = Console.ReadLine();

    Console.Write("Enter your fuckin LastName: ");
    user.LastName = Console.ReadLine();

    Console.Write("Enter your fuckin UserName: ");
    user.UserName = Console.ReadLine();
    if (user.UserName.Length < 4) 
    {
        Console.WriteLine("Username Should be More Than 4 Characters!");
        Environment.Exit(0);
    }
   
    Console.Write("Enter your fuckin Password: ");
    user.Password = Console.ReadLine();
    if (user.UserName.Length < 4)
    {
        Console.WriteLine("Password Should be More Than 4 Characters!");
        Environment.Exit(0);
    }

    userList.Add(user);
}

Console.WriteLine($"{Environment.NewLine}List of users: ");
foreach (var user in userList)
{
    int i = 0;
    ++i;
    Console.WriteLine($"User #{i}");
    var userService = new UserService(user);
    userService.GetInfo();

    Console.Write($"{Environment.NewLine}{user.FirstName}, please enter your Username: ");
    var username = Console.ReadLine();

    Console.Write($"{user.FirstName}, please enter your Password: ");
    var password = Console.ReadLine();

    userService.Login(username, password);
}
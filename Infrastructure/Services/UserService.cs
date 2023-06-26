namespace Infrastructure.Services;
using Domain.Models;
public class UserService
{
    User _user = new User();
    public UserService(User user)
    {
        _user = user;
    }

    public void GetInfo()
    {
        Console.WriteLine($"FirstName = {_user.FirstName}{Environment.NewLine}LastName = {_user.LastName}{Environment.NewLine}UserName = {_user.UserName}{Environment.NewLine}Password = {_user.Password}");
    }

    public void Login(string username, string password)
    {
        if (_user.UserName == username && _user.Password == password)
        {
            Console.WriteLine($"Welcome mr {_user.FirstName} {_user.LastName}{Environment.NewLine}You have been logged successfully!");
        }
        else
        {
            Console.WriteLine($"Dear {_user.FirstName} {_user.LastName} login failed");
        }
    }
}
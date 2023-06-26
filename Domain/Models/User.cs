namespace Domain.Models;
public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public string? UserName { get; set; }
    public string? Password { get; set; }

    public User()
    {
        
    }

    public User(string? firstname, string? lastname, string? username, string? password)
    {
        FirstName = firstname;
        LastName = lastname;
        UserName = username;
        Password = password;
    }
}

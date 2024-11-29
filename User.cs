
namespace AssignmenObjectConstructors;

public class User
{
    private static Account? UserAccount { get; set; }
    public string Username { get; private set; }
    private string Password { get; set; }


    public User(string username, string password)
    {
        UserAccount = new Account();
        Username = username;
        Password = password;
    }

    private static readonly Dictionary<string, string> users = new()
    {
        { "Liam", "Password" },
        { "Sam", "Password" }
    };

    public static void CreateAccount(string username, string password)
    {
        if (!UserEntryCheck(username, password))
        {
            users.Add(username, password);
            Console.WriteLine($"New user created username: {username} password: {users[username]}");

        }
        else Console.WriteLine("Invalid username or password.");
    }

    public static void SignIn(string username, string password)
    {
        if (users.TryGetValue(username, out string? storedPassword))
        {
            if (storedPassword == password)
                Console.WriteLine("You are now logged in");
            else
                Console.WriteLine("Invalid Password");
        }
        else
            Console.WriteLine("Invalid Username");
    }

    private static bool UserEntryCheck(string username, string password)
    {
        if (username.Length < 5 || password.Length < 5)
        {
            Console.WriteLine("Username and password needs to be atlest 5 characters.");
            return false;
        }
        else if (users.ContainsKey(username))
        {
            Console.WriteLine("That username is taken.");
            return false;
        }
        else return true;
    }
}




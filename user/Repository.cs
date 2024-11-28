
public class UsernameException : ArgumentException { }
public class PasswordExpection : ArgumentException { }
public class User
{
    public String Username { get; set; }
    public String Password { get; set; }

    public User(String username, String password)
    {
        if (username.Length < 3)
        {
            throw new UsernameException();
        }
        if (password.Length < 3)
        {
            throw new PasswordExpection();
        }
        Username = username;
        Password = password;
    }

}

using System.Collections.Generic;

public class UserManager
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void RemoveUser(User user)
    {
        users.Remove(user);
    }

    public void UpdateUser(User user, string name, string email, string role)
    {
        user.Name = name;
        user.Email = email;
        user.Role = role;
    }
}

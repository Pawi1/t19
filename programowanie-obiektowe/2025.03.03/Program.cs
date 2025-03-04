using System.Security.Cryptography;
using System.Text;

internal class Program
{
    public enum Role
    {
        Administrator,
        User,
        Manager,
    }

    public class User
    {
        public string username { get; set; }
        public List<Role> roles { get; set; }

        public User(string username)
        {
            username = this.username;
            roles = [];
        }

        public void AddRole(Role role)
        {
            if (!roles.Contains(role))
            {
                roles.Add(role);
            }
        }

    }

    public class RBAC
    {
        private readonly Dictionary<Role, List<string>> _rolePermissions;

        public RBAC()
        {
            _rolePermissions = new Dictionary<Role, List<string>>
            {
                { Role.Administrator, ["Read", "Write", "Delete" ] },
                { Role.Manager, ["Read", "Write" ] },
                { Role.User, [ "Read" ] },
            };
        }

        public bool HasPermission(User user, string permission)
        {
            foreach (var role in user.roles)
            {
                if (_rolePermissions.ContainsKey(role) && _rolePermissions[role].Contains(permission))
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class PasswordManager
    {
        private const string _passwordPath = "user_password.txt";
        public static event Action<string, bool> PasswordVerified;

        static PasswordManager()
        {
            if (!File.Exists(_passwordPath))
            {
                File.Create(_passwordPath).Dispose();
            }
        }

        public static void SavePassword(string username, string password)
        {
            if (File.ReadLines(_passwordPath).Any(line => line.Split(',')[0] == username))
                Console.Error.WriteLine("Password already exists");
            string hashedPassword = HashPassword(password);
            File.AppendAllText(_passwordPath, username+','+hashedPassword + Environment.NewLine);
            Console.WriteLine($"User {username} has been saved.");

        }

        private static string HashPassword(string password)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public static bool VerifyPassword(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            foreach (var line in File.ReadAllLines(_passwordPath))
            {
                var parts = line.Split(',');
                if (parts[0] != username || parts[1] != hashedPassword) continue;
                PasswordVerified?.Invoke(username, true);
                return true;
            }
            PasswordVerified?.Invoke(username, false);
            return false;
        }
    }

    static void Main()
    {
        PasswordManager.PasswordVerified += (username,success) => Console.WriteLine($"Loging as {username}: {(success ? "passed":"failed")} ");
        PasswordManager.SavePassword("addmin","pass");

    }
}
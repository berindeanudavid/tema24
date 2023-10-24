namespace tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string username = "dutu";
            const string password = "parola";
            bool ok = false;
            while (ok == false)
            {
                string u, p;
                Console.Write("username: ");
                u = Console.ReadLine();
                Console.Write("password: ");
                p = Console.ReadLine();
                if ((string.Compare(u, username) == 0) && (string.Compare(p, password) == 0))
                {
                    ok = true;
                    Console.WriteLine("Bine ai venit, " + username);
                }
                else
                {
                    Console.WriteLine("wrong username or password");
                }
            }
        }
    }
}
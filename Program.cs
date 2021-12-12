using UsersConsoleApp;

List<User> users = new List<User>();

void GetFourUsers()
{

    for (int i = 0; i < 4; i++)
    {
        User userToAdd = new User();

        Console.WriteLine("Enter first name");
        userToAdd.FirstName = Console.ReadLine();

        Console.WriteLine("Enter last name");
        userToAdd.LastName = Console.ReadLine();

        Console.WriteLine("Enter birth year");
        userToAdd.BirthYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter email");
        userToAdd.Email = Console.ReadLine();

        users.Add(userToAdd);

    }

    foreach (User item in users)
    {
        item.PrintUserInfo();
    }

    users.Sort();

    foreach (User item in users)
    {
        item.PrintUserInfo();
    }

}

GetFourUsers();
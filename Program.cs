using UsersConsoleApp;

List<User> usersList = new List<User>();



//void GetFourUsers()
//{

//    for (int i = 0; i < 4; i++)
//    {
//        User userToAdd = new User();

//        Console.WriteLine("Enter first name");
//        userToAdd.FirstName = Console.ReadLine();

//        Console.WriteLine("Enter last name");
//        userToAdd.LastName = Console.ReadLine();

//        Console.WriteLine("Enter birth year");
//        userToAdd.BirthYear = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter email");
//        userToAdd.Email = Console.ReadLine();

//        usersList.Add(userToAdd);

//    }

//    usersList.Sort();

//    foreach (User item in usersList)
//    {
//        item.PrintUserInfo();
//    }

//    SaveUsersToFile(usersList);
//    SaveEachUser(usersList);
//}
//GetFourUsers();



//void SaveUsersToFile(List<User> list)
//{
//    FileStream saveUsersFs = new FileStream(@"C:\STREAM\USERS\AllUsers.txt", FileMode.Append);
//    using (StreamWriter writer = new StreamWriter(saveUsersFs))
//    {
//        foreach (User item in list)
//        {
//            writer.WriteLine($"Name: {item.FirstName} {item.LastName} | Birth Year: {item.BirthYear} | Email: {item.Email}");
//        }
//    }
//}

//void SaveEachUser(List<User> list)
//{
//    foreach (User item in list)
//    {
//        FileStream saveUserFs = new FileStream($@"C:\STREAM\USERS\{item.FirstName} {item.LastName}.txt", FileMode.Append);
//        using (StreamWriter writer = new StreamWriter(saveUserFs))
//        {
//            writer.WriteLine($"Name: {item.FirstName} {item.LastName} | Birth Year: {item.BirthYear} | Email: {item.Email}");
//        }
//    }
//}






//void PrintUsersFromFile()
//{
//    FileStream PrintUsersFs = new FileStream(@"C:\STREAM\USERS\AllUsers.txt", FileMode.Open);
//    using (StreamReader reader = new StreamReader(PrintUsersFs))
//    {
//        Console.WriteLine(reader.ReadToEnd());
//    }
//}
//PrintUsersFromFile();






void UsersMenu()
{
    try
    {
        Console.WriteLine("To add a user enter - 1");
        Console.WriteLine("To edit a user enter - 2");
        Console.WriteLine("To delete a user enter - 3");
        Console.WriteLine("To display a user enter - 4");

        int userPick = int.Parse(Console.ReadLine());

        switch (userPick)
        {
            case 1:
                AddUser();
                UsersMenu();
                break;


            case 2:
                EditUser();
                UsersMenu();
                break;


            case 3:
                DeleteUserByName();
                UsersMenu();
                break;


            case 4:
                PrintUserByName();
                UsersMenu();
                break;


            default:

                break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
UsersMenu();



//*******__1
void AddUser()
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

    usersList.Add(userToAdd);
    SaveUserToFile(userToAdd);
    saveToAllUsers(userToAdd);
}


void SaveUserToFile(User user)
{
    FileStream saveUserFs = new FileStream($@"C:\STREAM\USERS\{user.FirstName} {user.LastName}.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(saveUserFs))
    {
        writer.WriteLine($"Name: {user.FirstName} {user.LastName} | Birth Year: {user.BirthYear} | Email: {user.Email}");
    }
}


void saveToAllUsers(User user)
{
    FileStream saveAllUserFs = new FileStream(@"C:\STREAM\USERS\AllUsers.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(saveAllUserFs))
    {
        writer.WriteLine($"Name: {user.FirstName} {user.LastName} | Birth Year: {user.BirthYear} | Email: {user.Email}");
    }
}




//*******__2
void EditUser()
{
    Console.WriteLine("Enter full name");
    string fileName = Console.ReadLine();

    Console.WriteLine("Please Enter new information");
    Console.WriteLine();

    User userToEdit = new User();

    Console.WriteLine("Enter first name");
    userToEdit.FirstName = Console.ReadLine();

    Console.WriteLine("Enter last name");
    userToEdit.LastName = Console.ReadLine();

    Console.WriteLine("Enter birth year");
    userToEdit.BirthYear = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter email");
    userToEdit.Email = Console.ReadLine();


    FileStream PrintUserFs = new FileStream($@"C:\STREAM\USERS\{fileName}.txt", FileMode.Create);
    using (StreamWriter writer = new StreamWriter(PrintUserFs))
    {
        writer.WriteLine($"Name: {userToEdit.FirstName} {userToEdit.LastName} | Birth Year: {userToEdit.BirthYear} | Email: {userToEdit.Email}");
    }

}




//*******__3
void DeleteUserByName()
{
    Console.WriteLine("Enter full name");
    string fileName = Console.ReadLine();

    FileStream PrintUserFs = new FileStream($@"C:\STREAM\USERS\{fileName}.txt", FileMode.Create);
    PrintUserFs.Close();
    File.Delete($@"C:\STREAM\USERS\{fileName}.txt");
}





//*******__4
void PrintUserByName()
{
    Console.WriteLine("Enter full name");
    string fileName = Console.ReadLine();

    FileStream PrintUserFs = new FileStream($@"C:\STREAM\USERS\{fileName}.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(PrintUserFs))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}






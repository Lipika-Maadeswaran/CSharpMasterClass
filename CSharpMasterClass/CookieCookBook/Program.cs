using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CookieCookBook
{
    internal class Program
    {
        public async static Task Main(string[] args)
        {
            bool isExitRequested = false;
            User user = null!;

            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create);

            Menu menu = new Menu();
            LoaderAnimation animation = new LoaderAnimation();
            IFileOperation fileOperation = new FileOperation(fileLocation);
            UserOperation userOperation = new UserOperation(user, fileOperation);
            UserAuthentication userAuthentication = new UserAuthentication(user, fileOperation, animation, userOperation);

            Console.WriteLine("Welcome to CookBook!");

            while (!isExitRequested)
            {
                StringBuilder menuOptions = new StringBuilder
                    (
                    "Choose one operation" +
                    "\n1. SignUp " +
                    "\n2. LogIn " +
                    "\n3. LogOut " +
                    "\n4. Exit"
                    );

                Console.WriteLine(menuOptions);

                Enum.TryParse(Console.ReadLine(), out MainMenu option);

                switch (option)
                {
                    case MainMenu.SignUp:
                        Console.WriteLine("SignUp");
                        var signUpUserName = Parser.Validate<string>(Constants.regexForAlphabet, "Enter UserName :");
                        var signUpPassword = Parser.Validate<string>(Constants.regexForAlphabet, "Enter Password : \n (Password must be in alphabets)");
                        User userSignUp = new User(signUpUserName, signUpPassword);
                        if (fileOperation.CheckUserNameUnique(signUpUserName))
                        {
                            await userAuthentication.SignUp(userSignUp);
                           // userOperation.ActiveUser = userSignUp;
                        }
                        if (userOperation.ActiveUser!.UserName == signUpUserName)
                        {
                            menu.UserMenu(userSignUp, fileOperation);
                        }
                        break;
                    case MainMenu.LogIn:
                        var logInUserName = Parser.Validate<string>(Constants.regexForAlphabet, "Enter UserName :");
                        var logInPassword = Parser.Validate<string>(Constants.regexForAlphabet, "Enter Password : ");
                        User logInUser = new User(logInUserName, logInPassword);

                        await userAuthentication.LogIn(logInUserName, logInPassword, logInUser);
                        if (userOperation.ActiveUser == null)
                        {
                            break;
                        }
                        else if (userOperation.ActiveUser.UserName == logInUserName)
                        {
                          //  userOperation.ActiveUser = logInUser;
                            menu.UserMenu(logInUser, fileOperation);
                        }
                        break;
                    case MainMenu.LogOut:
                        if(user != null)
                        {
                            Console.WriteLine("Logging Out...");
                            await userAuthentication.LogOut();
                            fileOperation.WriteDetailsToFile(user);
                            //userOperation.ActiveUser = null;
                        }
                        else
                        {
                            Console.WriteLine("SignUp or LogIn !");
                        }
                        break;
                    case MainMenu.Exit:
                        isExitRequested = true;
                        Console.WriteLine("Thank you for using our application!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break ;
                }
            }
        }
    }
}
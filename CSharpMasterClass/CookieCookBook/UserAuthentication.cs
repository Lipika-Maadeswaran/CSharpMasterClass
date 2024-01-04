using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class UserAuthentication
    {
        User user;
        IFileOperation fileOperation;
        LoaderAnimation animation;
        UserOperation userOperation;
        public UserAuthentication(User user, IFileOperation fileOperation, LoaderAnimation animation, UserOperation userOperation)
        {
            this.user = user;
            this.fileOperation = fileOperation;
            this.animation = animation;
            this.userOperation = userOperation;
        }

        public async Task LogIn(string userName, string password, User user)
        {
            bool isAuthenticated = fileOperation.ValidateLogIn(userName, password, user);

            if (!isAuthenticated)
            {
                Console.WriteLine("No User found ! \nTry Signing In or Try again! :)");
            }
            else
            {
                Console.WriteLine("Loggin In...");

                int i = 1;
                await Task.Run(() =>
                {
                    while (i <= 30000)
                    {
                        animation.UpdateProgress();
                        i++;
                    }
                }
                );

                this.userOperation.ActiveUser = user;
                this.userOperation.ActiveUser.UserName = userName;
                Console.WriteLine($"Successfully Logged in! Welcome {user.UserName}");

                Thread.Sleep(1000);
            }

        }

        public async Task LogOut()
        {
            if (userOperation.ActiveUser != null)
            {
                int i = 1;
                await Task.Run(() =>
                {
                    while (i <= 30000)
                    {
                        animation.UpdateProgress();
                        i++;
                    }
                });

                Console.WriteLine($"Successfully Logged out! Thankyou {userOperation.ActiveUser.UserName}");
                userOperation.ActiveUser = null!;
            }
            else
            {
                Console.WriteLine("No User found!");
            }

            Thread.Sleep(1000);

        }
        public async Task SignUp(User user)
        {
            bool isSignedUp = fileOperation.SignUpUser(user);

            if (!isSignedUp)
            {
                Console.WriteLine("User Already Exists :)");
            }
            else
            {
                int i = 1;
                await Task.Run(() =>
                {
                    while (i <= 3)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                        i++;
                    }
                }
                );

                userOperation.ActiveUser = user;
                userOperation.ActiveUser.UserName = user.UserName;
                Console.WriteLine($"\nSuccessfully Signed Up! Welcome {user.UserName}");
            }
            Thread.Sleep(1500);

        }
    }
}

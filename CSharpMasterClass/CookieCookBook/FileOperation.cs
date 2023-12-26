using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class FileOperation : IFileOperation
    {
        private readonly string _path;

        public FileOperation(string filePath)
        {
            _path = filePath;
        }
        public string CreateFileName(User user)
        {
            string userDetailsFile = $"{user.UserName}.json";
            return userDetailsFile;
        }

        public bool ValidateLogIn(string userName, string password, User user)
        {
            var userFile = CreateFileName(user);
            if (!File.Exists(Path.Combine(_path, userFile)))
            {
                return false;
            }
            else
            {
                string fileContent = File.ReadAllText(Path.Combine(_path, userFile));
                var logInUserDetails = JsonConvert.DeserializeObject<User>(fileContent);

                user = logInUserDetails!;
                Password logInPassword = new Password(password);

                if (user.UserName == userName && user.Password.EncodedPassword == logInPassword.EncodedPassword)
                {
                    return true;
                }

                return false;
            }
        }

        public bool CheckUserNameUnique(string userName)
        {
            if (!File.Exists(Path.Combine(_path, $"{userName}.json")))
            {
                return true;
            }
            return false;
        }

        public bool SignUpUser(User user)
        {
            var userFileName = CreateFileName(user);

            if (File.Exists(Path.Combine(_path, userFileName)))
            {
                Console.WriteLine("User already exists! Please ValidateLogIn");
                return false;
            }
            else
            {
                using FileStream fileStream = File.Create(Path.Combine(_path, userFileName));
                using StreamWriter streamWriter = new StreamWriter(fileStream);
                var content = JsonConvert.SerializeObject(user);
                streamWriter.Write(content);
                return true;
            }
        }

        public void WriteDetailsToFile(User user)
        {
            var userFileName = CreateFileName(user);
            using FileStream fileStream = File.Open(Path.Combine(_path, userFileName), FileMode.Open);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            var content = JsonConvert.SerializeObject(user);
            streamWriter.Write(content);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegUsingAnnotationsReflections
{
    class UserInfoValidation
    {
        public static void Display()
        {
            UserInfo user1 = new UserInfo();
            user1.FirstName = "Ari";
            user1.LastName = "Prasath";
            user1.Email = "ariprasath3@gmail.com";
            user1.PhoneNumber = "91 9442556613";
            user1.Password = "askd8wfjnDj";

            ValidationContext context = new ValidationContext(user1, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool Valid = Validator.TryValidateObject(user1, context, results, true);
            if (!Valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("First Name {0}", user1.FirstName);
                Console.WriteLine("Last Name {0}" ,user1.LastName);
                Console.WriteLine("Email {0}" ,user1.Email);
                Console.WriteLine("Phone number {0}" ,user1.PhoneNumber);
                Console.WriteLine("Password {0}" ,user1.Password);
            }
        }
    }
}

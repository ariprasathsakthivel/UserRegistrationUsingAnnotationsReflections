using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace UserRegUsingAnnotationsReflections
{
    class UserInfoReflection
    {
        public static void MetdaData()
        {
            Type type = Type.GetType("UserRegUsingAnnotationsReflections.UserInfo");
            Console.WriteLine("Full name {0}", type.FullName);
            Console.WriteLine("Class name {0}", type.Name);
            Console.WriteLine("Properties in UserInfo");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "-->" + property.Name);
            }
            Console.WriteLine("Methods in UserInfo");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "-->" + method.Name);
            }
        }
    }
}

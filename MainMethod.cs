using System;

namespace UserRegUsingAnnotationsReflections
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            UserInfoValidation.Display();
            Console.WriteLine("===========================================");
            UserInfoReflection.MetdaData();
        }
    }
}

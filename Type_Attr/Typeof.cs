using System;
using System.Reflection;

namespace Type_Attr 
{
    class User 
    {
      [AttributeName(thamsokhoitao)] 
      public string Name {set;get;}
      public int Age {set;get;}
      public string PhoneNumber {set;get;}

      public string Email {set;get;}

    }
    public class testTypeof
    {
        public static void Test()
        {
        User user = new User() 
        {
          Name = "HieuLT", 
          Age = 20 , 
          PhoneNumber = "213213213", 
          Email = "Hieucute@gmail.com"  
        };
        var properties = user.GetType().GetProperties();
        foreach (PropertyInfo property in properties)
        {
            string name = property.Name;
            var value = property.GetValue(user);
            Console.WriteLine($"{name}:{value}");
        }
        }
    }
}
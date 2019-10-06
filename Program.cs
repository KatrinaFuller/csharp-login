using System;
using System.Collections.Generic;
using csharp_dictionary.Models;

namespace csharp_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Clear();
      Dictionary<string, User> users = new Dictionary<string, User>();
      User jake = new User("Jake", "IHeartCod3");
      User mark = new User("Mark", "MarkR0ck5");

      users.Add(jake.Name, jake);
      users.Add(mark.Name, mark);

      Console.WriteLine("Username: ");
      string username = Console.ReadLine();
      Console.Write("Password: ");
      string password = Console.ReadLine();

      if (users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
        System.Console.WriteLine("You are logged in");
      }
      else
      {
        System.Console.WriteLine("Invalid Credentials");
      }

    }
  }
}

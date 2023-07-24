// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;


//jperez@serempre.com
using (WebClient client = new WebClient()) 
{
    string json = client.DownloadString("https://raw.githubusercontent.com/Serempre/test-json/main/list1.json");
    
    IEnumerable<User> Users = JsonConvert.DeserializeObject<IEnumerable<User>>(json);
    var sortedUsers = new List<User>();
    sortedUsers.AddRange(Users.OrderBy(u => u.Kpi.Speed));
    foreach (var user in sortedUsers) 
    {
        if (!user.Equals(sortedUsers.Last()))
        {
            Console.WriteLine(user.ToString() + ",\n");
        }
        else 
        {
            Console.WriteLine(user.ToString());
        }
    }
}
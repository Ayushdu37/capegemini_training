using System;
using System.IO;
class Program
{
    public static void Main()
    {
        // string path ="data.txt";
        // File.WriteAllText(path,"File I/O Example in c#");

        // Console.WriteLine("Data written to file");

        // string content = File.ReadAllText("data.txt");
        // Console.WriteLine("File Content: ");
        // Console.WriteLine(content);

        using(StreamWriter writer = new StreamWriter("log.txt"))
        {
            writer.WriteLine("Application Started.");
            writer.WriteLine("Processing Data.");
            writer.WriteLine("Application Ended.");
        }

        using(StreamReader reader = new StreamReader("log.txt"))
        {
            string line;
            while((line = reader.ReadLine()) != null) // null-check
            {
                Console.WriteLine(line);
            }
        }

        User user = new User();
        user.Id = 1;
        user.Name = "Alice";

        User user1 = new User();
        user1.Id = 2;
        user1.Name = "Bob";

        using(StreamWriter userwriter = new StreamWriter("UserDetails.txt"))
        {
            userwriter.WriteLine(user.Id);
            userwriter.WriteLine(user.Name);
            userwriter.WriteLine(user1.Id);
            userwriter.WriteLine(user1.Name);
        }
        Console.WriteLine("User Data Saved.");

        using(StreamReader reader = new StreamReader("UserDetails.txt"))
        {
            // user.Id = int.Parse(reader.ReadLine());
            // user.Name = reader.ReadLine();
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

        using(BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
        {
            writer.Write(user.Id);
            writer.Write(user.Name);
        }
        Console.WriteLine("Binary user data saved.");

        using(BinaryReader reader = new BinaryReader(File.Open("user.bin", FileMode.Open)))
        {
            Console.WriteLine(reader.ReadInt32);
            Console.WriteLine(reader.ReadString());
        }
    }
}

public class User
{
    public int Id;
    public string Name;
}
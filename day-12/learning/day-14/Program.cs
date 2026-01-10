using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
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

        // using(StreamWriter writer = new StreamWriter("log.txt"))
        // {
        //     writer.WriteLine("Application Started.");
        //     writer.WriteLine("Processing Data.");
        //     writer.WriteLine("Application Ended.");
        // }

        // using(StreamReader reader = new StreamReader("log.txt"))
        // {
        //     string line;
        //     while((line = reader.ReadLine()) != null) // null-check
        //     {
        //         Console.WriteLine(line);
        //     }
        // }

        // User user = new User();
        // user.Id = 1;
        // user.Name = "Alice";

        // User user1 = new User();
        // user1.Id = 2;
        // user1.Name = "Bob";

        // using(StreamWriter userwriter = new StreamWriter("UserDetails.txt"))
        // {
        //     userwriter.WriteLine(user.Id);
        //     userwriter.WriteLine(user.Name);
        //     userwriter.WriteLine(user1.Id);
        //     userwriter.WriteLine(user1.Name);
        // }
        // Console.WriteLine("User Data Saved.");

        // using(StreamReader reader = new StreamReader("UserDetails.txt"))
        // {
        //     // user.Id = int.Parse(reader.ReadLine());
        //     // user.Name = reader.ReadLine();
        //     string line;
        //     while((line = reader.ReadLine()) != null)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }
        // // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

        // using(BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
        // {
        //     writer.Write(user.Id);
        //     writer.Write(user.Name);
        // }
        // Console.WriteLine("Binary user data saved.");

        // using(BinaryReader reader = new BinaryReader(File.Open("user.bin", FileMode.Open)))
        // {
        //     Console.WriteLine(reader.ReadInt32);
        //     Console.WriteLine(reader.ReadString());
        // }

        // FileInfo file = new FileInfo("sample.txt");
        // if (!file.Exists)
        // {
        //     using(StreamWriter writer = file.CreateText())
        //     {
        //         writer.WriteLine("Hello FileInfo Class");
        //     }
        // }
        // Console.WriteLine("File Name: " + file.Name);
        // Console.WriteLine("File Size: " + file.Length + " bytes");
        // Console.WriteLine("Created On: " + file.CreationTime);

        // Directory.CreateDirectory("Logs");
        // if (Directory.Exists("Logs"))
        // {
        //     Console.WriteLine("Logs directory created successfully.");
        // }

        // DirectoryInfo dir = new DirectoryInfo("Logs");
        // if (!dir.Exists)
        // {
        //     dir.Create();
        // }
        // Console.WriteLine("Directory Name: " + dir.Name);
        // Console.WriteLine("Created On: " + dir.CreationTime);
        // Console.WriteLine("Full Path: " + dir.FullName);

        // User user = new User();
        // user.Id = 1;
        // user.Name = "Alice";

        // string json = JsonSerializer.Serialize(user);
        // File.WriteAllText("user.json", json);
        // Console.WriteLine("User serialized successfully.");

        // string json = File.ReadAllText("user.json");
        // User user = JsonSerializer.Deserialize<User>(json);
        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

        User user = new User();
        user.Id = 1;
        user.Name = "Alice";

        XmlSerializer serializer = new XmlSerializer(typeof(User));
        using(FileStream fs = new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }
        Console.WriteLine("XML Serialized");
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
// using System.Text;

// public class Cleanser
// {
//     public static string CleanseAndInvert(string input)
//     {
//         if(input.Length < 6)
//         {
//             Console.WriteLine("Invalid Input");
//         }

//         if (string.IsNullOrEmpty(input))
//         {
//             Console.WriteLine("Invalid Input");
//         }

//         input = input.ToLower();

//         string temp = "";

//         foreach(char ch in input)
//         {
//             int asci = (int)ch;
//             if(asci % 2 != 0)
//             {
//                 temp = temp + ch;
//             }
//         }

//         string reverse = "";
//         for(int i = temp.Length - 1; i>=0; i--)
//         {
//             reverse = reverse + temp[i];
//         }

//         char[] result = reverse.ToCharArray();
//         for(int i = 0; i < result.Length; i++)
//         {
//             if(i % 2 == 0)
//             {
//                 result[i] = char.ToUpper(result[i]);
//             }
//         }
//         return new string(result);



        
//     }
// }




// string input = "Magic";
// string password = Cleanser.CleanseAndInvert(input);
// Console.WriteLine(password);
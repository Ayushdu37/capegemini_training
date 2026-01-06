using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
// string sentence="abc123";
// string pattern=@"\d";

// string sentence="123_123";
// string pattern=@"\d";


// string sentence="amount_5000";
// string pattern=@"\d+";
// string pattern=@"\d*";//null

// string sentence="10 20 40";
// string pattern=@"\d+";

// string sentence="10A20B40C";
// string pattern=@"\D";

// string sentence="10A20B40C!@_abc _0!\t!";
// string pattern=@"\w";//woard character
// string pattern=@"\W";//non-woard character
// string pattern=@"\s";// whitespace
// string pattern=@"\S";// non whitespace

// string sentence="?10A20B40C!@_abc _0!\t!C:\abc\file.txt?";
string sentence = "C:\abc\file.txt?";
string pattern=@"\.txt";
// string pattern =@"\\";
// string pattern=@"\?";


//bool result = Regex.IsMatch(sentence, pattern);
//Match m = Regex.Match(sentence, pattern);
//Console.WriteLine(m.Value);

//MatchCollection matches = Regex.Matches(sentence, pattern);
//Console.WriteLine("Matches:");
//foreach (var it in matches)
//    Console.WriteLine(it);

//Console.WriteLine(result);

string pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})"
string input = "2004-11-21";
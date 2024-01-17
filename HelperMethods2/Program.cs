string value = "abc123";
char [] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string [] items = result.Split(",");
foreach(string item in items) {
    Console.WriteLine(item);
}

string pangram = "The quick brown fox jumps over the lazy dog";
char [] panArray = pangram.ToCharArray();
Array.Reverse(panArray);
string pangramreverse = new string(panArray);
Console.WriteLine(pangramreverse);

string pangram2 = "The quick brown fox jumps over the lazy dog";
// Step 1
string[] message = pangram2.Split(' ');
//Step 2
string[] newMessage = new string[message.Length];
// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}
//Step 4
string prev = String.Join(" ", newMessage);
Console.WriteLine(prev);

Console.WriteLine(" ");

//Challenge
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string [] OrderID = orderStream.Split(",");

foreach(string item in OrderID) {
    if (item.Length == 4){
        Console.WriteLine(item);
    } else {
        Console.WriteLine(item + "  - Error");
    }
}
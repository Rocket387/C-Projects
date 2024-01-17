Write code that processes the contents of a string array
Here are the conditions that your third coding project must implement:

your solution must use the following string array to represent the input to your coding logic:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

Your solution must include an inner do-while or while loop that can be used to process the myString variable.

In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

In the inner loop, your solution must not display the period character.

In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

Comment out all of the code in the Visual Studio Code Editor panel

Select all of the code lines in the code editor
On the Edit menu, select Toggle Block Comment.
Write the code that implements each condition listed for code project 3.

Run your application and verify that your output meets the requirements.
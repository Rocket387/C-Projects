write code that validates string input
Here are the conditions that your second coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and training space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Comment out all of the code in the Visual Studio Code Editor panel

Select all of the code lines in the code editor
On the Edit menu, select Toggle Block Comment.
Write the code that implements each condition for code project 2.

Run your application and verify that your code validates user input based on the specified requirements.

For example, when you run your application, it should reject an input value such as "Admin", but it should accept an input value of " administrator ".
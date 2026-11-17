# Chapter 4: Loops And Files

## Topics
- 5.1 The while Loop
- 5.2 The ++ and -- Operators
- 5.3 The for Loop
- 5.4 The do-while Loop
- 5.5 Using Files for Data Storage
- 5.6 The OpenFileDialog and SaveFileDialog Controls

### While Loop
- A while loop is used to repeat a statement or group of statements as long as a condition is true.
- **Structure of a while Loop:** A while loop has two parts:
  - Boolean expression: Checks whether the condition is true or false.
  - Loop body: Contains the statements that are repeated.
- **Pretest Loop:** A while loop is a pretest loop because it checks the condition before executing the statements.
- **Infinite Loop:** An infinite loop is a loop that continues running because its condition never becomes false.

### Increment and Decrement Operators
- Increment increases a variable's value by 1.
- Decrement decreases a variable's value by 1.
- ++ : Increases by 1.
- -- : Decreases by 1.
- **Postfix and Prefix Mode:**
  - Postfix: Uses the old value first, then changes it.
  - Prefix: Changes the value first, then uses it.

### For Loop
- A for loop is used when the number of repetitions is controlled by a counter variable.
- A for loop has three parts:
  - Initialization: Sets the starting value.
  - Test: Checks the condition.
  - Update: Increases or decreases the counter.

### Do-While Loop
- A do-while loop executes the statements first and checks the condition afterward.
- It always executes at least once.

### Using Files for Data Storage
- Files are used to save data for later use.
- There are three main steps:
  - Open the file.
  - Process the file.
  - Close the file.
- **Types of Files:**
  - Text File: Contains data stored as readable text.
  - Binary File: Contains data that is not stored as readable text.
- **File Accessing:** A file object is an object associated with a specific file that allows a program to work with that file. Two important classes are:
  - StreamWriter: Used to write data to a text file.
  - StreamReader: Used to read data from a text file.
- **Writing Data to a File:** Writing data means storing information in a file.
  - File.CreateText(): Creates a new text file. If the file exists, its contents are erased.
  - File.AppendText(): Adds new data to an existing file.
  - Write(): Writes data without a new line.
  - WriteLine(): Writes data and moves to a new line.
  - Close(): Closes the file.
- **Reading Data from a File:** Reading data means getting information from a file. Common methods include:
  - File.OpenText(): Opens a text file for reading.
  - Read(): Reads characters from a file.
  - ReadLine(): Reads one line from a file.
  - ReadToEnd(): Reads all remaining content.
  - File.ReadAllText(): Reads all text from a file.
  - Close(): Closes the file.
- **Reading a File with a Loop:**
  - A loop can be used to read data from a file until the end of the file is reached.
  - EndOfStream is a Boolean property that checks whether the end of the file has been reached.

### OpenFileDialog and SaveFileDialog Controls
- These controls allow an application to display standard Windows dialog boxes for opening and saving files.
- OpenFileDialog: Displays a dialog box for selecting and opening a file.
- SaveFileDialog: Displays a dialog box for selecting where to save a file.
- **ShowDialog() Method:** The ShowDialog() method displays a dialog box and allows the user to select an option.
- **DialogResult:** DialogResult indicates which button the user clicks to close the dialog box.
  - DialogResult.OK: The user clicks OK.
  - DialogResult.Cancel: The user clicks Cancel.
- **FileName Property:** The FileName property stores the path and name of the selected file.
- **InitialDirectory Property:** The InitialDirectory property specifies the folder that appears first when the dialog box opens.
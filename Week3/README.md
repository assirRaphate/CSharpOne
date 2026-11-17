# Chapter 3: Making Decisions

## Topics
- 3.1 Decision Structures and the if Statement
- 3.2 The if-else Statement
- 3.3 Nested Decision Structures
- 3.4 Logical Operators
- 3.5 bool Variables and Flags
- 3.6 Comparing Strings
- 3.7 Preventing Data Conversion Exceptions with the TryParse Method
- 3.8 Input Validation
- 3.9 Radio Buttons and Check Boxes
- 3.10 The switch Statement
- 3.11 Introduction to List Boxes

### Decision Structures and the if Statement
- A control structure controls the order in which statements execute. A decision structure executes statements only when a certain condition is true.
- The if statement is used to check a condition.

### The if-else Statement
- The if-else statement executes one block of code if the condition is true and another block if the condition is false.

### Nested Decision Structures
- Nested decision structures are used to check more than one condition. Nested means one decision structure inside another.

### Logical Operators
- Logical operators are used to connect or reverse conditions.
- && (AND): Both conditions must be true.
- || (OR): One or both conditions must be true.
- ! (NOT): Reverses the Boolean value.

### bool Variables and Flags
- A bool variable stores only two values: true or false. A flag is a variable that signals whether a certain condition exists in a program.

### Comparing Strings
- Strings can be compared using relational operators and methods.
- == compares two strings.
- != checks if two strings are different.
- String.Compare() compares two strings.

### Preventing Data Conversion Exceptions with the TryParse Method
- The TryParse method is used to prevent exceptions when users enter invalid data.
- Examples:
  - int.TryParse()
  - double.TryParse()
  - decimal.TryParse()
- The out keyword specifies the target variable that receives the converted value.

### Input Validation
- Input validation is the process of checking user input to make sure it is valid before using it.
- TryParse checks whether input can be converted, while input validation checks whether the value is reasonable.

### Radio Buttons and Check Boxes
- RadioButton: Allows the user to select only one option from several choices.
- CheckBox: Allows the user to select multiple options.
- The Checked property determines whether a control is selected or not.

### The switch Statement
- The switch statement is used to select one action from multiple choices based on a variable or expression.
- case: Defines a possible value.
- break: Ends the current case.
- default: Executes when no case matches.

### Introduction to List Boxes
- A ListBox displays a list of items and allows the user to select an item.
- Common properties and methods:
  - Text: Gets the text of the selected item.
  - Items: Contains the items in the ListBox.
  - Items.Count: Gets the total number of items.
  - SelectedItem: Gets the selected item.
  - SelectedIndex: Gets the index of the selected item.
  - Items.Add(): Adds an item.
  - Items.Remove(): Removes a specific item.
  - Items.RemoveAt(): Removes an item using its index.
  - Items.Clear(): Removes all items.
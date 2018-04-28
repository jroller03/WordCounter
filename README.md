# Word Counter

#### A program that allows users to input a sentence string and a word they want to count in that string to get the word count of that word. 4/27/18

#### By **Justin Roller**

## Description

A website created with C# and HTML where a user can submit a string sentence and a word they wish to count in that sentence and give them the word count.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Homepage** | User accesses http://localhost:5000| Homepage with input boxes of sentence and word wish to be counted. |
| **Program Directs you to homepage for input** | User input: "Sally sell sea shells by the sea shore. "word: Sally"" | Output: "Word Counter = 1" |
| **No Input**| User Input: "sentence: "" word:""" | Output: "0" |
| **Partial Match**| Input: "sentence: "back" "b" | Output: "0" |
| **Incorrect Input** | Input: "sentence: "apple" word: "3"" | Output: "will not run" |
| **Multiple word match** | Input: "sentence: "apple bags of apple" word: "apple"" | Output: "2" |
| **No Match** | Input: "sentence: "Practice makes perfect" word: "ball"" | Output: "0" |

## Setup/Installation Requirements

1. To run this program, you must have a C# compiler. I use [Mono](http://www.mono-project.com).
2. Clone this repository.
3. run dotnet run in command box and dotnet test.
4. go to browser and go to localhost:5000.
5. Explore my Word Counter program.

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
  * Razor View Engine
  * ASP.NET Kestrel HTTP server

* HTML
* Bootstrap

## Support and contact details

_justinrllr@yahoo.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2018 **_{Justin Roller co.}_**

# Old Phone Pad App

[![Coverage Status](https://coveralls.io/repos/github/murageden/oldphonepadapp/badge.svg?branch=main)](https://coveralls.io/github/murageden/oldphonepadapp?branch=main)


[![Build Status](https://app.travis-ci.com/murageden/oldphonepadapp.svg?token=w8hHvGyR9woT2enDmmCe&branch=main)](https://app.travis-ci.com/murageden/oldphonepadapp)

This app demonstrates how the old phone keypad works. It has alphabetical letters, a backspace key, and a send button

##  Keypad Features

- Includes a "**#**" key to signify the end of the input
- Allows a space "**__**" to signify pressing a character more than once
- The "__*__" key to signify the backspace character
- Allows all digits (from **1-9**, and **0** for space)

## How it Works

1. Input keypad numbers are mapped to letters via the String Builder class like `2 -> ABC`, `3 -> DEF`
2. Multiple presses of a key will move to the next digit in the keypad
3. The space key "**__**" pauses and moves to the next key in the keypad
4. The "**#**" key acts as the send button and signifies the end of the input


## Design

This program is written in C# using the Microsoft's .net framework for running and unit testing: It includes the following design features:

- __StringBuilder__ class for easier string composition
- A __Dictionary__ for storing key-letter pairs for the buttons
- An Iteration process for handling continuous input
- An automated testing and test coverage reporting
- An automated test running and code versioning script `build_test_push_script.sh`


## How to Run

Compile and run the program from the terminal:

```
cd OldPhonePadApp/
dotnet build
dotnet run
```

## How to Run Tests

Compile and run unit test cases for the program from the terminal:

```
cd OldPhonePadApp.Tests/
dotnet build
dotnet run
dotnet test
```

## How to Run Tests with Test Coverage

Compile and run unit test cases for the program and collect code coverage from the terminal:

```
cd OldPhonePadApp.Tests/
dotnet build
dotnet run
dotnet test --collect "Code Coverage" --results-directory TestResults/
```
Here you will find a randomly named `.coverage` file containing a test coverage report for the unit tests


## Automatic Versioning
To automatically run tests and push to the remote Github repository, run the following command:

```
bash build_test_push_script.sh
```
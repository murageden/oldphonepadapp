#!/bin/bash

TEST_COMMAND="dotnet test" 

echo $'Automatically Running Tests and Pushing Changes to GitHub... \n'

# Check for compile time errors
cd OldPhonePadApp/
dotnet build

if [ $? -ne 0 ]; then
    echo $'Build failed. Could be errors in the code Exiting script. \n'
    exit 1 # Failure
fi

# Run tests
echo "\n Now Running Tests... \n"
if [ ! -d "OldPhonePadApp.Tests" ]; then
    cd ../OldPhonePadApp.Tests
fi

dotnet restore
$TEST_COMMAND

# Check if the test command was successful
if [ $? -eq 0 ]; then
    echo $'All tests passed! Pushing to GitHub... \n'
    # Add changes to git
    cd ../
    git add .
    git commit -m "app (Fix new line Automated Testing): Auto Run Tests and Push Changes"
    git push origin main
    echo $'\n Changes pushed successfully. \n'
    exit 0 # Success
else
    echo $'Some Tests Failed. Push to Github will not be successful. \n'
    exit 1 # Failure
fi

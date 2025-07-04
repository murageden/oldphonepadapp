#!/bin/bash

TEST_COMMAND="dotnet test" 

echo "Running Tests With: $TEST_COMMAND"

# Check for compile time errors
cd OldPhonePadApp/
dotnet build

if [ $? -ne 0 ]; then
    echo "Build failed. Could be errors in the code Exiting script."
    exit 1 # Failure
fi

# Run tests
echo "Running Tests..."
if [ ! -d "OldPhonePadApp.Tests" ]; then
    cd ../OldPhonePadApp.Tests
fi

dotnet restore
$TEST_COMMAND

# Check if the test command was successful
if [ $? -eq 0 ]; then
    echo "All tests passed! Pushing to GitHub..."
    # Add changes to git
    cd ../
    git add .
    git commit -m "app (fix automated testing): Run tests and Push Changes"
    git push origin main
    echo "Changes pushed successfully."
    exit 0 # Success
else
    echo "Some Tests Failed. Push to Github will not be successful."
    exit 1 # Failure
fi

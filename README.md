# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator

This repository contains my Web-Based Calculator project. The source folder contains the calculator engine, calculator web app, calculator engine unit tests, and the end-to-end tests. 


## Table of Contents

- [Environment](#environment)
- [Executing the Web Application](#executing-the-web-application)
- [Executing Unit Tests](#executing-unit-tests)
- [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage)
- [Executing End-To-End Tests](#executing-end-to-end-tests)
- [Final Video Presentation](#final-video-presentation)

## Team Members

Brodey McGinnis

## Architecture

<img src="Images/plantUMLDiagram.png" alt="plantUMLDiagram.png" style="zoom: 50%;" 
/>

- The web server app references the calculator engine, sending the user input and receiving back the results of calculations
- The calculator engine unit test references the calculator engine and directly tests the calculator logic
- The end-to-end tests reference the html of the running web server app and tests the functionality 
## Environment

This application is cross-platform and should work on Windows 10+, Mac OSx Ventura+, and Linux environments, however it was exclusively developed and tested using Windows 11.

To prepare your environment to execute this application:

 1. [Install .NET SDK](https://dotnet.microsoft.com/download)
 2. [Install Playwright for end-to-end testing](https://playwright.dev/dotnet/docs/intro#installing-playwright)
 3. If you don't have it installed beforehand, [install PowerShell for Windows](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.4)
 4. You will likely need to use `pwsh bin/Debug/net8.0/playwright.ps1 install` at the location of the Web App if you have never used Playwright before

## Executing the Web Application

The web application is able to run from either the command line or an IDE like JetBrains Rider.

To run from the command line:

 1. Open command prompt/terminal
 2. Locate the location of CalculatorWebServerApp.csproj and copy the path
 3. Run the project with the command `dotnet run --project C:path/CalculatorWebServerApp.csproj` (replace C:path/CalculatorWebServerApp.csproj with the copied path)
 4. After the application starts, launch a browser and connect to http://localhost:7277 or http://localhost:5238

If your browser says the source is untrusted you should be able to continue to the site.

Sample output:
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7277
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5238
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
```

## Executing Unit Tests

 1. Open command prompt/terminal
 2. Locate the location of CalculatorEngineUnitTests.csproj and copy the path
 3. Run the project with the command `dotnet test C:path/CalculatorEngineUnitTests.csproj` (replace C:path/CalculatorEngineUnitTests.csproj with the copied path)

Sample Output:
```
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:    22, Skipped:     0, Total:    22, Duration: 34 ms - CalculatorEngineUnitTests.dll (net8.0)
```

## Reviewing Unit Test Coverage

<img src="Images/Coverage.png" alt="Coverage.png" style="zoom: 50%;" 
/>

All calculator functions received 100% coverage. The 2 uncovered lines are the empty main method.

## Executing End-To-End Tests

 1. Repeat the steps to [executing the web application](#executing-the-web-application) as it will need to be running to perform the end-to-end tests. 
 2. Open another command prompt/terminal
 3. Run the tests with the command `dotnet test C:path/CalculatorEndtoEndTests.csproj` (replace C:path/CalculatorEndtoEndTests.csproj with the copied path)

Upon testing on a new computer, I have run into a "ERR_CERT_AUTHORITY_INVALID" error and have been unable to resolve the issue.

 Sample Output:
 ```
 Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 5 s - CalculatorEndToEndTests.dll (net8.0)
```

## Final Video Presentation
[Youtube link](https://youtu.be/MCtxJSj4yls)


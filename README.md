# DataBrain Coding Test Submission

Hi Nick,
The solution has been refactored into several projects containing:
    Common: 
        Contains definitions that are used across multiple projects including dto models, interfaces and enums
    PAYG: 
        Contains just the PAYGService.cs 
    PAYG.Tests: 
        Contains the unit tests for the first task
    Web: 
        This project was added using the 'ASP.NET Core with Angular' template from within Visual Studio 2022 (17.5.4)
            thus following the layout of that template. Folders of note are:
        /Controllers: Contains the web.API endpoint for task 2.
        /ClientApp/src/app/payg-calculator: This is the module I created which contains the component, model and service required for task 3.

        This has been built using angular v15.1.6.
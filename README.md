# HerokuApp Automation Testing (BDD Framework)
Automated UI test framework built with **Selenium WebDriver**, **C#**, **Reqnroll (SpecFlow)**,**NUnit** and **ExtentReports** following the **Page Object Model** design pattern. The project covers feature validations on [the-internet.herokuapp.com](https://the-internet.herokuapp.com), a popular site for practicing web automation.
## Features Automated
- [x] **Login** 
- [x] **Checkboxes**
- [x] **Dropdown**
- [x] **JavaScript alert**
- [x] **Dynamic controls** (input field)
## Tech Stack
- **Language:** C#
- **Test Framework:** NUnit
- **BDD Tool:** Reqnroll (SpecFlow fork)
- **Automation Tool:** Selenium WebDriver
- **Reporting Tool:** Extent Reports
- **Design Pattern:** Page Object Model (POM)
- **IDE:** Visual Studio
- **Version Control:** Git + GitHub
## Project Structure
```
HerokuAutomationTests/
│
├── Drivers/            → WebDriver initialization (WebDriverFactory.cs)
├── Pages/              → Page Object classes (LoginPage.cs, CheckboxPage.cs, etc.)
├── Features/           → Gherkin .feature files
├── StepDefinitions/    → Step bindings for feature steps
├── Tests/              → NUnit test runners
└── Utils/              → Utility classes/helpers
```
## How to Run the Tests
1. Clone the repo:
   ```bash
   git clone https://github.com/AliyyaAsma/HerokuAutomationTests.git
   ```
2. Open the project in **Visual Studio**.
3. Restore NuGet packages:
   - `Reqnroll.SpecFlow`
   - `Selenium.WebDriver`
   - `NUnit`
   - `NUnit3TestAdapter`
   - `ExtentReports`
4. Build the project.
5. Open the **Test Explorer** and run tests, or use the terminal:
   ```bash
   dotnet test
   ```
## Author
**Aliyya Asma**  
[GitHub Profile](https://github.com/AliyyaAsma)

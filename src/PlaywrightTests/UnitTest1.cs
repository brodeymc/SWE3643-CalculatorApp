using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://localhost:7277"); 
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }
    
    [Test]
    public async Task CalculatorWebUi_NoInput_PageTitleCalculator()
    {
        //preq-E2E-TEST-5
        const string title = "Calculator";
        await Expect(Page).ToHaveTitleAsync(title);
    }
    
    [Test]
        public async Task CalculatorWebUi_AddOperation_ReturnsSum()
        {
            //preq-E2E-TEST-6
            await Page.FillAsync("#InputA", "2");
            await Page.FillAsync("#InputB", "3");
            await Page.ClickAsync("#AddButton");
            
            await Expect(Page.Locator("#Result")).ToContainTextAsync("5");
        }

        [Test]
        public async Task CalculatorWebUi_DivideByZero_ReturnsError()
        {
            //preq-E2E-TEST-7
            await Page.FillAsync("#InputA", "10");
            await Page.FillAsync("#InputB", "0");
            await Page.ClickAsync("#DivideButton");
            
            await Expect(Page.Locator("#Result")).ToContainTextAsync("Not a Number");
        }

        [Test]
        public async Task CalculatorWebUi_InvalidInput_ReturnsError()
        {
            //preq-E2E-TEST-8
            await Page.FillAsync("#InputA", "10");
            await Page.FillAsync("#InputB", "fifteen");
            await Page.ClickAsync("#AddButton");
            
            await Expect(Page.Locator("#Result")).ToContainTextAsync("Invalid Input, Numbers Only");
        }

        [Test]
        public async Task CalculatorWebUi_ClearButton_ReturnsToDefaultState()
        {
            //preq-E2E-TEST-9
            await Page.FillAsync("#InputA", "5");
            await Page.FillAsync("#InputB", "3");
            await Page.ClickAsync("#AddButton");
            await Page.ClickAsync("#ClearButton");
            
            await Expect(Page.Locator("#Result")).ToContainTextAsync("Enter value(s) below and select an operation.");
            await Expect(Page.Locator("#InputA")).ToHaveValueAsync("0");
            await Expect(Page.Locator("#InputB")).ToHaveValueAsync("0");
        }
}
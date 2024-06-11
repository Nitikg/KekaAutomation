using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

class Program
{
    static void Main(string[] args)
    {
        // Setup Chrome driver
        new DriverManager().SetUpDriver(new ChromeConfig());

        // Create a new instance of the Chrome driver
        IWebDriver driver = new ChromeDriver();

        // Navigate to your website
        driver.Navigate().GoToUrl("https://svam.keka.com/");
        System.Threading.Thread.Sleep(5000); // this is not the best way to wait, consider using WebDriverWait

        // Find the elements
        IWebElement clockIn = driver.FindElement(By.XPath("//home-attendance-clockin-widget//button")); // replace with your username field id

        //Scroll down 
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollBy(0,250)", "");

        // Perform actions
        clockIn.Click();

        // Wait for page to load after login

        //// Click clock in
        //clockInButton.Click();

        // Close the driver
        driver.Quit();
    }
}

using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace h18.SeleniumWithSpecFlow.Chrome
{
    public class ChromeHook : HookBase<ChromeDriver, ChromeOptions>
    {
        public ChromeHook(ScenarioContext context) : base(context)
        {

        }

        protected override ChromeDriver GetDriver(ChromeOptions options)
        {
            options.AddArgument("no-sandbox");
            return new ChromeDriver(options);
        }

        protected override HookConfigurationBase<ChromeOptions> GetDefaultConfiguration()
        {
            return new ChromeHookConfiguration();
        }
    }
}

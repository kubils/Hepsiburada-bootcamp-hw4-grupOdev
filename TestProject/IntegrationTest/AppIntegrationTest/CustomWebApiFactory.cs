using API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.IntegrationTest.AppIntegrationTest
{
  public class CustomWebApiFactory : WebApplicationFactory<Startup>
  {
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
      //var projectDir = Directory.GetCurrentDirectory();
      //var configPath = Path.Combine(projectDir, "appsettings.json");

      string absoluteAppSettingsTestJsonPath = "C:\\Users\dell\\RiderProjects\\HepsiBuradaBootcamp\\HepsiBurada_Week4\\hw4-gitpub-ecommerce\\TestProject\\appsettings.test.json";

      builder
        .ConfigureAppConfiguration((context, config) => {
          config
            .AddJsonFile(absoluteAppSettingsTestJsonPath)
            .AddEnvironmentVariables();
        });
    }
  }
}

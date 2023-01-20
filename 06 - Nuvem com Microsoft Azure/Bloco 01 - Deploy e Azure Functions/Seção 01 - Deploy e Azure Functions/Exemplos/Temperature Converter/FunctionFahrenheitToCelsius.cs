using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace TemperatureConverter
{
    public class FunctionFahrenheitToCelsius
    {
        private readonly ILogger<FunctionFahrenheitToCelsius> _logger;

        public FunctionFahrenheitToCelsius(ILogger<FunctionFahrenheitToCelsius> log)
        {
            _logger = log;
        }

        [FunctionName("ConvertFahrenheitToCelsius")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Conversion" })]
        [OpenApiParameter(name: "fahrenheit", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "The value in **Fahrenheit** for conversion to Celsius")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "Returns the value in Celsius")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "ConvertFahrenheitToCelsius/{fahrenheit}")] HttpRequest req,
            double fahrenheit)
        {
            _logger.LogInformation($"Received parameter: {fahrenheit}", fahrenheit);

            var celsiusValue = (fahrenheit - 32) * 5 / 9;

            string responseMessage = $"The value in Fahrenheit {fahrenheit} in Celsius is: {celsiusValue}";

            _logger.LogInformation($"Conversion done! Result: {celsiusValue}");

            return new OkObjectResult(responseMessage);
        }
    }
}


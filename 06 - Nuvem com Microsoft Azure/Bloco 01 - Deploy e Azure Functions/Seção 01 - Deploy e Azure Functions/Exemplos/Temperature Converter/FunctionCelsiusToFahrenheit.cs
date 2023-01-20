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
    public class FunctionCelsiusToFahrenheit
    {
        private readonly ILogger<FunctionCelsiusToFahrenheit> _logger;

        public FunctionCelsiusToFahrenheit(ILogger<FunctionCelsiusToFahrenheit> log)
        {
            _logger = log;
        }

        [FunctionName("ConvertCelsiusToFahrenheit")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Conversion" })]
        [OpenApiParameter(name: "celsius", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "The value in **Celsius** for conversion to Fahrenheit")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "Returns the value in Fahrenheit")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "ConvertCelsiusToFahrenheit/{celsius}")] HttpRequest req,
            double celsius)
        {
            _logger.LogInformation($"Received parameter: {celsius}", celsius);

            var fahrenheitValue = ((celsius * 9) / 5) + 32;

            string responseMessage = $"The value in Celsius {celsius} in Fahrenheit is: {fahrenheitValue}";

            _logger.LogInformation($"Conversion done! Result: {fahrenheitValue}");

            return new OkObjectResult(responseMessage);
        }
    }
}


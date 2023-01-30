using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlobStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Files : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public Files(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("BlobConnectionString");
            _containerName = configuration.GetValue<string>("BlobContainerName");
        }
    }
}
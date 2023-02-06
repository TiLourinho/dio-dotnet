using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
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

        [HttpPost("Upload")]
        public IActionResult UploadFile(IFormFile file)
        {
            // BLOB = Binary Large Object

            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(file.FileName);

            using var data = file.OpenReadStream();
            blob.Upload(data, new BlobUploadOptions
            {
                HttpHeaders = new BlobHttpHeaders { ContentType = file.ContentType }
            });

            return Ok(blob.Uri.ToString());
        }

        [HttpGet("Download/{name}")]
        public IActionResult DownloadFile(string name)
        {
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(name);

            if (!blob.Exists())
                return BadRequest();

            var result = blob.DownloadContent();
            return File(result.Value.Content.ToArray(), result.Value.Details.ContentType, blob.Name);
        }

        [HttpDelete("Delete/{name}")]
        public IActionResult DeleteFile(string name)
        {
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(name);

            blob.DeleteIfExists();

            return NoContent();
        }

        [HttpGet("List")]
        public IActionResult ListFiles()
        {
            List<BlobDTO> blobs = new List<BlobDTO>();
            BlobContainerClient container = new(_connectionString, _containerName);

            foreach (var blob in container.GetBlobs())
            {
                blobs.Add(new BlobDTO
                {
                    Name = blob.Name,
                    Type = blob.Properties.ContentType,
                    Uri = $"{container.Uri.AbsoluteUri}/{blob.Name}"
                });
            }

            return Ok(blobs);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlobStorageAPI.Controllers
{
    public class BlobDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}
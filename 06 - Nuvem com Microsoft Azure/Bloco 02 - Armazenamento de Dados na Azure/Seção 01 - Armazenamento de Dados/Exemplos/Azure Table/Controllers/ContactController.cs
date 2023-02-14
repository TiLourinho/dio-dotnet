using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Data.Tables;
using AzureTable.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureTable.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public ContactController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("SAConnectionString");
            _tableName = configuration.GetValue<string>("AzureTableName");
        }

        private TableClient GetTableClient()
        {
            var serviceClient = new TableServiceClient(_connectionString);
            var tableClient = serviceClient.GetTableClient(_tableName);

            tableClient.CreateIfNotExists();

            return tableClient;
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            var tableClient = GetTableClient();

            contact.RowKey = Guid.NewGuid().ToString();
            contact.PartitionKey = contact.RowKey;

            tableClient.UpsertEntity(contact);

            return Ok(contact);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Contact contact, string id)
        {
            var tableClient = GetTableClient();
            var contactTable = tableClient.GetEntity<Contact>(id, id).Value;

            contactTable.Name = contact.Name;
            contactTable.Phone = contact.Phone;
            contactTable.Email = contact.Email;

            tableClient.UpsertEntity(contactTable);

            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var tableClient = GetTableClient();
            var contacts = tableClient.Query<Contact>().ToList();

            return Ok(contacts);
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            var tableClient = GetTableClient();
            var contacts = tableClient.Query<Contact>(x => x.Name == name).ToList();

            return Ok(contacts);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var tableClient = GetTableClient();
            tableClient.DeleteEntity(id, id);

            return NoContent();
        }
    }
}
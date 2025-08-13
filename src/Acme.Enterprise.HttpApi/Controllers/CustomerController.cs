using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.Enterprise.Application;
using Acme.Enterprise.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using Snacker.Api.Controllers;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Enterprise.HttpApi.Controllers
{
    [Route("api/customers")]
    public class CustomerController : ApiController
    {
        private readonly ICustomersAppService _service;

        public CustomerController(ICustomersAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<CustomerDto>> GetListAsync() => _service.GetListAsync();

        [HttpGet("{id}")]
        public Task<CustomerDto> GetAsync(Guid id) => _service.GetAsync(id);

        [HttpPost]
        public Task<CustomerDto> CreateAsync([FromBody] CreateCustomerDto input) => _service.CreateAsync(input);

        [HttpPut("{id}")]
        public Task UpdateAsync(Guid id, [FromBody] UpdateCustomerDto input) => _service.UpdateAsync(id, input);

        [HttpDelete("{id}")]
        public Task DeleteAsync(Guid id) => _service.DeleteAsync(id);
    }
}

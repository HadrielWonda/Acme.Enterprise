using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.Enterprise.Application.DTOs;

namespace Acme.Enterprise.Application;

    public interface ICustomersAppService
    {
        Task<CustomerDto> GetAsync(Guid id);
        Task<List<CustomerDto>> GetListAsync();
        Task<CustomerDto> CreateAsync(CreateCustomerDto input);
        Task UpdateAsync(Guid id, UpdateCustomerDto input);
        Task DeleteAsync(Guid id);
    }

    public class CreateCustomerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class UpdateCustomerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }


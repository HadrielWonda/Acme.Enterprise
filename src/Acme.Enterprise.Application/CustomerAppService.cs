using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.Enterprise.Application.DTOs;
using Acme.Enterprise.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Enterprise.Application;

    public class CustomersAppService : ApplicationService, ICustomersAppService
    {
        private readonly IRepository<Customer, Guid> _repository;

        public CustomersAppService(IRepository<Customer, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<CustomerDto> GetAsync(Guid id)
        {
            var entity = await _repository.GetAsync(id);
            return new CustomerDto { Id = entity.Id, Name = entity.Name, Email = entity.Email };
        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            var list = await _repository.GetListAsync();
            return list.Select(e => new CustomerDto { Id = e.Id, Name = e.Name, Email = e.Email }).ToList();
        }

        public async Task<CustomerDto> CreateAsync(CreateCustomerDto input)
        {
            var entity = new Customer(Guid.NewGuid(), input.Name, input.Email);
            await _repository.InsertAsync(entity);
            return new CustomerDto { Id = entity.Id, Name = entity.Name, Email = entity.Email };
        }

        public async Task UpdateAsync(Guid id, UpdateCustomerDto input)
        {
            var entity = await _repository.GetAsync(id);
            entity.Update(input.Name, input.Email);
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }


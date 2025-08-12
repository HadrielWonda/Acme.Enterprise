using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Enterprise.Domain.Entities
{
    public class Customer : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool IsActive { get; private set; }

        protected Customer() { }

        public Customer(Guid id, string name, string email) : base(id)
        {
            Name = name;
            Email = email;
            IsActive = true;
        }

        public void Update(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Deactivate() => IsActive = false;
        public void Activate() => IsActive = true;
    }
}

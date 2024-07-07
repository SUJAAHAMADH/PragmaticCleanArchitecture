using BookiFy.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookiFy.Domain.Users.Events
{
    public sealed record UserCreatedDomainEvent(Guid userId) : IDomainEvent;
   
}

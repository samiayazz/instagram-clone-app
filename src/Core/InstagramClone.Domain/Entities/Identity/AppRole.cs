﻿using InstagramClone.Domain.Interfaces.Base;
using Microsoft.AspNetCore.Identity;

namespace InstagramClone.Domain.Entities.Identity
{
    public class AppRole : IdentityRole<Guid>, IEntity
    {
        public AppRole(string name)
            => base.Name = name;

        public AppRole(Guid id, string name)
            => (Id, base.Name) = (id, name);

        public new Guid Id { get; private init; } = Guid.NewGuid();
    }
}
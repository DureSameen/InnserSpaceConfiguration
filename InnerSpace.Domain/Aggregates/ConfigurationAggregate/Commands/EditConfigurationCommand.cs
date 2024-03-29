﻿using System;
using MediatR;

namespace InnerSpace.Domain.Aggregates.ConfigurationAggregate.Commands
{
    public class EditConfigurationCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
}

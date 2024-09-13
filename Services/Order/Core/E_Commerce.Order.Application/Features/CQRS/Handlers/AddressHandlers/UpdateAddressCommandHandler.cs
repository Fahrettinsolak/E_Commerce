﻿using E_Commerce.Order.Application.Features.CQRS.Commands.AddressCommands;
using E_Commerce.Order.Application.Interfaces;
using E_Commerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.UserId = command.UserId;
            values.City = command.City;
            values.District = command.District;
            values.Detail = command.Detail;
            await _repository.UpdateAsync(values);
        }
    }
}

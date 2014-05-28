﻿using System.Diagnostics;
using FluentAssertions;
using Paynova.Api.Client.Responses;

namespace Paynova.Api.Client.Testing.Shoulds
{
    public class CreateOrderResponseShouldBe: ShouldBe<CreateOrderResponse>
    {
        [DebuggerStepThrough]
        public CreateOrderResponseShouldBe(CreateOrderResponse response) : base(response) { }

        public virtual void Ok()
        {
            Item.Should().NotBeNull();
            Item.OrderId.Should().NotBeEmpty();
            Item.Status.Should().NotBeNull();
            Item.Status.StatusKey.Should().Be("SUCCESS");
            Item.Status.StatusMessage.Should().Be("The operation was successful.");
        }
    }
}
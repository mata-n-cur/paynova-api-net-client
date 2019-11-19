﻿using System;
using FluentAssertions;
using Xunit;

namespace Paynova.Api.Client.UnitTests
{
    public class PaynovaApiUriBuilderTests : UnitTestsOf<PaynovaApiUriBuilder>
    {
        [Fact]
        public void When_not_passing_url_It_will_throw_argument_exception()
        {
            Action a = () => SUT = new PaynovaApiUriBuilder(string.Empty);

            a.Should().Throw<ArgumentException>()
                .And.ParamName.Should().Be("serverUrl");
        }

        [Fact]
        public void When_only_server_url_It_can_build_uri()
        {
            SUT = new PaynovaApiUriBuilder("https://api.foo.com");

            var uri = SUT.Build();
            
            uri.AbsoluteUri.Should().Be("https://api.foo.com/");
        }

        [Fact]
        public void When_providing_basic_credentials_It_will_build_uri_with_encoded_userinfo()
        {
            SUT = new PaynovaApiUriBuilder("https://api.foo.com")
                .SetBasicCredentials("s@", "p@ssword");

            var uri = SUT.Build();
            
            uri.AbsoluteUri.Should().Be("https://s%40:p%40ssword@api.foo.com/");
        }
    }
}
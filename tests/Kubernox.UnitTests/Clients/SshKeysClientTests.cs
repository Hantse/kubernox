using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kubernox.Client;
using Kubernox.Client.Models;

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

using NSubstitute;

namespace Kubernox.UnitTests.Clients
{
    public class SshKeysClientTests
    {
        private static readonly List<SSHKey> sshKeyMocks = new List<SSHKey>() {
            new SSHKey()
            {
                Id = Guid.NewGuid(),
                PublicKey = "Azertyuiop"
            }
        };

        [Fact]
        public async Task Get_AllKeys_Async()
        {
            // Arrange
            var adapter = Substitute.For<IRequestAdapter>();
            var kubernoxClient = new KubernoxClient(adapter);

            // Return the mocked list of posts
            adapter.SendCollectionAsync(
                Arg.Any<RequestInformation>(),
                Arg.Any<ParsableFactory<SSHKey>>(),
                Arg.Any<Dictionary<string, ParsableFactory<IParsable>>>(),
                Arg.Any<CancellationToken>())
                .ReturnsForAnyArgs(sshKeyMocks);

            // Act
            var sshKeys = await kubernoxClient.Api.SshKeys.GetAsync();

            // Assert
            Assert.NotNull(sshKeys);
            Assert.Equal(sshKeyMocks.Count, sshKeys.Count);
        }
    }
}

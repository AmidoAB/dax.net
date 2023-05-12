// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Amido AB">
//   Copyright © 2023 Amido AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Amido.Dax.Contracts.Contracts;
using Amido.Dax.WebClient;
using Amido.Dax.WebClient.Configuration;
using Amido.Dax.WebClient.Requests;
using AmidoAB.Dax.ExampleClient;

var privateKey = @"-----BEGIN RSA PRIVATE KEY-----xxxxx-----END RSA PRIVATE KEY-----";
var instanceId = "<your instance id>";
var username = "<username>";
var password = "<password>";

var config = new DaxWebClientConfigurationBuilder()
    .WithApiUrl("https://api-prod.dax.amido.io")
    .WithInstanceId(Guid.Parse(instanceId))
    .WithCredentials(username, password)
    .WithPrivateKey(privateKey)
    .WithTimeout(10000)
    .Build();

var client = new DaxWebClient(new Logger(), new SimpleHttpClientFactory());
client.Initialize(config);

var request = new DaxWebRequestBuilder<GetContractsRequest, GetContractsResponse>()
    .AddRequest(new GetContractsRequest(new ContractsResourceIdentifier()))
    .SetContext("Testrequest")
    .Build();

var result = await client.CallAsync(request);

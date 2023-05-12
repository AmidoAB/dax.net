// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleHttpClientFactory.cs" company="Amido AB">
//   Copyright © 2023 Amido AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AmidoAB.Dax.ExampleClient;

public class SimpleHttpClientFactory : IHttpClientFactory
{
    public HttpClient CreateClient(string name)
    {
        return new HttpClient();
    }
}
﻿namespace MultithredRest.Endpoints.HelloWorld.HelloWorld
{
    using System;
    using System.Threading.Tasks;
    using MultithreadRest.Helpers;
    using MultithredRest.Core.EndpointModel;
    using MultithredRest.Core.HttpServer;

    public class HelloWorld : EndpointBase, IHelloWorld
    {
        public HelloWorld(HttpMethod method)
            : base(method)
        {
        }

        public override async Task<ReadOnlyMemory<byte>> GenerateResponse(HttpRequestParameters requestParametres)
        {
            return await new { Message = "Hello world!" }.SerializeJsonAsync();
        }
    }
}
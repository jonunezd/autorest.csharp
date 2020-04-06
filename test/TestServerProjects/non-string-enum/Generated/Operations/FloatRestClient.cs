// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using non_string_enum.Models;

namespace non_string_enum
{
    internal partial class FloatRestClient
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;

        /// <summary> Initializes a new instance of FloatRestClient. </summary>
        public FloatRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        internal HttpMessage CreatePutRequest(FloatEnum? input)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/nonStringEnums/float/put", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (input != null)
            {
                using var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStringValue(input.Value.ToString());
                request.Content = content;
            }
            return message;
        }

        /// <summary> Put a float enum. </summary>
        /// <param name="input"> Input float enum. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<string>> PutAsync(FloatEnum? input = null, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("FloatClient.Put");
            scope.Start();
            try
            {
                using var message = CreatePutRequest(input);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            string value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = document.RootElement.GetString();
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put a float enum. </summary>
        /// <param name="input"> Input float enum. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<string> Put(FloatEnum? input = null, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("FloatClient.Put");
            scope.Start();
            try
            {
                using var message = CreatePutRequest(input);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            string value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = document.RootElement.GetString();
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/nonStringEnums/float/get", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a float enum. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<FloatEnum>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("FloatClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            FloatEnum value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = new FloatEnum(document.RootElement.GetSingle());
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a float enum. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FloatEnum> Get(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("FloatClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            FloatEnum value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = new FloatEnum(document.RootElement.GetSingle());
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
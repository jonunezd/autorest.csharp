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
using lro.Models;

namespace lro
{
    /// <summary> The LROsCustomHeader service client. </summary>
    public partial class LROsCustomHeaderClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LROsCustomHeaderRestClient RestClient { get; }
        /// <summary> Initializes a new instance of LROsCustomHeaderClient for mocking. </summary>
        protected LROsCustomHeaderClient()
        {
        }
        /// <summary> Initializes a new instance of LROsCustomHeaderClient. </summary>
        internal LROsCustomHeaderClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new LROsCustomHeaderRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Product> CreatePutAsyncRetrySucceeded(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Put, "LROsCustomHeaderClient.StartPutAsyncRetrySucceeded", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return Product.DeserializeProduct(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return Product.DeserializeProduct(document.RootElement);
                }
            });
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Product>> StartPutAsyncRetrySucceededAsync(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPutAsyncRetrySucceeded");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PutAsyncRetrySucceededAsync(product, cancellationToken).ConfigureAwait(false);
                return CreatePutAsyncRetrySucceeded(originalResponse, () => RestClient.CreatePutAsyncRetrySucceededRequest(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Product> StartPutAsyncRetrySucceeded(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPutAsyncRetrySucceeded");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PutAsyncRetrySucceeded(product, cancellationToken);
                return CreatePutAsyncRetrySucceeded(originalResponse, () => RestClient.CreatePutAsyncRetrySucceededRequest(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running put request, service returns a 201 to the initial request, with an entity that contains ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Product> CreatePut201CreatingSucceeded200(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Put, "LROsCustomHeaderClient.StartPut201CreatingSucceeded200", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return Product.DeserializeProduct(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return Product.DeserializeProduct(document.RootElement);
                }
            });
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running put request, service returns a 201 to the initial request, with an entity that contains ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Product>> StartPut201CreatingSucceeded200Async(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPut201CreatingSucceeded200");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.Put201CreatingSucceeded200Async(product, cancellationToken).ConfigureAwait(false);
                return CreatePut201CreatingSucceeded200(originalResponse, () => RestClient.CreatePut201CreatingSucceeded200Request(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running put request, service returns a 201 to the initial request, with an entity that contains ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Product> StartPut201CreatingSucceeded200(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPut201CreatingSucceeded200");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Put201CreatingSucceeded200(product, cancellationToken);
                return CreatePut201CreatingSucceeded200(originalResponse, () => RestClient.CreatePut201CreatingSucceeded200Request(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with &apos;Location&apos; and &apos;Retry-After&apos; headers, Polls return a 200 with a response body after success. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreatePost202Retry200(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Post, "LROsCustomHeaderClient.StartPost202Retry200", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with &apos;Location&apos; and &apos;Retry-After&apos; headers, Polls return a 200 with a response body after success. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartPost202Retry200Async(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPost202Retry200");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.Post202Retry200Async(product, cancellationToken).ConfigureAwait(false);
                return CreatePost202Retry200(originalResponse, () => RestClient.CreatePost202Retry200Request(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with &apos;Location&apos; and &apos;Retry-After&apos; headers, Polls return a 200 with a response body after success. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartPost202Retry200(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPost202Retry200");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Post202Retry200(product, cancellationToken);
                return CreatePost202Retry200(originalResponse, () => RestClient.CreatePost202Retry200Request(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreatePostAsyncRetrySucceeded(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Post, "LROsCustomHeaderClient.StartPostAsyncRetrySucceeded", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartPostAsyncRetrySucceededAsync(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPostAsyncRetrySucceeded");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PostAsyncRetrySucceededAsync(product, cancellationToken).ConfigureAwait(false);
                return CreatePostAsyncRetrySucceeded(originalResponse, () => RestClient.CreatePostAsyncRetrySucceededRequest(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartPostAsyncRetrySucceeded(Product product = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LROsCustomHeaderClient.StartPostAsyncRetrySucceeded");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PostAsyncRetrySucceeded(product, cancellationToken);
                return CreatePostAsyncRetrySucceeded(originalResponse, () => RestClient.CreatePostAsyncRetrySucceededRequest(product));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
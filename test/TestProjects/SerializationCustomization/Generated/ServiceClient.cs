// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using SerializationCustomization.Models;

namespace SerializationCustomization
{
    /// <summary> The Service service client. </summary>
    public partial class ServiceClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }
        /// <summary> Initializes a new instance of ServiceClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="model"> The AlwaysInitializeTestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AlwaysInitializeTestModel>> Operation1Async(AlwaysInitializeTestModel model, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Operation1");
            scope.Start();
            try
            {
                return await RestClient.Operation1Async(model, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="model"> The AlwaysInitializeTestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AlwaysInitializeTestModel> Operation1(AlwaysInitializeTestModel model, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Operation1");
            scope.Start();
            try
            {
                return RestClient.Operation1(model, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="model"> The EmptyAsUndefinedTestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EmptyAsUndefinedTestModel>> Operation2Async(EmptyAsUndefinedTestModel model, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Operation2");
            scope.Start();
            try
            {
                return await RestClient.Operation2Async(model, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="model"> The EmptyAsUndefinedTestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EmptyAsUndefinedTestModel> Operation2(EmptyAsUndefinedTestModel model, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Operation2");
            scope.Start();
            try
            {
                return RestClient.Operation2(model, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="model"> The PropertyToJsonElementModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PropertyToJsonElementModel>> PropertyToJsonElementModelAsync(PropertyToJsonElementModel model, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.PropertyToJsonElementModel");
            scope.Start();
            try
            {
                return await RestClient.PropertyToJsonElementModelAsync(model, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="model"> The PropertyToJsonElementModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PropertyToJsonElementModel> PropertyToJsonElementModel(PropertyToJsonElementModel model, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.PropertyToJsonElementModel");
            scope.Start();
            try
            {
                return RestClient.PropertyToJsonElementModel(model, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

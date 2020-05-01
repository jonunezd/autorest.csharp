// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;

namespace Azure.Management.Storage
{
    /// <summary> The FileShares service client. </summary>
    public partial class FileSharesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FileSharesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of FileSharesClient for mocking. </summary>
        protected FileSharesClient()
        {
        }

        /// <summary> Initializes a new instance of FileSharesClient. </summary>
        public FileSharesClient(string subscriptionId, TokenCredential tokenCredential, StorageManagementClientOptions options = null)
        {
            options ??= new StorageManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new FileSharesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Creates a new share under the specified account as described by request body. The share resource includes metadata and properties for that share. It does not include a list of the files contained by the share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="metadata"> A name-value pair to associate with the share as metadata. </param>
        /// <param name="shareQuota"> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileShare>> CreateAsync(string resourceGroupName, string accountName, string shareName, IDictionary<string, string> metadata = null, int? shareQuota = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(resourceGroupName, accountName, shareName, metadata, shareQuota, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new share under the specified account as described by request body. The share resource includes metadata and properties for that share. It does not include a list of the files contained by the share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="metadata"> A name-value pair to associate with the share as metadata. </param>
        /// <param name="shareQuota"> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileShare> Create(string resourceGroupName, string accountName, string shareName, IDictionary<string, string> metadata = null, int? shareQuota = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(resourceGroupName, accountName, shareName, metadata, shareQuota, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="metadata"> A name-value pair to associate with the share as metadata. </param>
        /// <param name="shareQuota"> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileShare>> UpdateAsync(string resourceGroupName, string accountName, string shareName, IDictionary<string, string> metadata = null, int? shareQuota = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, accountName, shareName, metadata, shareQuota, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="metadata"> A name-value pair to associate with the share as metadata. </param>
        /// <param name="shareQuota"> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileShare> Update(string resourceGroupName, string accountName, string shareName, IDictionary<string, string> metadata = null, int? shareQuota = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, accountName, shareName, metadata, shareQuota, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileShare>> GetAsync(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, accountName, shareName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileShare> Get(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, accountName, shareName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, accountName, shareName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileSharesClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, accountName, shareName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all shares. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional. Specified maximum number of shares that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only share names starting with the filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<FileShareItem> ListAsync(string resourceGroupName, string accountName, string maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            async Task<Page<FileShareItem>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FileSharesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, accountName, maxpagesize, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FileShareItem>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FileSharesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, accountName, maxpagesize, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all shares. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional. Specified maximum number of shares that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only share names starting with the filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<FileShareItem> List(string resourceGroupName, string accountName, string maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            Page<FileShareItem> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FileSharesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, accountName, maxpagesize, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FileShareItem> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FileSharesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, accountName, maxpagesize, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
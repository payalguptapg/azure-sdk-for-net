// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The InternalPhoneNumbers service client. </summary>
    internal partial class InternalPhoneNumbersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal InternalPhoneNumbersRestClient RestClient { get; }

        /// <summary> Initializes a new instance of InternalPhoneNumbersClient for mocking. </summary>
        protected InternalPhoneNumbersClient()
        {
        }

        /// <summary> Initializes a new instance of InternalPhoneNumbersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal InternalPhoneNumbersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-01-11-preview2")
        {
            RestClient = new InternalPhoneNumbersRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PhoneNumberSearchResult>> GetSearchResultAsync(string searchId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetSearchResult");
            scope.Start();
            try
            {
                return await RestClient.GetSearchResultAsync(searchId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a phone number search result by search id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PhoneNumberSearchResult> GetSearchResult(string searchId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetSearchResult");
            scope.Start();
            try
            {
                return RestClient.GetSearchResult(searchId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PhoneNumberOperation>> GetOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetOperation");
            scope.Start();
            try
            {
                return await RestClient.GetOperationAsync(operationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PhoneNumberOperation> GetOperation(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetOperation");
            scope.Start();
            try
            {
                return RestClient.GetOperation(operationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.CancelOperation");
            scope.Start();
            try
            {
                return await RestClient.CancelOperationAsync(operationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels an operation by its id. </summary>
        /// <param name="operationId"> The id of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelOperation(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.CancelOperation");
            scope.Start();
            try
            {
                return RestClient.CancelOperation(operationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PurchasedPhoneNumber>> GetByNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetByNumber");
            scope.Start();
            try
            {
                return await RestClient.GetByNumberAsync(phoneNumber, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details of the given purchased phone number. </summary>
        /// <param name="phoneNumber"> The purchased phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PurchasedPhoneNumber> GetByNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.GetByNumber");
            scope.Start();
            try
            {
                return RestClient.GetByNumber(phoneNumber, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PurchasedPhoneNumber> ListPhoneNumbersAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PurchasedPhoneNumber>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = await RestClient.ListPhoneNumbersAsync(skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PurchasedPhoneNumber>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = await RestClient.ListPhoneNumbersNextPageAsync(nextLink, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the list of all purchased phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PurchasedPhoneNumber> ListPhoneNumbers(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<PurchasedPhoneNumber> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = RestClient.ListPhoneNumbers(skip, top, cancellationToken);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PurchasedPhoneNumber> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = RestClient.ListPhoneNumbersNextPage(nextLink, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<SearchAvailablePhoneNumbersOperation> StartSearchAvailablePhoneNumbersAsync(string countryCode, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartSearchAvailablePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.SearchAvailablePhoneNumbersAsync(countryCode, body, cancellationToken).ConfigureAwait(false);
                return new SearchAvailablePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreateSearchAvailablePhoneNumbersRequest(countryCode, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="body"/> is null. </exception>
        public virtual SearchAvailablePhoneNumbersOperation StartSearchAvailablePhoneNumbers(string countryCode, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartSearchAvailablePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = RestClient.SearchAvailablePhoneNumbers(countryCode, body, cancellationToken);
                return new SearchAvailablePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreateSearchAvailablePhoneNumbersRequest(countryCode, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<InternalPurchasePhoneNumbersOperation> StartPurchasePhoneNumbersAsync(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartPurchasePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PurchasePhoneNumbersAsync(searchId, cancellationToken).ConfigureAwait(false);
                return new InternalPurchasePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurchasePhoneNumbersRequest(searchId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual InternalPurchasePhoneNumbersOperation StartPurchasePhoneNumbers(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartPurchasePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PurchasePhoneNumbers(searchId, cancellationToken);
                return new InternalPurchasePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurchasePhoneNumbersRequest(searchId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual async Task<UpdatePhoneNumberCapabilitiesOperation> StartUpdateCapabilitiesAsync(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartUpdateCapabilities");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateCapabilitiesAsync(phoneNumber, calling, sms, cancellationToken).ConfigureAwait(false);
                return new UpdatePhoneNumberCapabilitiesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual UpdatePhoneNumberCapabilitiesOperation StartUpdateCapabilities(string phoneNumber, PhoneNumberCapabilityType? calling = null, PhoneNumberCapabilityType? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartUpdateCapabilities");
            scope.Start();
            try
            {
                var originalResponse = RestClient.UpdateCapabilities(phoneNumber, calling, sms, cancellationToken);
                return new UpdatePhoneNumberCapabilitiesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual async Task<InternalReleasePhoneNumberOperation> StartReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartReleasePhoneNumber");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ReleasePhoneNumberAsync(phoneNumber, cancellationToken).ConfigureAwait(false);
                return new InternalReleasePhoneNumberOperation(_clientDiagnostics, _pipeline, RestClient.CreateReleasePhoneNumberRequest(phoneNumber).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Releases a purchased phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual InternalReleasePhoneNumberOperation StartReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("InternalPhoneNumbersClient.StartReleasePhoneNumber");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ReleasePhoneNumber(phoneNumber, cancellationToken);
                return new InternalReleasePhoneNumberOperation(_clientDiagnostics, _pipeline, RestClient.CreateReleasePhoneNumberRequest(phoneNumber).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

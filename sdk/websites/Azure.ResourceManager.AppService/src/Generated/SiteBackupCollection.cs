// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of BackupItem and their operations over its parent. </summary>
    public partial class SiteBackupCollection : ArmCollection, IEnumerable<SiteBackup>, IAsyncEnumerable<SiteBackup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteBackupCollection"/> class for mocking. </summary>
        protected SiteBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteBackupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteBackupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteBackup.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Description for Gets a backup of an app by its ID. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<SiteBackup> Get(string backupId, CancellationToken cancellationToken = default)
        {
            if (backupId == null)
            {
                throw new ArgumentNullException(nameof(backupId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetBackupStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Description for Gets a backup of an app by its ID. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public async virtual Task<Response<SiteBackup>> GetAsync(string backupId, CancellationToken cancellationToken = default)
        {
            if (backupId == null)
            {
                throw new ArgumentNullException(nameof(backupId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetBackupStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<SiteBackup> GetIfExists(string backupId, CancellationToken cancellationToken = default)
        {
            if (backupId == null)
            {
                throw new ArgumentNullException(nameof(backupId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetBackupStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SiteBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public async virtual Task<Response<SiteBackup>> GetIfExistsAsync(string backupId, CancellationToken cancellationToken = default)
        {
            if (backupId == null)
            {
                throw new ArgumentNullException(nameof(backupId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetBackupStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SiteBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<bool> Exists(string backupId, CancellationToken cancellationToken = default)
        {
            if (backupId == null)
            {
                throw new ArgumentNullException(nameof(backupId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backupId, CancellationToken cancellationToken = default)
        {
            if (backupId == null)
            {
                throw new ArgumentNullException(nameof(backupId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListBackups
        /// <summary> Description for Gets existing backups of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteBackup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListBackups(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListBackupsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListBackups
        /// <summary> Description for Gets existing backups of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteBackup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListBackupsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListBackupsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteBackup> IEnumerable<SiteBackup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteBackup> IAsyncEnumerable<SiteBackup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteBackup, BackupItemData> Construct() { }
    }
}

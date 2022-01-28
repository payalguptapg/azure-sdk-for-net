// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((armClient) =>
            {
                return new SubscriptionExtensionClient(armClient, subscription.Id);
            }
            );
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateSecretInput"> The Secret source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSecretInput"/> is null. </exception>
        public static async Task<Response<ValidateSecretOutput>> ValidateSecretAsync(this Subscription subscription, ValidateSecretInput validateSecretInput, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscription).ValidateSecretAsync(validateSecretInput, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateSecretInput"> The Secret source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSecretInput"/> is null. </exception>
        public static Response<ValidateSecretOutput> ValidateSecret(this Subscription subscription, ValidateSecretInput validateSecretInput, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).ValidateSecret(validateSecretInput, cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Profile> GetProfilesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProfilesAsync(cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Profile> GetProfiles(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProfiles(cancellationToken);
        }

        /// <summary> Filters the list of Profiles for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetProfilesAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProfilesAsGenericResourcesAsync(filter, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Profiles for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetProfilesAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProfilesAsGenericResources(filter, expand, top, cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityWithSubscriptionAsync(this Subscription subscription, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscription).CheckCdnNameAvailabilityWithSubscriptionAsync(checkNameAvailabilityInput, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public static Response<CheckNameAvailabilityOutput> CheckCdnNameAvailabilityWithSubscription(this Subscription subscription, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).CheckCdnNameAvailabilityWithSubscription(checkNameAvailabilityInput, cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public static async Task<Response<ValidateProbeOutput>> ValidateProbeAsync(this Subscription subscription, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscription).ValidateProbeAsync(validateProbeInput, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public static Response<ValidateProbeOutput> ValidateProbe(this Subscription subscription, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).ValidateProbe(validateProbeInput, cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceUsage> GetResourceUsagesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetResourceUsagesAsync(cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceUsage> GetResourceUsages(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetResourceUsages(cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedRuleSetsAsync(cancellationToken);
        }

        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedRuleSets(cancellationToken);
        }
    }
}

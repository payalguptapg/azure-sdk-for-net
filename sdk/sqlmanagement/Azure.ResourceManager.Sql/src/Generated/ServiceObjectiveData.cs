// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ServiceObjective data model. </summary>
    public partial class ServiceObjectiveData : Resource
    {
        /// <summary> Initializes a new instance of ServiceObjectiveData. </summary>
        public ServiceObjectiveData()
        {
        }

        /// <summary> Initializes a new instance of ServiceObjectiveData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="serviceObjectiveName"> The name for the service objective. </param>
        /// <param name="isDefault"> Gets whether the service level objective is the default service objective. </param>
        /// <param name="isSystem"> Gets whether the service level objective is a system service objective. </param>
        /// <param name="description"> The description for the service level objective. </param>
        /// <param name="enabled"> Gets whether the service level objective is enabled. </param>
        internal ServiceObjectiveData(ResourceIdentifier id, string name, ResourceType type, string serviceObjectiveName, bool? isDefault, bool? isSystem, string description, bool? enabled) : base(id, name, type)
        {
            ServiceObjectiveName = serviceObjectiveName;
            IsDefault = isDefault;
            IsSystem = isSystem;
            Description = description;
            Enabled = enabled;
        }

        /// <summary> The name for the service objective. </summary>
        public string ServiceObjectiveName { get; }
        /// <summary> Gets whether the service level objective is the default service objective. </summary>
        public bool? IsDefault { get; }
        /// <summary> Gets whether the service level objective is a system service objective. </summary>
        public bool? IsSystem { get; }
        /// <summary> The description for the service level objective. </summary>
        public string Description { get; }
        /// <summary> Gets whether the service level objective is enabled. </summary>
        public bool? Enabled { get; }
    }
}

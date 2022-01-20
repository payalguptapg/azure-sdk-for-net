// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains the security related information for the resource. </summary>
    public partial class DiskSecurityProfile
    {
        /// <summary> Initializes a new instance of DiskSecurityProfile. </summary>
        public DiskSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of DiskSecurityProfile. </summary>
        /// <param name="securityType"> Specifies the SecurityType of the VM. Applicable for OS disks only. </param>
        /// <param name="secureVMDiskEncryptionSetId"> ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key. </param>
        internal DiskSecurityProfile(DiskSecurityTypes? securityType, string secureVMDiskEncryptionSetId)
        {
            SecurityType = securityType;
            SecureVMDiskEncryptionSetId = secureVMDiskEncryptionSetId;
        }

        /// <summary> Specifies the SecurityType of the VM. Applicable for OS disks only. </summary>
        public DiskSecurityTypes? SecurityType { get; set; }
        /// <summary> ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key. </summary>
        public string SecureVMDiskEncryptionSetId { get; set; }
    }
}

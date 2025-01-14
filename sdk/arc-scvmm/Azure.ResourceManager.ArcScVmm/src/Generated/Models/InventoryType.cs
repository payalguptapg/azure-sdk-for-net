// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> The inventory type. </summary>
    public readonly partial struct InventoryType : IEquatable<InventoryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InventoryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InventoryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CloudValue = "Cloud";
        private const string VirtualNetworkValue = "VirtualNetwork";
        private const string VirtualMachineTemplateValue = "VirtualMachineTemplate";
        private const string VirtualMachineValue = "VirtualMachine";

        /// <summary> Cloud. </summary>
        public static InventoryType Cloud { get; } = new InventoryType(CloudValue);
        /// <summary> VirtualNetwork. </summary>
        public static InventoryType VirtualNetwork { get; } = new InventoryType(VirtualNetworkValue);
        /// <summary> VirtualMachineTemplate. </summary>
        public static InventoryType VirtualMachineTemplate { get; } = new InventoryType(VirtualMachineTemplateValue);
        /// <summary> VirtualMachine. </summary>
        public static InventoryType VirtualMachine { get; } = new InventoryType(VirtualMachineValue);
        /// <summary> Determines if two <see cref="InventoryType"/> values are the same. </summary>
        public static bool operator ==(InventoryType left, InventoryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InventoryType"/> values are not the same. </summary>
        public static bool operator !=(InventoryType left, InventoryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InventoryType"/>. </summary>
        public static implicit operator InventoryType(string value) => new InventoryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InventoryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InventoryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Strictly used in update requests. </summary>
    public partial class PartialMinimalTrackedResourceWithIdentity : PartialMinimalTrackedResource
    {
        /// <summary> Initializes a new instance of PartialMinimalTrackedResourceWithIdentity. </summary>
        public PartialMinimalTrackedResourceWithIdentity()
        {
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public PartialManagedServiceIdentity Identity { get; set; }
    }
}

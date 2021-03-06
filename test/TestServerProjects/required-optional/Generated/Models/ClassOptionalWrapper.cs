// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace required_optional.Models
{
    /// <summary> The ClassOptionalWrapper. </summary>
    public partial class ClassOptionalWrapper
    {
        /// <summary> Initializes a new instance of ClassOptionalWrapper. </summary>
        public ClassOptionalWrapper()
        {
        }

        /// <summary> Initializes a new instance of ClassOptionalWrapper. </summary>
        /// <param name="value"> . </param>
        internal ClassOptionalWrapper(Product value)
        {
            Value = value;
        }

        public Product Value { get; set; }
    }
}

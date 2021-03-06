// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// Defines methods to support the comparison of objects of type Address for equality.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.62.0.0")]
    internal sealed class AddressEqualityComparer : IEqualityComparer<Address>
    {
        internal static readonly AddressEqualityComparer Instance = new AddressEqualityComparer();

        public bool Equals(Address left, Address right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            if (left.BaseAddress != right.BaseAddress)
            {
                return false;
            }

            if (left.Kind != right.Kind)
            {
                return false;
            }

            if (left.Name != right.Name)
            {
                return false;
            }

            if (left.Offset != right.Offset)
            {
                return false;
            }

            if (left.Index != right.Index)
            {
                return false;
            }

            if (left.ParentIndex != right.ParentIndex)
            {
                return false;
            }

            return true;
        }

        public int GetHashCode(Address obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return 0;
            }

            int result = 17;
            unchecked
            {
                result = (result * 31) + obj.BaseAddress.GetHashCode();
                if (obj.Kind != null)
                {
                    result = (result * 31) + obj.Kind.GetHashCode();
                }

                if (obj.Name != null)
                {
                    result = (result * 31) + obj.Name.GetHashCode();
                }

                result = (result * 31) + obj.Offset.GetHashCode();
                result = (result * 31) + obj.Index.GetHashCode();
                result = (result * 31) + obj.ParentIndex.GetHashCode();
            }

            return result;
        }
    }
}
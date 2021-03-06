// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Sarif.Readers;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// Defines methods to support the comparison of objects of type ExternalPropertyFiles for equality.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.62.0.0")]
    internal sealed class ExternalPropertyFilesEqualityComparer : IEqualityComparer<ExternalPropertyFiles>
    {
        internal static readonly ExternalPropertyFilesEqualityComparer Instance = new ExternalPropertyFilesEqualityComparer();

        public bool Equals(ExternalPropertyFiles left, ExternalPropertyFiles right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            if (!ExternalPropertyFile.ValueComparer.Equals(left.Conversion, right.Conversion))
            {
                return false;
            }

            if (!ExternalPropertyFile.ValueComparer.Equals(left.Graphs, right.Graphs))
            {
                return false;
            }

            if (!ExternalPropertyFile.ValueComparer.Equals(left.ExternalizedProperties, right.ExternalizedProperties))
            {
                return false;
            }

            if (!object.ReferenceEquals(left.Artifacts, right.Artifacts))
            {
                if (left.Artifacts == null || right.Artifacts == null)
                {
                    return false;
                }

                if (left.Artifacts.Count != right.Artifacts.Count)
                {
                    return false;
                }

                for (int index_0 = 0; index_0 < left.Artifacts.Count; ++index_0)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.Artifacts[index_0], right.Artifacts[index_0]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.Invocations, right.Invocations))
            {
                if (left.Invocations == null || right.Invocations == null)
                {
                    return false;
                }

                if (left.Invocations.Count != right.Invocations.Count)
                {
                    return false;
                }

                for (int index_1 = 0; index_1 < left.Invocations.Count; ++index_1)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.Invocations[index_1], right.Invocations[index_1]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.LogicalLocations, right.LogicalLocations))
            {
                if (left.LogicalLocations == null || right.LogicalLocations == null)
                {
                    return false;
                }

                if (left.LogicalLocations.Count != right.LogicalLocations.Count)
                {
                    return false;
                }

                for (int index_2 = 0; index_2 < left.LogicalLocations.Count; ++index_2)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.LogicalLocations[index_2], right.LogicalLocations[index_2]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.ThreadFlowLocations, right.ThreadFlowLocations))
            {
                if (left.ThreadFlowLocations == null || right.ThreadFlowLocations == null)
                {
                    return false;
                }

                if (left.ThreadFlowLocations.Count != right.ThreadFlowLocations.Count)
                {
                    return false;
                }

                for (int index_3 = 0; index_3 < left.ThreadFlowLocations.Count; ++index_3)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.ThreadFlowLocations[index_3], right.ThreadFlowLocations[index_3]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.Results, right.Results))
            {
                if (left.Results == null || right.Results == null)
                {
                    return false;
                }

                if (left.Results.Count != right.Results.Count)
                {
                    return false;
                }

                for (int index_4 = 0; index_4 < left.Results.Count; ++index_4)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.Results[index_4], right.Results[index_4]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.Taxonomies, right.Taxonomies))
            {
                if (left.Taxonomies == null || right.Taxonomies == null)
                {
                    return false;
                }

                if (left.Taxonomies.Count != right.Taxonomies.Count)
                {
                    return false;
                }

                for (int index_5 = 0; index_5 < left.Taxonomies.Count; ++index_5)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.Taxonomies[index_5], right.Taxonomies[index_5]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.Addresses, right.Addresses))
            {
                if (left.Addresses == null || right.Addresses == null)
                {
                    return false;
                }

                if (left.Addresses.Count != right.Addresses.Count)
                {
                    return false;
                }

                for (int index_6 = 0; index_6 < left.Addresses.Count; ++index_6)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.Addresses[index_6], right.Addresses[index_6]))
                    {
                        return false;
                    }
                }
            }

            if (!ExternalPropertyFile.ValueComparer.Equals(left.Driver, right.Driver))
            {
                return false;
            }

            if (!object.ReferenceEquals(left.Extensions, right.Extensions))
            {
                if (left.Extensions == null || right.Extensions == null)
                {
                    return false;
                }

                if (left.Extensions.Count != right.Extensions.Count)
                {
                    return false;
                }

                for (int index_7 = 0; index_7 < left.Extensions.Count; ++index_7)
                {
                    if (!ExternalPropertyFile.ValueComparer.Equals(left.Extensions[index_7], right.Extensions[index_7]))
                    {
                        return false;
                    }
                }
            }

            if (!object.ReferenceEquals(left.Properties, right.Properties))
            {
                if (left.Properties == null || right.Properties == null || left.Properties.Count != right.Properties.Count)
                {
                    return false;
                }

                foreach (var value_0 in left.Properties)
                {
                    SerializedPropertyInfo value_1;
                    if (!right.Properties.TryGetValue(value_0.Key, out value_1))
                    {
                        return false;
                    }

                    if (!object.Equals(value_0.Value, value_1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetHashCode(ExternalPropertyFiles obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return 0;
            }

            int result = 17;
            unchecked
            {
                if (obj.Conversion != null)
                {
                    result = (result * 31) + obj.Conversion.ValueGetHashCode();
                }

                if (obj.Graphs != null)
                {
                    result = (result * 31) + obj.Graphs.ValueGetHashCode();
                }

                if (obj.ExternalizedProperties != null)
                {
                    result = (result * 31) + obj.ExternalizedProperties.ValueGetHashCode();
                }

                if (obj.Artifacts != null)
                {
                    foreach (var value_2 in obj.Artifacts)
                    {
                        result = result * 31;
                        if (value_2 != null)
                        {
                            result = (result * 31) + value_2.ValueGetHashCode();
                        }
                    }
                }

                if (obj.Invocations != null)
                {
                    foreach (var value_3 in obj.Invocations)
                    {
                        result = result * 31;
                        if (value_3 != null)
                        {
                            result = (result * 31) + value_3.ValueGetHashCode();
                        }
                    }
                }

                if (obj.LogicalLocations != null)
                {
                    foreach (var value_4 in obj.LogicalLocations)
                    {
                        result = result * 31;
                        if (value_4 != null)
                        {
                            result = (result * 31) + value_4.ValueGetHashCode();
                        }
                    }
                }

                if (obj.ThreadFlowLocations != null)
                {
                    foreach (var value_5 in obj.ThreadFlowLocations)
                    {
                        result = result * 31;
                        if (value_5 != null)
                        {
                            result = (result * 31) + value_5.ValueGetHashCode();
                        }
                    }
                }

                if (obj.Results != null)
                {
                    foreach (var value_6 in obj.Results)
                    {
                        result = result * 31;
                        if (value_6 != null)
                        {
                            result = (result * 31) + value_6.ValueGetHashCode();
                        }
                    }
                }

                if (obj.Taxonomies != null)
                {
                    foreach (var value_7 in obj.Taxonomies)
                    {
                        result = result * 31;
                        if (value_7 != null)
                        {
                            result = (result * 31) + value_7.ValueGetHashCode();
                        }
                    }
                }

                if (obj.Addresses != null)
                {
                    foreach (var value_8 in obj.Addresses)
                    {
                        result = result * 31;
                        if (value_8 != null)
                        {
                            result = (result * 31) + value_8.ValueGetHashCode();
                        }
                    }
                }

                if (obj.Driver != null)
                {
                    result = (result * 31) + obj.Driver.ValueGetHashCode();
                }

                if (obj.Extensions != null)
                {
                    foreach (var value_9 in obj.Extensions)
                    {
                        result = result * 31;
                        if (value_9 != null)
                        {
                            result = (result * 31) + value_9.ValueGetHashCode();
                        }
                    }
                }

                if (obj.Properties != null)
                {
                    // Use xor for dictionaries to be order-independent.
                    int xor_0 = 0;
                    foreach (var value_10 in obj.Properties)
                    {
                        xor_0 ^= value_10.Key.GetHashCode();
                        if (value_10.Value != null)
                        {
                            xor_0 ^= value_10.Value.GetHashCode();
                        }
                    }

                    result = (result * 31) + xor_0;
                }
            }

            return result;
        }
    }
}
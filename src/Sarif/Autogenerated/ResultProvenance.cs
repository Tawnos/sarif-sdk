// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.Sarif.Readers;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// Contains information about how and when a result was detected.
    /// </summary>
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.58.0.0")]
    public partial class ResultProvenance : PropertyBagHolder, ISarifNode
    {
        public static IEqualityComparer<ResultProvenance> ValueComparer => ResultProvenanceEqualityComparer.Instance;

        public bool ValueEquals(ResultProvenance other) => ValueComparer.Equals(this, other);
        public int ValueGetHashCode() => ValueComparer.GetHashCode(this);

        /// <summary>
        /// Gets a value indicating the type of object implementing <see cref="ISarifNode" />.
        /// </summary>
        public SarifNodeKind SarifNodeKind
        {
            get
            {
                return SarifNodeKind.ResultProvenance;
            }
        }

        /// <summary>
        /// The Coordinated Universal Time (UTC) date and time at which the result was first detected. See "Date/time properties" in the SARIF spec for the required format.
        /// </summary>
        [DataMember(Name = "firstDetectionTimeUtc", IsRequired = false, EmitDefaultValue = false)]
        public DateTime FirstDetectionTimeUtc { get; set; }

        /// <summary>
        /// The Coordinated Universal Time (UTC) date and time at which the result was most recently detected. See "Date/time properties" in the SARIF spec for the required format.
        /// </summary>
        [DataMember(Name = "lastDetectionTimeUtc", IsRequired = false, EmitDefaultValue = false)]
        public DateTime LastDetectionTimeUtc { get; set; }

        /// <summary>
        /// A GUID-valued string equal to the id.instanceGuid property of the run in which the result was first detected.
        /// </summary>
        [DataMember(Name = "firstDetectionRunInstanceGuid", IsRequired = false, EmitDefaultValue = false)]
        public string FirstDetectionRunInstanceGuid { get; set; }

        /// <summary>
        /// A GUID-valued string equal to the id.instanceGuid property of the run in which the result was most recently detected.
        /// </summary>
        [DataMember(Name = "lastDetectionRunInstanceGuid", IsRequired = false, EmitDefaultValue = false)]
        public string LastDetectionRunInstanceGuid { get; set; }

        /// <summary>
        /// The index within the run.invocations array of the invocation object which describes the tool invocation that detected the result.
        /// </summary>
        [DataMember(Name = "invocationIndex", IsRequired = false, EmitDefaultValue = false)]
        public int InvocationIndex { get; set; }

        /// <summary>
        /// An array of physicalLocation objects which specify the portions of an analysis tool's output that a converter transformed into the result.
        /// </summary>
        [DataMember(Name = "conversionSources", IsRequired = false, EmitDefaultValue = false)]
        public IList<PhysicalLocation> ConversionSources { get; set; }

        /// <summary>
        /// Key/value pairs that provide additional information about the result.
        /// </summary>
        [DataMember(Name = "properties", IsRequired = false, EmitDefaultValue = false)]
        internal override IDictionary<string, SerializedPropertyInfo> Properties { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultProvenance" /> class.
        /// </summary>
        public ResultProvenance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultProvenance" /> class from the supplied values.
        /// </summary>
        /// <param name="firstDetectionTimeUtc">
        /// An initialization value for the <see cref="P: FirstDetectionTimeUtc" /> property.
        /// </param>
        /// <param name="lastDetectionTimeUtc">
        /// An initialization value for the <see cref="P: LastDetectionTimeUtc" /> property.
        /// </param>
        /// <param name="firstDetectionRunInstanceGuid">
        /// An initialization value for the <see cref="P: FirstDetectionRunInstanceGuid" /> property.
        /// </param>
        /// <param name="lastDetectionRunInstanceGuid">
        /// An initialization value for the <see cref="P: LastDetectionRunInstanceGuid" /> property.
        /// </param>
        /// <param name="invocationIndex">
        /// An initialization value for the <see cref="P: InvocationIndex" /> property.
        /// </param>
        /// <param name="conversionSources">
        /// An initialization value for the <see cref="P: ConversionSources" /> property.
        /// </param>
        /// <param name="properties">
        /// An initialization value for the <see cref="P: Properties" /> property.
        /// </param>
        public ResultProvenance(DateTime firstDetectionTimeUtc, DateTime lastDetectionTimeUtc, string firstDetectionRunInstanceGuid, string lastDetectionRunInstanceGuid, int invocationIndex, IEnumerable<PhysicalLocation> conversionSources, IDictionary<string, SerializedPropertyInfo> properties)
        {
            Init(firstDetectionTimeUtc, lastDetectionTimeUtc, firstDetectionRunInstanceGuid, lastDetectionRunInstanceGuid, invocationIndex, conversionSources, properties);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultProvenance" /> class from the specified instance.
        /// </summary>
        /// <param name="other">
        /// The instance from which the new instance is to be initialized.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other" /> is null.
        /// </exception>
        public ResultProvenance(ResultProvenance other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            Init(other.FirstDetectionTimeUtc, other.LastDetectionTimeUtc, other.FirstDetectionRunInstanceGuid, other.LastDetectionRunInstanceGuid, other.InvocationIndex, other.ConversionSources, other.Properties);
        }

        ISarifNode ISarifNode.DeepClone()
        {
            return DeepCloneCore();
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        public ResultProvenance DeepClone()
        {
            return (ResultProvenance)DeepCloneCore();
        }

        private ISarifNode DeepCloneCore()
        {
            return new ResultProvenance(this);
        }

        private void Init(DateTime firstDetectionTimeUtc, DateTime lastDetectionTimeUtc, string firstDetectionRunInstanceGuid, string lastDetectionRunInstanceGuid, int invocationIndex, IEnumerable<PhysicalLocation> conversionSources, IDictionary<string, SerializedPropertyInfo> properties)
        {
            FirstDetectionTimeUtc = firstDetectionTimeUtc;
            LastDetectionTimeUtc = lastDetectionTimeUtc;
            FirstDetectionRunInstanceGuid = firstDetectionRunInstanceGuid;
            LastDetectionRunInstanceGuid = lastDetectionRunInstanceGuid;
            InvocationIndex = invocationIndex;
            if (conversionSources != null)
            {
                var destination_0 = new List<PhysicalLocation>();
                foreach (var value_0 in conversionSources)
                {
                    if (value_0 == null)
                    {
                        destination_0.Add(null);
                    }
                    else
                    {
                        destination_0.Add(new PhysicalLocation(value_0));
                    }
                }

                ConversionSources = destination_0;
            }

            if (properties != null)
            {
                Properties = new Dictionary<string, SerializedPropertyInfo>(properties);
            }
        }
    }
}
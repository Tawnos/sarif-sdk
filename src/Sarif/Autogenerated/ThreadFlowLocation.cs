// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.Sarif.Readers;
using Newtonsoft.Json;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// A location visited by an analysis tool while simulating or monitoring the execution of a program.
    /// </summary>
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.62.0.0")]
    public partial class ThreadFlowLocation : PropertyBagHolder, ISarifNode
    {
        public static IEqualityComparer<ThreadFlowLocation> ValueComparer => ThreadFlowLocationEqualityComparer.Instance;

        public bool ValueEquals(ThreadFlowLocation other) => ValueComparer.Equals(this, other);
        public int ValueGetHashCode() => ValueComparer.GetHashCode(this);

        /// <summary>
        /// Gets a value indicating the type of object implementing <see cref="ISarifNode" />.
        /// </summary>
        public SarifNodeKind SarifNodeKind
        {
            get
            {
                return SarifNodeKind.ThreadFlowLocation;
            }
        }

        /// <summary>
        /// The index within the run threadFlowLocations array.
        /// </summary>
        [DataMember(Name = "index", IsRequired = false, EmitDefaultValue = false)]
        [DefaultValue(-1)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int Index { get; set; }

        /// <summary>
        /// The code location.
        /// </summary>
        [DataMember(Name = "location", IsRequired = false, EmitDefaultValue = false)]
        public Location Location { get; set; }

        /// <summary>
        /// The call stack leading to this location.
        /// </summary>
        [DataMember(Name = "stack", IsRequired = false, EmitDefaultValue = false)]
        public Stack Stack { get; set; }

        /// <summary>
        /// A set of distinct strings that categorize the thread flow location. Well-known kinds include acquire, release, enter, exit, call, return, branch, implicit, false, true, caution, danger, unknown, unreachable, taint, function, handler, lock, memory, resource, and scope.
        /// </summary>
        [DataMember(Name = "kinds", IsRequired = false, EmitDefaultValue = false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public IList<string> Kinds { get; set; }

        /// <summary>
        /// The name of the module that contains the code that is executing.
        /// </summary>
        [DataMember(Name = "module", IsRequired = false, EmitDefaultValue = false)]
        public string Module { get; set; }

        /// <summary>
        /// A dictionary, each of whose keys specifies a variable or expression, the associated value of which represents the variable or expression value. For an annotation of kind 'continuation', for example, this dictionary might hold the current assumed values of a set of global variables.
        /// </summary>
        [DataMember(Name = "state", IsRequired = false, EmitDefaultValue = false)]
        public IDictionary<string, string> State { get; set; }

        /// <summary>
        /// An integer representing a containment hierarchy within the thread flow.
        /// </summary>
        [DataMember(Name = "nestingLevel", IsRequired = false, EmitDefaultValue = false)]
        public int NestingLevel { get; set; }

        /// <summary>
        /// An integer representing the temporal order in which execution reached this location.
        /// </summary>
        [DataMember(Name = "executionOrder", IsRequired = false, EmitDefaultValue = false)]
        public int ExecutionOrder { get; set; }

        /// <summary>
        /// The Coordinated Universal Time (UTC) date and time at which this location was executed.
        /// </summary>
        [DataMember(Name = "executionTimeUtc", IsRequired = false, EmitDefaultValue = false)]
        public DateTime ExecutionTimeUtc { get; set; }

        /// <summary>
        /// Specifies the importance of this location in understanding the code flow in which it occurs. The order from most to least important is "essential", "important", "unimportant". Default: "important".
        /// </summary>
        [DataMember(Name = "importance", IsRequired = false, EmitDefaultValue = false)]
        [JsonConverter(typeof(Microsoft.CodeAnalysis.Sarif.Readers.EnumConverter))]
        public ThreadFlowLocationImportance Importance { get; set; }

        /// <summary>
        /// Key/value pairs that provide additional information about the threadflow location.
        /// </summary>
        [DataMember(Name = "properties", IsRequired = false, EmitDefaultValue = false)]
        internal override IDictionary<string, SerializedPropertyInfo> Properties { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadFlowLocation" /> class.
        /// </summary>
        public ThreadFlowLocation()
        {
            Index = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadFlowLocation" /> class from the supplied values.
        /// </summary>
        /// <param name="index">
        /// An initialization value for the <see cref="P:Index" /> property.
        /// </param>
        /// <param name="location">
        /// An initialization value for the <see cref="P:Location" /> property.
        /// </param>
        /// <param name="stack">
        /// An initialization value for the <see cref="P:Stack" /> property.
        /// </param>
        /// <param name="kinds">
        /// An initialization value for the <see cref="P:Kinds" /> property.
        /// </param>
        /// <param name="module">
        /// An initialization value for the <see cref="P:Module" /> property.
        /// </param>
        /// <param name="state">
        /// An initialization value for the <see cref="P:State" /> property.
        /// </param>
        /// <param name="nestingLevel">
        /// An initialization value for the <see cref="P:NestingLevel" /> property.
        /// </param>
        /// <param name="executionOrder">
        /// An initialization value for the <see cref="P:ExecutionOrder" /> property.
        /// </param>
        /// <param name="executionTimeUtc">
        /// An initialization value for the <see cref="P:ExecutionTimeUtc" /> property.
        /// </param>
        /// <param name="importance">
        /// An initialization value for the <see cref="P:Importance" /> property.
        /// </param>
        /// <param name="properties">
        /// An initialization value for the <see cref="P:Properties" /> property.
        /// </param>
        public ThreadFlowLocation(int index, Location location, Stack stack, IEnumerable<string> kinds, string module, IDictionary<string, string> state, int nestingLevel, int executionOrder, DateTime executionTimeUtc, ThreadFlowLocationImportance importance, IDictionary<string, SerializedPropertyInfo> properties)
        {
            Init(index, location, stack, kinds, module, state, nestingLevel, executionOrder, executionTimeUtc, importance, properties);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadFlowLocation" /> class from the specified instance.
        /// </summary>
        /// <param name="other">
        /// The instance from which the new instance is to be initialized.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other" /> is null.
        /// </exception>
        public ThreadFlowLocation(ThreadFlowLocation other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            Init(other.Index, other.Location, other.Stack, other.Kinds, other.Module, other.State, other.NestingLevel, other.ExecutionOrder, other.ExecutionTimeUtc, other.Importance, other.Properties);
        }

        ISarifNode ISarifNode.DeepClone()
        {
            return DeepCloneCore();
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        public ThreadFlowLocation DeepClone()
        {
            return (ThreadFlowLocation)DeepCloneCore();
        }

        private ISarifNode DeepCloneCore()
        {
            return new ThreadFlowLocation(this);
        }

        private void Init(int index, Location location, Stack stack, IEnumerable<string> kinds, string module, IDictionary<string, string> state, int nestingLevel, int executionOrder, DateTime executionTimeUtc, ThreadFlowLocationImportance importance, IDictionary<string, SerializedPropertyInfo> properties)
        {
            Index = index;
            if (location != null)
            {
                Location = new Location(location);
            }

            if (stack != null)
            {
                Stack = new Stack(stack);
            }

            if (kinds != null)
            {
                var destination_0 = new List<string>();
                foreach (var value_0 in kinds)
                {
                    destination_0.Add(value_0);
                }

                Kinds = destination_0;
            }

            Module = module;
            if (state != null)
            {
                State = new Dictionary<string, string>(state);
            }

            NestingLevel = nestingLevel;
            ExecutionOrder = executionOrder;
            ExecutionTimeUtc = executionTimeUtc;
            Importance = importance;
            if (properties != null)
            {
                Properties = new Dictionary<string, SerializedPropertyInfo>(properties);
            }
        }
    }
}
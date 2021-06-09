
using System.Diagnostics.CodeAnalysis;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// Summary
    /// </summary>
    [DataContract]
    public sealed class Summary :  IEquatable<Summary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Summary" /> class.
        /// </summary>
        /// <param name="firstRecIdField">firstRecIdField.</param>
        /// <param name="groupSummaries">groupSummaries.</param>
        /// <param name="recIdFields">recIdFields.</param>
        /// <param name="stateFieldId">stateFieldId.</param>
        /// <param name="states">states.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="group">group.</param>
        /// <param name="lookup">lookup.</param>
        /// <param name="major">major.</param>
        /// <param name="name">name.</param>
        /// <param name="supporting">supporting.</param>
        public Summary(string firstRecIdField = default, List<Summary> groupSummaries = default, string recIdFields = default, string stateFieldId = default, string states = default, string busObId = default, string displayName = default, bool? group = default, bool? lookup = default, bool? major = default, string name = default, bool? supporting = default)
        {
            FirstRecIdField = firstRecIdField;
            GroupSummaries = groupSummaries;
            RecIdFields = recIdFields;
            StateFieldId = stateFieldId;
            States = states;
            BusObId = busObId;
            DisplayName = displayName;
            Group = group;
            Lookup = lookup;
            Major = major;
            Name = name;
            Supporting = supporting;
        }
        
        /// <summary>
        /// Gets or Sets FirstRecIdField
        /// </summary>
        [DataMember(Name="firstRecIdField", EmitDefaultValue=false)]
        public string FirstRecIdField { get; set; }

        /// <summary>
        /// Gets or Sets GroupSummaries
        /// </summary>
        [DataMember(Name="groupSummaries", EmitDefaultValue=false)]
        public List<Summary> GroupSummaries { get; set; }

        /// <summary>
        /// Gets or Sets RecIdFields
        /// </summary>
        [DataMember(Name="recIdFields", EmitDefaultValue=false)]
        public string RecIdFields { get; set; }

        /// <summary>
        /// Gets or Sets StateFieldId
        /// </summary>
        [DataMember(Name="stateFieldId", EmitDefaultValue=false)]
        public string StateFieldId { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public string States { get; set; }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public bool? Group { get; set; }

        /// <summary>
        /// Gets or Sets Lookup
        /// </summary>
        [DataMember(Name="lookup", EmitDefaultValue=false)]
        public bool? Lookup { get; set; }

        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name="major", EmitDefaultValue=false)]
        public bool? Major { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Supporting
        /// </summary>
        [DataMember(Name="supporting", EmitDefaultValue=false)]
        public bool? Supporting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Summary {\n");
            sb.Append("  FirstRecIdField: ").Append(FirstRecIdField).Append("\n");
            sb.Append("  GroupSummaries: ").Append(GroupSummaries).Append("\n");
            sb.Append("  RecIdFields: ").Append(RecIdFields).Append("\n");
            sb.Append("  StateFieldId: ").Append(StateFieldId).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Lookup: ").Append(Lookup).Append("\n");
            sb.Append("  Major: ").Append(Major).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Supporting: ").Append(Supporting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Summary);
        }

        /// <summary>
        /// Returns true if Summary instances are equal
        /// </summary>
        /// <param name="input">Instance of Summary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Summary input)
        {
            if (input == null)
                return false;

            return 
                (
                    FirstRecIdField == input.FirstRecIdField ||
                    (FirstRecIdField != null &&
                    FirstRecIdField.Equals(input.FirstRecIdField))
                ) && 
                (
                    GroupSummaries == input.GroupSummaries ||
                    GroupSummaries != null &&
                    GroupSummaries.SequenceEqual(input.GroupSummaries)
                ) && 
                (
                    RecIdFields == input.RecIdFields ||
                    (RecIdFields != null &&
                    RecIdFields.Equals(input.RecIdFields))
                ) && 
                (
                    StateFieldId == input.StateFieldId ||
                    (StateFieldId != null &&
                    StateFieldId.Equals(input.StateFieldId))
                ) && 
                (
                    States == input.States ||
                    (States != null &&
                    States.Equals(input.States))
                ) && 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    Group == input.Group ||
                    (Group != null &&
                    Group.Equals(input.Group))
                ) && 
                (
                    Lookup == input.Lookup ||
                    (Lookup != null &&
                    Lookup.Equals(input.Lookup))
                ) && 
                (
                    Major == input.Major ||
                    (Major != null &&
                    Major.Equals(input.Major))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Supporting == input.Supporting ||
                    (Supporting != null &&
                    Supporting.Equals(input.Supporting))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (FirstRecIdField != null)
                    hashCode = hashCode * 59 + FirstRecIdField.GetHashCode();
                if (GroupSummaries != null)
                    hashCode = hashCode * 59 + GroupSummaries.GetHashCode();
                if (RecIdFields != null)
                    hashCode = hashCode * 59 + RecIdFields.GetHashCode();
                if (StateFieldId != null)
                    hashCode = hashCode * 59 + StateFieldId.GetHashCode();
                if (States != null)
                    hashCode = hashCode * 59 + States.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (Group != null)
                    hashCode = hashCode * 59 + Group.GetHashCode();
                if (Lookup != null)
                    hashCode = hashCode * 59 + Lookup.GetHashCode();
                if (Major != null)
                    hashCode = hashCode * 59 + Major.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Supporting != null)
                    hashCode = hashCode * 59 + Supporting.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

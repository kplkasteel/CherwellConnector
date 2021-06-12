
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
    /// BusinessObjectPermission
    /// </summary>
    [DataContract]
    public sealed class BusinessObjectPermission :  IEquatable<BusinessObjectPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectPermission" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObName">busObName.</param>
        /// <param name="departmentMemberEdit">departmentMemberEdit.</param>
        /// <param name="departmentMemberView">departmentMemberView.</param>
        /// <param name="edit">edit.</param>
        /// <param name="fieldPermissions">fieldPermissions.</param>
        /// <param name="managerOfOwnerEdit">managerOfOwnerEdit.</param>
        /// <param name="managerOfOwnerView">managerOfOwnerView.</param>
        /// <param name="ownerEdit">ownerEdit.</param>
        /// <param name="ownerView">ownerView.</param>
        /// <param name="teamEdit">teamEdit.</param>
        /// <param name="teamManagerOfOwnerEdit">teamManagerOfOwnerEdit.</param>
        /// <param name="teamManagerOfOwnerView">teamManagerOfOwnerView.</param>
        /// <param name="teamView">teamView.</param>
        /// <param name="view">view.</param>
        public BusinessObjectPermission(string busObId = default, string busObName = default, bool? departmentMemberEdit = default, bool? departmentMemberView = default, bool? edit = default, List<FieldPermission> fieldPermissions = default, bool? managerOfOwnerEdit = default, bool? managerOfOwnerView = default, bool? ownerEdit = default, bool? ownerView = default, bool? teamEdit = default, bool? teamManagerOfOwnerEdit = default, bool? teamManagerOfOwnerView = default, bool? teamView = default, bool? view = default)
        {
            BusObId = busObId;
            BusObName = busObName;
            DepartmentMemberEdit = departmentMemberEdit;
            DepartmentMemberView = departmentMemberView;
            Edit = edit;
            FieldPermissions = fieldPermissions;
            ManagerOfOwnerEdit = managerOfOwnerEdit;
            ManagerOfOwnerView = managerOfOwnerView;
            OwnerEdit = ownerEdit;
            OwnerView = ownerView;
            TeamEdit = teamEdit;
            TeamManagerOfOwnerEdit = teamManagerOfOwnerEdit;
            TeamManagerOfOwnerView = teamManagerOfOwnerView;
            TeamView = teamView;
            View = view;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObName
        /// </summary>
        [DataMember(Name="busObName", EmitDefaultValue=false)]
        public string BusObName { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentMemberEdit
        /// </summary>
        [DataMember(Name="departmentMemberEdit", EmitDefaultValue=false)]
        public bool? DepartmentMemberEdit { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentMemberView
        /// </summary>
        [DataMember(Name="departmentMemberView", EmitDefaultValue=false)]
        public bool? DepartmentMemberView { get; set; }

        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name="edit", EmitDefaultValue=false)]
        public bool? Edit { get; set; }

        /// <summary>
        /// Gets or Sets FieldPermissions
        /// </summary>
        [DataMember(Name="fieldPermissions", EmitDefaultValue=false)]
        public List<FieldPermission> FieldPermissions { get; set; }

        /// <summary>
        /// Gets or Sets ManagerOfOwnerEdit
        /// </summary>
        [DataMember(Name="managerOfOwnerEdit", EmitDefaultValue=false)]
        public bool? ManagerOfOwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets ManagerOfOwnerView
        /// </summary>
        [DataMember(Name="managerOfOwnerView", EmitDefaultValue=false)]
        public bool? ManagerOfOwnerView { get; set; }

        /// <summary>
        /// Gets or Sets OwnerEdit
        /// </summary>
        [DataMember(Name="ownerEdit", EmitDefaultValue=false)]
        public bool? OwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets OwnerView
        /// </summary>
        [DataMember(Name="ownerView", EmitDefaultValue=false)]
        public bool? OwnerView { get; set; }

        /// <summary>
        /// Gets or Sets TeamEdit
        /// </summary>
        [DataMember(Name="teamEdit", EmitDefaultValue=false)]
        public bool? TeamEdit { get; set; }

        /// <summary>
        /// Gets or Sets TeamManagerOfOwnerEdit
        /// </summary>
        [DataMember(Name="teamManagerOfOwnerEdit", EmitDefaultValue=false)]
        public bool? TeamManagerOfOwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets TeamManagerOfOwnerView
        /// </summary>
        [DataMember(Name="teamManagerOfOwnerView", EmitDefaultValue=false)]
        public bool? TeamManagerOfOwnerView { get; set; }

        /// <summary>
        /// Gets or Sets TeamView
        /// </summary>
        [DataMember(Name="teamView", EmitDefaultValue=false)]
        public bool? TeamView { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public bool? View { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectPermission {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
            sb.Append("  DepartmentMemberEdit: ").Append(DepartmentMemberEdit).Append("\n");
            sb.Append("  DepartmentMemberView: ").Append(DepartmentMemberView).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  FieldPermissions: ").Append(FieldPermissions).Append("\n");
            sb.Append("  ManagerOfOwnerEdit: ").Append(ManagerOfOwnerEdit).Append("\n");
            sb.Append("  ManagerOfOwnerView: ").Append(ManagerOfOwnerView).Append("\n");
            sb.Append("  OwnerEdit: ").Append(OwnerEdit).Append("\n");
            sb.Append("  OwnerView: ").Append(OwnerView).Append("\n");
            sb.Append("  TeamEdit: ").Append(TeamEdit).Append("\n");
            sb.Append("  TeamManagerOfOwnerEdit: ").Append(TeamManagerOfOwnerEdit).Append("\n");
            sb.Append("  TeamManagerOfOwnerView: ").Append(TeamManagerOfOwnerView).Append("\n");
            sb.Append("  TeamView: ").Append(TeamView).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  string ToJson()
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
            return Equals(input as BusinessObjectPermission);
        }

        /// <summary>
        /// Returns true if BusinessObjectPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessObjectPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectPermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    BusObName == input.BusObName ||
                    (BusObName != null &&
                    BusObName.Equals(input.BusObName))
                ) && 
                (
                    DepartmentMemberEdit == input.DepartmentMemberEdit ||
                    (DepartmentMemberEdit != null &&
                    DepartmentMemberEdit.Equals(input.DepartmentMemberEdit))
                ) && 
                (
                    DepartmentMemberView == input.DepartmentMemberView ||
                    (DepartmentMemberView != null &&
                    DepartmentMemberView.Equals(input.DepartmentMemberView))
                ) && 
                (
                    Edit == input.Edit ||
                    (Edit != null &&
                    Edit.Equals(input.Edit))
                ) && 
                (
                    FieldPermissions == input.FieldPermissions ||
                    FieldPermissions != null &&
                    FieldPermissions.SequenceEqual(input.FieldPermissions)
                ) && 
                (
                    ManagerOfOwnerEdit == input.ManagerOfOwnerEdit ||
                    (ManagerOfOwnerEdit != null &&
                    ManagerOfOwnerEdit.Equals(input.ManagerOfOwnerEdit))
                ) && 
                (
                    ManagerOfOwnerView == input.ManagerOfOwnerView ||
                    (ManagerOfOwnerView != null &&
                    ManagerOfOwnerView.Equals(input.ManagerOfOwnerView))
                ) && 
                (
                    OwnerEdit == input.OwnerEdit ||
                    (OwnerEdit != null &&
                    OwnerEdit.Equals(input.OwnerEdit))
                ) && 
                (
                    OwnerView == input.OwnerView ||
                    (OwnerView != null &&
                    OwnerView.Equals(input.OwnerView))
                ) && 
                (
                    TeamEdit == input.TeamEdit ||
                    (TeamEdit != null &&
                    TeamEdit.Equals(input.TeamEdit))
                ) && 
                (
                    TeamManagerOfOwnerEdit == input.TeamManagerOfOwnerEdit ||
                    (TeamManagerOfOwnerEdit != null &&
                    TeamManagerOfOwnerEdit.Equals(input.TeamManagerOfOwnerEdit))
                ) && 
                (
                    TeamManagerOfOwnerView == input.TeamManagerOfOwnerView ||
                    (TeamManagerOfOwnerView != null &&
                    TeamManagerOfOwnerView.Equals(input.TeamManagerOfOwnerView))
                ) && 
                (
                    TeamView == input.TeamView ||
                    (TeamView != null &&
                    TeamView.Equals(input.TeamView))
                ) && 
                (
                    View == input.View ||
                    (View != null &&
                    View.Equals(input.View))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObName != null)
                    hashCode = hashCode * 59 + BusObName.GetHashCode();
                if (DepartmentMemberEdit != null)
                    hashCode = hashCode * 59 + DepartmentMemberEdit.GetHashCode();
                if (DepartmentMemberView != null)
                    hashCode = hashCode * 59 + DepartmentMemberView.GetHashCode();
                if (Edit != null)
                    hashCode = hashCode * 59 + Edit.GetHashCode();
                if (FieldPermissions != null)
                    hashCode = hashCode * 59 + FieldPermissions.GetHashCode();
                if (ManagerOfOwnerEdit != null)
                    hashCode = hashCode * 59 + ManagerOfOwnerEdit.GetHashCode();
                if (ManagerOfOwnerView != null)
                    hashCode = hashCode * 59 + ManagerOfOwnerView.GetHashCode();
                if (OwnerEdit != null)
                    hashCode = hashCode * 59 + OwnerEdit.GetHashCode();
                if (OwnerView != null)
                    hashCode = hashCode * 59 + OwnerView.GetHashCode();
                if (TeamEdit != null)
                    hashCode = hashCode * 59 + TeamEdit.GetHashCode();
                if (TeamManagerOfOwnerEdit != null)
                    hashCode = hashCode * 59 + TeamManagerOfOwnerEdit.GetHashCode();
                if (TeamManagerOfOwnerView != null)
                    hashCode = hashCode * 59 + TeamManagerOfOwnerView.GetHashCode();
                if (TeamView != null)
                    hashCode = hashCode * 59 + TeamView.GetHashCode();
                if (View != null)
                    hashCode = hashCode * 59 + View.GetHashCode();
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

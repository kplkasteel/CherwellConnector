
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TeamResponse
    /// </summary>
    [DataContract]
    public sealed class TeamResponse :  IEquatable<TeamResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TeamType
        /// </summary>
        [DataMember(Name="teamType", EmitDefaultValue=false)]
        public TeamTypeEnum? TeamType { get; set; }
        
        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamResponse" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="emailAlias">emailAlias.</param>
        /// <param name="fields">fields.</param>
        /// <param name="image">image.</param>
        /// <param name="name">name.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="teamType">teamType.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public TeamResponse(string description = default, string emailAlias = default, List<FieldTemplateItem> fields = default, string image = default, string name = default, string teamId = default, TeamTypeEnum? teamType = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Description = description;
            EmailAlias = emailAlias;
            Fields = fields;
            Image = image;
            Name = name;
            TeamId = teamId;
            TeamType = teamType;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EmailAlias
        /// </summary>
        [DataMember(Name="emailAlias", EmitDefaultValue=false)]
        public string EmailAlias { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldTemplateItem> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }


        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamResponse {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmailAlias: ").Append(EmailAlias).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TeamType: ").Append(TeamType).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return Equals(input as TeamResponse);
        }

        /// <summary>
        /// Returns true if TeamResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    EmailAlias == input.EmailAlias ||
                    (EmailAlias != null &&
                    EmailAlias.Equals(input.EmailAlias))
                ) && 
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    Image == input.Image ||
                    (Image != null &&
                    Image.Equals(input.Image))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    TeamId == input.TeamId ||
                    (TeamId != null &&
                    TeamId.Equals(input.TeamId))
                ) && 
                (
                    TeamType == input.TeamType ||
                    (TeamType != null &&
                    TeamType.Equals(input.TeamType))
                ) && 
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    ErrorMessage == input.ErrorMessage ||
                    (ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    HasError == input.HasError ||
                    (HasError != null &&
                    HasError.Equals(input.HasError))
                ) && 
                (
                    HttpStatusCode == input.HttpStatusCode ||
                    (HttpStatusCode != null &&
                    HttpStatusCode.Equals(input.HttpStatusCode))
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (EmailAlias != null)
                    hashCode = hashCode * 59 + EmailAlias.GetHashCode();
                if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (TeamId != null)
                    hashCode = hashCode * 59 + TeamId.GetHashCode();
                if (TeamType != null)
                    hashCode = hashCode * 59 + TeamType.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (HttpStatusCode != null)
                    hashCode = hashCode * 59 + HttpStatusCode.GetHashCode();
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

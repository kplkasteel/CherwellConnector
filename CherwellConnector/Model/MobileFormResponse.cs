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
    /// MobileFormResponse
    /// </summary>
    [DataContract]
    public sealed class MobileFormResponse :  IEquatable<MobileFormResponse>, IValidatableObject
    {
        

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileFormResponse" /> class.
        /// </summary>
        /// <param name="actions">actions.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="locationInformation">locationInformation.</param>
        /// <param name="sections">sections.</param>
        /// <param name="title">title.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public MobileFormResponse(List<Action> actions = default, List<Attachment> attachments = default, string galleryImage = default, Location locationInformation = default, List<FormsSection> sections = default, string title = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Actions = actions;
            Attachments = attachments;
            GalleryImage = galleryImage;
            LocationInformation = locationInformation;
            Sections = sections;
            Title = title;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        /// <summary>
        /// Gets or Sets LocationInformation
        /// </summary>
        [DataMember(Name="locationInformation", EmitDefaultValue=false)]
        public Location LocationInformation { get; set; }

        /// <summary>
        /// Gets or Sets Sections
        /// </summary>
        [DataMember(Name="sections", EmitDefaultValue=false)]
        public List<FormsSection> Sections { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
            sb.Append("class MobileFormResponse {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  LocationInformation: ").Append(LocationInformation).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return Equals(input as MobileFormResponse);
        }

        /// <summary>
        /// Returns true if MobileFormResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileFormResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileFormResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Actions == input.Actions ||
                    Actions != null &&
                    Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    Attachments == input.Attachments ||
                    Attachments != null &&
                    Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    GalleryImage == input.GalleryImage ||
                    (GalleryImage != null &&
                    GalleryImage.Equals(input.GalleryImage))
                ) && 
                (
                    LocationInformation.Equals(input.LocationInformation) ||
                    (LocationInformation != null &&
                    LocationInformation.Equals(input.LocationInformation))
                ) && 
                (
                    Sections == input.Sections ||
                    Sections != null &&
                    Sections.SequenceEqual(input.Sections)
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
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
                if (Actions != null)
                    hashCode = hashCode * 59 + Actions.GetHashCode();
                if (Attachments != null)
                    hashCode = hashCode * 59 + Attachments.GetHashCode();
                if (GalleryImage != null)
                    hashCode = hashCode * 59 + GalleryImage.GetHashCode();
                if (LocationInformation != null)
                    hashCode = hashCode * 59 + LocationInformation.GetHashCode();
                if (Sections != null)
                    hashCode = hashCode * 59 + Sections.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
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

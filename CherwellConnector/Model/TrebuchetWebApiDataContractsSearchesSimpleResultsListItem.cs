
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
    /// TrebuchetWebApiDataContractsSearchesSimpleResultsListItem
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSearchesSimpleResultsListItem :  IEquatable<TrebuchetWebApiDataContractsSearchesSimpleResultsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesSimpleResultsListItem" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="docRepositoryItemId">docRepositoryItemId.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="links">links.</param>
        /// <param name="publicId">publicId.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="subTitle">subTitle.</param>
        /// <param name="text">text.</param>
        /// <param name="title">title.</param>
        public TrebuchetWebApiDataContractsSearchesSimpleResultsListItem(string busObId = default, string busObRecId = default, string docRepositoryItemId = default, string galleryImage = default, List<Link> links = default, string publicId = default, string scope = default, string scopeOwner = default, string subTitle = default, string text = default, string title = default)
        {
            BusObId = busObId;
            BusObRecId = busObRecId;
            DocRepositoryItemId = docRepositoryItemId;
            GalleryImage = galleryImage;
            Links = links;
            PublicId = publicId;
            Scope = scope;
            ScopeOwner = scopeOwner;
            SubTitle = subTitle;
            Text = text;
            Title = title;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets DocRepositoryItemId
        /// </summary>
        [DataMember(Name="docRepositoryItemId", EmitDefaultValue=false)]
        public string DocRepositoryItemId { get; set; }

        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

        /// <summary>
        /// Gets or Sets SubTitle
        /// </summary>
        [DataMember(Name="subTitle", EmitDefaultValue=false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesSimpleResultsListItem {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  DocRepositoryItemId: ").Append(DocRepositoryItemId).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesSimpleResultsListItem);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesSimpleResultsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesSimpleResultsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesSimpleResultsListItem input)
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
                    BusObRecId == input.BusObRecId ||
                    (BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    DocRepositoryItemId == input.DocRepositoryItemId ||
                    (DocRepositoryItemId != null &&
                    DocRepositoryItemId.Equals(input.DocRepositoryItemId))
                ) && 
                (
                    GalleryImage == input.GalleryImage ||
                    (GalleryImage != null &&
                    GalleryImage.Equals(input.GalleryImage))
                ) && 
                (
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) && 
                (
                    PublicId == input.PublicId ||
                    (PublicId != null &&
                    PublicId.Equals(input.PublicId))
                ) && 
                (
                    Scope == input.Scope ||
                    (Scope != null &&
                    Scope.Equals(input.Scope))
                ) && 
                (
                    ScopeOwner == input.ScopeOwner ||
                    (ScopeOwner != null &&
                    ScopeOwner.Equals(input.ScopeOwner))
                ) && 
                (
                    SubTitle == input.SubTitle ||
                    (SubTitle != null &&
                    SubTitle.Equals(input.SubTitle))
                ) && 
                (
                    Text == input.Text ||
                    (Text != null &&
                    Text.Equals(input.Text))
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
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
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (DocRepositoryItemId != null)
                    hashCode = hashCode * 59 + DocRepositoryItemId.GetHashCode();
                if (GalleryImage != null)
                    hashCode = hashCode * 59 + GalleryImage.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (PublicId != null)
                    hashCode = hashCode * 59 + PublicId.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwner != null)
                    hashCode = hashCode * 59 + ScopeOwner.GetHashCode();
                if (SubTitle != null)
                    hashCode = hashCode * 59 + SubTitle.GetHashCode();
                if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
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

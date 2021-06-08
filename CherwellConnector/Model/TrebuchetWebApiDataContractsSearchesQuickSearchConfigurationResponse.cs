/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    /// TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse :  IEquatable<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines HttpStatusCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpStatusCodeEnum
        {
            
            /// <summary>
            /// Enum Continue for value: Continue
            /// </summary>
            [EnumMember(Value = "Continue")]
            Continue = 1,
            
            /// <summary>
            /// Enum SwitchingProtocols for value: SwitchingProtocols
            /// </summary>
            [EnumMember(Value = "SwitchingProtocols")]
            SwitchingProtocols = 2,
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 3,
            
            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 4,
            
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 5,
            
            /// <summary>
            /// Enum NonAuthoritativeInformation for value: NonAuthoritativeInformation
            /// </summary>
            [EnumMember(Value = "NonAuthoritativeInformation")]
            NonAuthoritativeInformation = 6,
            
            /// <summary>
            /// Enum NoContent for value: NoContent
            /// </summary>
            [EnumMember(Value = "NoContent")]
            NoContent = 7,
            
            /// <summary>
            /// Enum ResetContent for value: ResetContent
            /// </summary>
            [EnumMember(Value = "ResetContent")]
            ResetContent = 8,
            
            /// <summary>
            /// Enum PartialContent for value: PartialContent
            /// </summary>
            [EnumMember(Value = "PartialContent")]
            PartialContent = 9,
            
            /// <summary>
            /// Enum MultipleChoices for value: MultipleChoices
            /// </summary>
            [EnumMember(Value = "MultipleChoices")]
            MultipleChoices = 10,
            
            /// <summary>
            /// Enum Ambiguous for value: Ambiguous
            /// </summary>
            [EnumMember(Value = "Ambiguous")]
            Ambiguous = 11,
            
            /// <summary>
            /// Enum MovedPermanently for value: MovedPermanently
            /// </summary>
            [EnumMember(Value = "MovedPermanently")]
            MovedPermanently = 12,
            
            /// <summary>
            /// Enum Moved for value: Moved
            /// </summary>
            [EnumMember(Value = "Moved")]
            Moved = 13,
            
            /// <summary>
            /// Enum Found for value: Found
            /// </summary>
            [EnumMember(Value = "Found")]
            Found = 14,
            
            /// <summary>
            /// Enum Redirect for value: Redirect
            /// </summary>
            [EnumMember(Value = "Redirect")]
            Redirect = 15,
            
            /// <summary>
            /// Enum SeeOther for value: SeeOther
            /// </summary>
            [EnumMember(Value = "SeeOther")]
            SeeOther = 16,
            
            /// <summary>
            /// Enum RedirectMethod for value: RedirectMethod
            /// </summary>
            [EnumMember(Value = "RedirectMethod")]
            RedirectMethod = 17,
            
            /// <summary>
            /// Enum NotModified for value: NotModified
            /// </summary>
            [EnumMember(Value = "NotModified")]
            NotModified = 18,
            
            /// <summary>
            /// Enum UseProxy for value: UseProxy
            /// </summary>
            [EnumMember(Value = "UseProxy")]
            UseProxy = 19,
            
            /// <summary>
            /// Enum Unused for value: Unused
            /// </summary>
            [EnumMember(Value = "Unused")]
            Unused = 20,
            
            /// <summary>
            /// Enum TemporaryRedirect for value: TemporaryRedirect
            /// </summary>
            [EnumMember(Value = "TemporaryRedirect")]
            TemporaryRedirect = 21,
            
            /// <summary>
            /// Enum RedirectKeepVerb for value: RedirectKeepVerb
            /// </summary>
            [EnumMember(Value = "RedirectKeepVerb")]
            RedirectKeepVerb = 22,
            
            /// <summary>
            /// Enum BadRequest for value: BadRequest
            /// </summary>
            [EnumMember(Value = "BadRequest")]
            BadRequest = 23,
            
            /// <summary>
            /// Enum Unauthorized for value: Unauthorized
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized = 24,
            
            /// <summary>
            /// Enum PaymentRequired for value: PaymentRequired
            /// </summary>
            [EnumMember(Value = "PaymentRequired")]
            PaymentRequired = 25,
            
            /// <summary>
            /// Enum Forbidden for value: Forbidden
            /// </summary>
            [EnumMember(Value = "Forbidden")]
            Forbidden = 26,
            
            /// <summary>
            /// Enum NotFound for value: NotFound
            /// </summary>
            [EnumMember(Value = "NotFound")]
            NotFound = 27,
            
            /// <summary>
            /// Enum MethodNotAllowed for value: MethodNotAllowed
            /// </summary>
            [EnumMember(Value = "MethodNotAllowed")]
            MethodNotAllowed = 28,
            
            /// <summary>
            /// Enum NotAcceptable for value: NotAcceptable
            /// </summary>
            [EnumMember(Value = "NotAcceptable")]
            NotAcceptable = 29,
            
            /// <summary>
            /// Enum ProxyAuthenticationRequired for value: ProxyAuthenticationRequired
            /// </summary>
            [EnumMember(Value = "ProxyAuthenticationRequired")]
            ProxyAuthenticationRequired = 30,
            
            /// <summary>
            /// Enum RequestTimeout for value: RequestTimeout
            /// </summary>
            [EnumMember(Value = "RequestTimeout")]
            RequestTimeout = 31,
            
            /// <summary>
            /// Enum Conflict for value: Conflict
            /// </summary>
            [EnumMember(Value = "Conflict")]
            Conflict = 32,
            
            /// <summary>
            /// Enum Gone for value: Gone
            /// </summary>
            [EnumMember(Value = "Gone")]
            Gone = 33,
            
            /// <summary>
            /// Enum LengthRequired for value: LengthRequired
            /// </summary>
            [EnumMember(Value = "LengthRequired")]
            LengthRequired = 34,
            
            /// <summary>
            /// Enum PreconditionFailed for value: PreconditionFailed
            /// </summary>
            [EnumMember(Value = "PreconditionFailed")]
            PreconditionFailed = 35,
            
            /// <summary>
            /// Enum RequestEntityTooLarge for value: RequestEntityTooLarge
            /// </summary>
            [EnumMember(Value = "RequestEntityTooLarge")]
            RequestEntityTooLarge = 36,
            
            /// <summary>
            /// Enum RequestUriTooLong for value: RequestUriTooLong
            /// </summary>
            [EnumMember(Value = "RequestUriTooLong")]
            RequestUriTooLong = 37,
            
            /// <summary>
            /// Enum UnsupportedMediaType for value: UnsupportedMediaType
            /// </summary>
            [EnumMember(Value = "UnsupportedMediaType")]
            UnsupportedMediaType = 38,
            
            /// <summary>
            /// Enum RequestedRangeNotSatisfiable for value: RequestedRangeNotSatisfiable
            /// </summary>
            [EnumMember(Value = "RequestedRangeNotSatisfiable")]
            RequestedRangeNotSatisfiable = 39,
            
            /// <summary>
            /// Enum ExpectationFailed for value: ExpectationFailed
            /// </summary>
            [EnumMember(Value = "ExpectationFailed")]
            ExpectationFailed = 40,
            
            /// <summary>
            /// Enum UpgradeRequired for value: UpgradeRequired
            /// </summary>
            [EnumMember(Value = "UpgradeRequired")]
            UpgradeRequired = 41,
            
            /// <summary>
            /// Enum InternalServerError for value: InternalServerError
            /// </summary>
            [EnumMember(Value = "InternalServerError")]
            InternalServerError = 42,
            
            /// <summary>
            /// Enum NotImplemented for value: NotImplemented
            /// </summary>
            [EnumMember(Value = "NotImplemented")]
            NotImplemented = 43,
            
            /// <summary>
            /// Enum BadGateway for value: BadGateway
            /// </summary>
            [EnumMember(Value = "BadGateway")]
            BadGateway = 44,
            
            /// <summary>
            /// Enum ServiceUnavailable for value: ServiceUnavailable
            /// </summary>
            [EnumMember(Value = "ServiceUnavailable")]
            ServiceUnavailable = 45,
            
            /// <summary>
            /// Enum GatewayTimeout for value: GatewayTimeout
            /// </summary>
            [EnumMember(Value = "GatewayTimeout")]
            GatewayTimeout = 46,
            
            /// <summary>
            /// Enum HttpVersionNotSupported for value: HttpVersionNotSupported
            /// </summary>
            [EnumMember(Value = "HttpVersionNotSupported")]
            HttpVersionNotSupported = 47
        }

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse" /> class.
        /// </summary>
        /// <param name="allowQuickSearch">allowQuickSearch.</param>
        /// <param name="allowSpecificSearch">allowSpecificSearch.</param>
        /// <param name="defaultToQuickSearch">defaultToQuickSearch.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="history">history.</param>
        /// <param name="includeAvailableInSpecific">includeAvailableInSpecific.</param>
        /// <param name="includeQuickSearchInSpecific">includeQuickSearchInSpecific.</param>
        /// <param name="quickSearchId">quickSearchId.</param>
        /// <param name="quickSearchItems">quickSearchItems.</param>
        /// <param name="quickSearchWatermark">quickSearchWatermark.</param>
        /// <param name="sortByRelevance">sortByRelevance.</param>
        /// <param name="resolvedQuickSearchWatermark">resolvedQuickSearchWatermark.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="specificSearchItems">specificSearchItems.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse(bool? allowQuickSearch = default(bool?), bool? allowSpecificSearch = default(bool?), bool? defaultToQuickSearch = default(bool?), string displayName = default(string), string galleryImage = default(string), List<string> history = default(List<string>), bool? includeAvailableInSpecific = default(bool?), bool? includeQuickSearchInSpecific = default(bool?), string quickSearchId = default(string), List<TrebuchetWebApiDataContractsSearchesQuickSearchItem> quickSearchItems = default(List<TrebuchetWebApiDataContractsSearchesQuickSearchItem>), string quickSearchWatermark = default(string), bool? sortByRelevance = default(bool?), string resolvedQuickSearchWatermark = default(string), string scope = default(string), string scopeOwner = default(string), List<TrebuchetWebApiDataContractsSearchesQuickSearchItem> specificSearchItems = default(List<TrebuchetWebApiDataContractsSearchesQuickSearchItem>), string errorCode = default(string), string errorMessage = default(string), bool? hasError = default(bool?), HttpStatusCodeEnum? httpStatusCode = default(HttpStatusCodeEnum?))
        {
            this.AllowQuickSearch = allowQuickSearch;
            this.AllowSpecificSearch = allowSpecificSearch;
            this.DefaultToQuickSearch = defaultToQuickSearch;
            this.DisplayName = displayName;
            this.GalleryImage = galleryImage;
            this.History = history;
            this.IncludeAvailableInSpecific = includeAvailableInSpecific;
            this.IncludeQuickSearchInSpecific = includeQuickSearchInSpecific;
            this.QuickSearchId = quickSearchId;
            this.QuickSearchItems = quickSearchItems;
            this.QuickSearchWatermark = quickSearchWatermark;
            this.SortByRelevance = sortByRelevance;
            this.ResolvedQuickSearchWatermark = resolvedQuickSearchWatermark;
            this.Scope = scope;
            this.ScopeOwner = scopeOwner;
            this.SpecificSearchItems = specificSearchItems;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.HasError = hasError;
            this.HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets AllowQuickSearch
        /// </summary>
        [DataMember(Name="allowQuickSearch", EmitDefaultValue=false)]
        public bool? AllowQuickSearch { get; set; }

        /// <summary>
        /// Gets or Sets AllowSpecificSearch
        /// </summary>
        [DataMember(Name="allowSpecificSearch", EmitDefaultValue=false)]
        public bool? AllowSpecificSearch { get; set; }

        /// <summary>
        /// Gets or Sets DefaultToQuickSearch
        /// </summary>
        [DataMember(Name="defaultToQuickSearch", EmitDefaultValue=false)]
        public bool? DefaultToQuickSearch { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history", EmitDefaultValue=false)]
        public List<string> History { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAvailableInSpecific
        /// </summary>
        [DataMember(Name="includeAvailableInSpecific", EmitDefaultValue=false)]
        public bool? IncludeAvailableInSpecific { get; set; }

        /// <summary>
        /// Gets or Sets IncludeQuickSearchInSpecific
        /// </summary>
        [DataMember(Name="includeQuickSearchInSpecific", EmitDefaultValue=false)]
        public bool? IncludeQuickSearchInSpecific { get; set; }

        /// <summary>
        /// Gets or Sets QuickSearchId
        /// </summary>
        [DataMember(Name="quickSearchId", EmitDefaultValue=false)]
        public string QuickSearchId { get; set; }

        /// <summary>
        /// Gets or Sets QuickSearchItems
        /// </summary>
        [DataMember(Name="quickSearchItems", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsSearchesQuickSearchItem> QuickSearchItems { get; set; }

        /// <summary>
        /// Gets or Sets QuickSearchWatermark
        /// </summary>
        [DataMember(Name="quickSearchWatermark", EmitDefaultValue=false)]
        public string QuickSearchWatermark { get; set; }

        /// <summary>
        /// Gets or Sets SortByRelevance
        /// </summary>
        [DataMember(Name="sortByRelevance", EmitDefaultValue=false)]
        public bool? SortByRelevance { get; set; }

        /// <summary>
        /// Gets or Sets ResolvedQuickSearchWatermark
        /// </summary>
        [DataMember(Name="resolvedQuickSearchWatermark", EmitDefaultValue=false)]
        public string ResolvedQuickSearchWatermark { get; set; }

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
        /// Gets or Sets SpecificSearchItems
        /// </summary>
        [DataMember(Name="specificSearchItems", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsSearchesQuickSearchItem> SpecificSearchItems { get; set; }

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
            sb.Append("class TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse {\n");
            sb.Append("  AllowQuickSearch: ").Append(this.AllowQuickSearch).Append("\n");
            sb.Append("  AllowSpecificSearch: ").Append(this.AllowSpecificSearch).Append("\n");
            sb.Append("  DefaultToQuickSearch: ").Append(this.DefaultToQuickSearch).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  GalleryImage: ").Append(this.GalleryImage).Append("\n");
            sb.Append("  History: ").Append(this.History).Append("\n");
            sb.Append("  IncludeAvailableInSpecific: ").Append(this.IncludeAvailableInSpecific).Append("\n");
            sb.Append("  IncludeQuickSearchInSpecific: ").Append(this.IncludeQuickSearchInSpecific).Append("\n");
            sb.Append("  QuickSearchId: ").Append(this.QuickSearchId).Append("\n");
            sb.Append("  QuickSearchItems: ").Append(this.QuickSearchItems).Append("\n");
            sb.Append("  QuickSearchWatermark: ").Append(this.QuickSearchWatermark).Append("\n");
            sb.Append("  SortByRelevance: ").Append(this.SortByRelevance).Append("\n");
            sb.Append("  ResolvedQuickSearchWatermark: ").Append(this.ResolvedQuickSearchWatermark).Append("\n");
            sb.Append("  Scope: ").Append(this.Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(this.ScopeOwner).Append("\n");
            sb.Append("  SpecificSearchItems: ").Append(this.SpecificSearchItems).Append("\n");
            sb.Append("  ErrorCode: ").Append(this.ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(this.ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(this.HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(this.HttpStatusCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowQuickSearch == input.AllowQuickSearch ||
                    (this.AllowQuickSearch != null &&
                    this.AllowQuickSearch.Equals(input.AllowQuickSearch))
                ) && 
                (
                    this.AllowSpecificSearch == input.AllowSpecificSearch ||
                    (this.AllowSpecificSearch != null &&
                    this.AllowSpecificSearch.Equals(input.AllowSpecificSearch))
                ) && 
                (
                    this.DefaultToQuickSearch == input.DefaultToQuickSearch ||
                    (this.DefaultToQuickSearch != null &&
                    this.DefaultToQuickSearch.Equals(input.DefaultToQuickSearch))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.GalleryImage == input.GalleryImage ||
                    (this.GalleryImage != null &&
                    this.GalleryImage.Equals(input.GalleryImage))
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    this.History.SequenceEqual(input.History)
                ) && 
                (
                    this.IncludeAvailableInSpecific == input.IncludeAvailableInSpecific ||
                    (this.IncludeAvailableInSpecific != null &&
                    this.IncludeAvailableInSpecific.Equals(input.IncludeAvailableInSpecific))
                ) && 
                (
                    this.IncludeQuickSearchInSpecific == input.IncludeQuickSearchInSpecific ||
                    (this.IncludeQuickSearchInSpecific != null &&
                    this.IncludeQuickSearchInSpecific.Equals(input.IncludeQuickSearchInSpecific))
                ) && 
                (
                    this.QuickSearchId == input.QuickSearchId ||
                    (this.QuickSearchId != null &&
                    this.QuickSearchId.Equals(input.QuickSearchId))
                ) && 
                (
                    this.QuickSearchItems == input.QuickSearchItems ||
                    this.QuickSearchItems != null &&
                    this.QuickSearchItems.SequenceEqual(input.QuickSearchItems)
                ) && 
                (
                    this.QuickSearchWatermark == input.QuickSearchWatermark ||
                    (this.QuickSearchWatermark != null &&
                    this.QuickSearchWatermark.Equals(input.QuickSearchWatermark))
                ) && 
                (
                    this.SortByRelevance == input.SortByRelevance ||
                    (this.SortByRelevance != null &&
                    this.SortByRelevance.Equals(input.SortByRelevance))
                ) && 
                (
                    this.ResolvedQuickSearchWatermark == input.ResolvedQuickSearchWatermark ||
                    (this.ResolvedQuickSearchWatermark != null &&
                    this.ResolvedQuickSearchWatermark.Equals(input.ResolvedQuickSearchWatermark))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.ScopeOwner == input.ScopeOwner ||
                    (this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(input.ScopeOwner))
                ) && 
                (
                    this.SpecificSearchItems == input.SpecificSearchItems ||
                    this.SpecificSearchItems != null &&
                    this.SpecificSearchItems.SequenceEqual(input.SpecificSearchItems)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.HasError == input.HasError ||
                    (this.HasError != null &&
                    this.HasError.Equals(input.HasError))
                ) && 
                (
                    this.HttpStatusCode == input.HttpStatusCode ||
                    (this.HttpStatusCode != null &&
                    this.HttpStatusCode.Equals(input.HttpStatusCode))
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
                int hashCode = 41;
                if (this.AllowQuickSearch != null)
                    hashCode = hashCode * 59 + this.AllowQuickSearch.GetHashCode();
                if (this.AllowSpecificSearch != null)
                    hashCode = hashCode * 59 + this.AllowSpecificSearch.GetHashCode();
                if (this.DefaultToQuickSearch != null)
                    hashCode = hashCode * 59 + this.DefaultToQuickSearch.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.GalleryImage != null)
                    hashCode = hashCode * 59 + this.GalleryImage.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
                if (this.IncludeAvailableInSpecific != null)
                    hashCode = hashCode * 59 + this.IncludeAvailableInSpecific.GetHashCode();
                if (this.IncludeQuickSearchInSpecific != null)
                    hashCode = hashCode * 59 + this.IncludeQuickSearchInSpecific.GetHashCode();
                if (this.QuickSearchId != null)
                    hashCode = hashCode * 59 + this.QuickSearchId.GetHashCode();
                if (this.QuickSearchItems != null)
                    hashCode = hashCode * 59 + this.QuickSearchItems.GetHashCode();
                if (this.QuickSearchWatermark != null)
                    hashCode = hashCode * 59 + this.QuickSearchWatermark.GetHashCode();
                if (this.SortByRelevance != null)
                    hashCode = hashCode * 59 + this.SortByRelevance.GetHashCode();
                if (this.ResolvedQuickSearchWatermark != null)
                    hashCode = hashCode * 59 + this.ResolvedQuickSearchWatermark.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hashCode = hashCode * 59 + this.ScopeOwner.GetHashCode();
                if (this.SpecificSearchItems != null)
                    hashCode = hashCode * 59 + this.SpecificSearchItems.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.HasError != null)
                    hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.HttpStatusCode != null)
                    hashCode = hashCode * 59 + this.HttpStatusCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
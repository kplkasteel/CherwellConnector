
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TrebuchetWebApiDataContractsSecurityApiClientSettingResponse
    /// </summary>
    [DataContract]
    public sealed class ApiClientSettingResponse :  IEquatable<ApiClientSettingResponse>, IValidatableObject
    {
        

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClientSettingResponse" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="culture">culture.</param>
        /// <param name="clientKey">clientKey.</param>
        /// <param name="tokenLifespanMinutes">tokenLifespanMinutes.</param>
        /// <param name="refreshTokenLifespanMinutes">refreshTokenLifespanMinutes.</param>
        /// <param name="apiAccessIsEnabled">apiAccessIsEnabled.</param>
        /// <param name="allowAnonymousAccess">allowAnonymousAccess.</param>
        /// <param name="standInKey">standInKey.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public ApiClientSettingResponse(string name = default, string description = default, string culture = default, string clientKey = default, int? tokenLifespanMinutes = default, int? refreshTokenLifespanMinutes = default, bool? apiAccessIsEnabled = default, bool? allowAnonymousAccess = default, string standInKey = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Name = name;
            Description = description;
            Culture = culture;
            ClientKey = clientKey;
            TokenLifespanMinutes = tokenLifespanMinutes;
            RefreshTokenLifespanMinutes = refreshTokenLifespanMinutes;
            ApiAccessIsEnabled = apiAccessIsEnabled;
            AllowAnonymousAccess = allowAnonymousAccess;
            StandInKey = standInKey;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Culture
        /// </summary>
        [DataMember(Name="culture", EmitDefaultValue=false)]
        public string Culture { get; set; }

        /// <summary>
        /// Gets or Sets ClientKey
        /// </summary>
        [DataMember(Name="clientKey", EmitDefaultValue=false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// Gets or Sets TokenLifespanMinutes
        /// </summary>
        [DataMember(Name="tokenLifespanMinutes", EmitDefaultValue=false)]
        public int? TokenLifespanMinutes { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenLifespanMinutes
        /// </summary>
        [DataMember(Name="refreshTokenLifespanMinutes", EmitDefaultValue=false)]
        public int? RefreshTokenLifespanMinutes { get; set; }

        /// <summary>
        /// Gets or Sets ApiAccessIsEnabled
        /// </summary>
        [DataMember(Name="apiAccessIsEnabled", EmitDefaultValue=false)]
        public bool? ApiAccessIsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets AllowAnonymousAccess
        /// </summary>
        [DataMember(Name="allowAnonymousAccess", EmitDefaultValue=false)]
        public bool? AllowAnonymousAccess { get; set; }

        /// <summary>
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name="standInKey", EmitDefaultValue=false)]
        public string StandInKey { get; set; }

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
            sb.Append("class ApiClientSettingResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
            sb.Append("  TokenLifespanMinutes: ").Append(TokenLifespanMinutes).Append("\n");
            sb.Append("  RefreshTokenLifespanMinutes: ").Append(RefreshTokenLifespanMinutes).Append("\n");
            sb.Append("  ApiAccessIsEnabled: ").Append(ApiAccessIsEnabled).Append("\n");
            sb.Append("  AllowAnonymousAccess: ").Append(AllowAnonymousAccess).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
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
            return Equals(input as ApiClientSettingResponse);
        }

        /// <summary>
        /// Returns true if ApiClientSettingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiClientSettingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiClientSettingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    Culture == input.Culture ||
                    (Culture != null &&
                    Culture.Equals(input.Culture))
                ) && 
                (
                    ClientKey == input.ClientKey ||
                    (ClientKey != null &&
                    ClientKey.Equals(input.ClientKey))
                ) && 
                (
                    TokenLifespanMinutes == input.TokenLifespanMinutes ||
                    (TokenLifespanMinutes != null &&
                    TokenLifespanMinutes.Equals(input.TokenLifespanMinutes))
                ) && 
                (
                    RefreshTokenLifespanMinutes == input.RefreshTokenLifespanMinutes ||
                    (RefreshTokenLifespanMinutes != null &&
                    RefreshTokenLifespanMinutes.Equals(input.RefreshTokenLifespanMinutes))
                ) && 
                (
                    ApiAccessIsEnabled == input.ApiAccessIsEnabled ||
                    (ApiAccessIsEnabled != null &&
                    ApiAccessIsEnabled.Equals(input.ApiAccessIsEnabled))
                ) && 
                (
                    AllowAnonymousAccess == input.AllowAnonymousAccess ||
                    (AllowAnonymousAccess != null &&
                    AllowAnonymousAccess.Equals(input.AllowAnonymousAccess))
                ) && 
                (
                    StandInKey == input.StandInKey ||
                    (StandInKey != null &&
                    StandInKey.Equals(input.StandInKey))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Culture != null)
                    hashCode = hashCode * 59 + Culture.GetHashCode();
                if (ClientKey != null)
                    hashCode = hashCode * 59 + ClientKey.GetHashCode();
                if (TokenLifespanMinutes != null)
                    hashCode = hashCode * 59 + TokenLifespanMinutes.GetHashCode();
                if (RefreshTokenLifespanMinutes != null)
                    hashCode = hashCode * 59 + RefreshTokenLifespanMinutes.GetHashCode();
                if (ApiAccessIsEnabled != null)
                    hashCode = hashCode * 59 + ApiAccessIsEnabled.GetHashCode();
                if (AllowAnonymousAccess != null)
                    hashCode = hashCode * 59 + AllowAnonymousAccess.GetHashCode();
                if (StandInKey != null)
                    hashCode = hashCode * 59 + StandInKey.GetHashCode();
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

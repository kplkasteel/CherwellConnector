using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SaveApiClientSettingRequest
    /// </summary>
    [DataContract]
    public sealed class SaveApiClientSettingRequest : IEquatable<SaveApiClientSettingRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SaveApiClientSettingRequest" /> class.
        /// </summary>
        /// <param name="allowAnonymousAccess">allowAnonymousAccess.</param>
        /// <param name="apiAccessIsEnabled">apiAccessIsEnabled.</param>
        /// <param name="createNewClientKey">createNewClientKey.</param>
        /// <param name="culture">culture.</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="refreshTokenLifespanMinutes">refreshTokenLifespanMinutes.</param>
        /// <param name="standInKey">standInKey.</param>
        /// <param name="tokenLifespanMinutes">tokenLifespanMinutes.</param>
        public SaveApiClientSettingRequest(bool? allowAnonymousAccess = default, bool? apiAccessIsEnabled = default,
            bool? createNewClientKey = default, string culture = default, string description = default,
            string name = default, int? refreshTokenLifespanMinutes = default, string standInKey = default,
            int? tokenLifespanMinutes = default)
        {
            AllowAnonymousAccess = allowAnonymousAccess;
            ApiAccessIsEnabled = apiAccessIsEnabled;
            CreateNewClientKey = createNewClientKey;
            Culture = culture;
            Description = description;
            Name = name;
            RefreshTokenLifespanMinutes = refreshTokenLifespanMinutes;
            StandInKey = standInKey;
            TokenLifespanMinutes = tokenLifespanMinutes;
        }

        /// <summary>
        ///     Gets or Sets AllowAnonymousAccess
        /// </summary>
        [DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
        public bool? AllowAnonymousAccess { get; set; }

        /// <summary>
        ///     Gets or Sets ApiAccessIsEnabled
        /// </summary>
        [DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
        public bool? ApiAccessIsEnabled { get; set; }

        /// <summary>
        ///     Gets or Sets CreateNewClientKey
        /// </summary>
        [DataMember(Name = "createNewClientKey", EmitDefaultValue = false)]
        public bool? CreateNewClientKey { get; set; }

        /// <summary>
        ///     Gets or Sets Culture
        /// </summary>
        [DataMember(Name = "culture", EmitDefaultValue = false)]
        public string Culture { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets RefreshTokenLifespanMinutes
        /// </summary>
        [DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
        public int? RefreshTokenLifespanMinutes { get; set; }

        /// <summary>
        ///     Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }

        /// <summary>
        ///     Gets or Sets TokenLifespanMinutes
        /// </summary>
        [DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
        public int? TokenLifespanMinutes { get; set; }

        /// <summary>
        ///     Returns true if SaveApiClientSettingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveApiClientSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveApiClientSettingRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    AllowAnonymousAccess == input.AllowAnonymousAccess ||
                    AllowAnonymousAccess != null &&
                    AllowAnonymousAccess.Equals(input.AllowAnonymousAccess)
                ) &&
                (
                    ApiAccessIsEnabled == input.ApiAccessIsEnabled ||
                    ApiAccessIsEnabled != null &&
                    ApiAccessIsEnabled.Equals(input.ApiAccessIsEnabled)
                ) &&
                (
                    CreateNewClientKey == input.CreateNewClientKey ||
                    CreateNewClientKey != null &&
                    CreateNewClientKey.Equals(input.CreateNewClientKey)
                ) &&
                (
                    Culture == input.Culture ||
                    Culture != null &&
                    Culture.Equals(input.Culture)
                ) &&
                (
                    Description == input.Description ||
                    Description != null &&
                    Description.Equals(input.Description)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    RefreshTokenLifespanMinutes == input.RefreshTokenLifespanMinutes ||
                    RefreshTokenLifespanMinutes != null &&
                    RefreshTokenLifespanMinutes.Equals(input.RefreshTokenLifespanMinutes)
                ) &&
                (
                    StandInKey == input.StandInKey ||
                    StandInKey != null &&
                    StandInKey.Equals(input.StandInKey)
                ) &&
                (
                    TokenLifespanMinutes == input.TokenLifespanMinutes ||
                    TokenLifespanMinutes != null &&
                    TokenLifespanMinutes.Equals(input.TokenLifespanMinutes)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveApiClientSettingRequest {\n");
            sb.Append("  AllowAnonymousAccess: ").Append(AllowAnonymousAccess).Append("\n");
            sb.Append("  ApiAccessIsEnabled: ").Append(ApiAccessIsEnabled).Append("\n");
            sb.Append("  CreateNewClientKey: ").Append(CreateNewClientKey).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RefreshTokenLifespanMinutes: ").Append(RefreshTokenLifespanMinutes).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
            sb.Append("  TokenLifespanMinutes: ").Append(TokenLifespanMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as SaveApiClientSettingRequest);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AllowAnonymousAccess != null)
                    hashCode = hashCode * 59 + AllowAnonymousAccess.GetHashCode();
                if (ApiAccessIsEnabled != null)
                    hashCode = hashCode * 59 + ApiAccessIsEnabled.GetHashCode();
                if (CreateNewClientKey != null)
                    hashCode = hashCode * 59 + CreateNewClientKey.GetHashCode();
                if (Culture != null)
                    hashCode = hashCode * 59 + Culture.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (RefreshTokenLifespanMinutes != null)
                    hashCode = hashCode * 59 + RefreshTokenLifespanMinutes.GetHashCode();
                if (StandInKey != null)
                    hashCode = hashCode * 59 + StandInKey.GetHashCode();
                if (TokenLifespanMinutes != null)
                    hashCode = hashCode * 59 + TokenLifespanMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
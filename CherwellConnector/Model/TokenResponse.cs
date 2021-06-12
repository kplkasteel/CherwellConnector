
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TokenResponse
    /// </summary>
    [DataContract]
    public sealed class TokenResponse :  IEquatable<TokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="asclientId">asclientId.</param>
        /// <param name="expires">expires.</param>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="issued">issued.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="tokenType">tokenType.</param>
        /// <param name="username">username.</param>
        public TokenResponse(string accessToken = default, string asclientId = default, string expires = default, int? expiresIn = default, string issued = default, string refreshToken = default, string tokenType = default, string username = default)
        {
            AccessToken = accessToken;
            AsclientId = asclientId;
            Expires = expires;
            ExpiresIn = expiresIn;
            Issued = issued;
            RefreshToken = refreshToken;
            TokenType = tokenType;
            Username = username;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets AsclientId
        /// </summary>
        [DataMember(Name="as:client_id", EmitDefaultValue=false)]
        public string AsclientId { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name=".expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets Issued
        /// </summary>
        [DataMember(Name=".issued", EmitDefaultValue=false)]
        public string Issued { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AsclientId: ").Append(AsclientId).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Issued: ").Append(Issued).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return Equals(input as TokenResponse);
        }

        /// <summary>
        /// Returns true if TokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccessToken == input.AccessToken ||
                    (AccessToken != null &&
                    AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    AsclientId == input.AsclientId ||
                    (AsclientId != null &&
                    AsclientId.Equals(input.AsclientId))
                ) && 
                (
                    Expires == input.Expires ||
                    (Expires != null &&
                    Expires.Equals(input.Expires))
                ) && 
                (
                    ExpiresIn == input.ExpiresIn ||
                    (ExpiresIn != null &&
                    ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    Issued == input.Issued ||
                    (Issued != null &&
                    Issued.Equals(input.Issued))
                ) && 
                (
                    RefreshToken == input.RefreshToken ||
                    (RefreshToken != null &&
                    RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    TokenType == input.TokenType ||
                    (TokenType != null &&
                    TokenType.Equals(input.TokenType))
                ) && 
                (
                    Username == input.Username ||
                    (Username != null &&
                    Username.Equals(input.Username))
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
                if (AccessToken != null)
                    hashCode = hashCode * 59 + AccessToken.GetHashCode();
                if (AsclientId != null)
                    hashCode = hashCode * 59 + AsclientId.GetHashCode();
                if (Expires != null)
                    hashCode = hashCode * 59 + Expires.GetHashCode();
                if (ExpiresIn != null)
                    hashCode = hashCode * 59 + ExpiresIn.GetHashCode();
                if (Issued != null)
                    hashCode = hashCode * 59 + Issued.GetHashCode();
                if (RefreshToken != null)
                    hashCode = hashCode * 59 + RefreshToken.GetHashCode();
                if (TokenType != null)
                    hashCode = hashCode * 59 + TokenType.GetHashCode();
                if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
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

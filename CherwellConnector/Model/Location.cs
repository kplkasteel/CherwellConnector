using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     Location
    /// </summary>
    [DataContract]
    public sealed class Location : IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="altitude">altitude.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public Location(double? altitude = default, string busObId = default, string busObRecId = default,
            double? latitude = default, double? longitude = default)
        {
            Altitude = altitude;
            BusObId = busObId;
            BusObRecId = busObRecId;
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        ///     Gets or Sets Altitude
        /// </summary>
        [DataMember(Name = "altitude", EmitDefaultValue = false)]
        public double? Altitude { get; set; }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double? Latitude { get; set; }

        /// <summary>
        ///     Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double? Longitude { get; set; }

        /// <summary>
        ///     Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
                return false;

            return
                (
                    Altitude == input.Altitude ||
                    Altitude != null &&
                    Altitude.Equals(input.Altitude)
                ) &&
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    Latitude == input.Latitude ||
                    Latitude != null &&
                    Latitude.Equals(input.Latitude)
                ) &&
                (
                    Longitude == input.Longitude ||
                    Longitude != null &&
                    Longitude.Equals(input.Longitude)
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
            sb.Append("class Location {\n");
            sb.Append("  Altitude: ").Append(Altitude).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return Equals(input as Location);
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
                if (Altitude != null)
                    hashCode = hashCode * 59 + Altitude.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                return hashCode;
            }
        }
    }
}
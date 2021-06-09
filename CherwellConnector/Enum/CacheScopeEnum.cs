using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines CacheScope
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CacheScopeEnum
    {
            
        /// <summary>
        /// Enum Tenant for value: Tenant
        /// </summary>
        [EnumMember(Value = "Tenant")]
        Tenant = 1,
            
        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 2,
            
        /// <summary>
        /// Enum Session for value: Session
        /// </summary>
        [EnumMember(Value = "Session")]
        Session = 3
    }
}
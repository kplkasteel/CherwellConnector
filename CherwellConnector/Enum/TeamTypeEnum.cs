using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines TeamType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TeamTypeEnum
    {
            
        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 1,
            
        /// <summary>
        /// Enum CustomerWorkgroup for value: CustomerWorkgroup
        /// </summary>
        [EnumMember(Value = "CustomerWorkgroup")]
        CustomerWorkgroup = 2
    }
}
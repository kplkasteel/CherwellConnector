using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines LoginEnabledMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoginEnabledModeEnum
    {
            
        /// <summary>
        /// Enum Anonymous for value: Anonymous
        /// </summary>
        [EnumMember(Value = "Anonymous")]
        Anonymous = 1,
            
        /// <summary>
        /// Enum LoggedIn for value: LoggedIn
        /// </summary>
        [EnumMember(Value = "LoggedIn")]
        LoggedIn = 2,
            
        /// <summary>
        /// Enum Both for value: Both
        /// </summary>
        [EnumMember(Value = "Both")]
        Both = 3
    }
}
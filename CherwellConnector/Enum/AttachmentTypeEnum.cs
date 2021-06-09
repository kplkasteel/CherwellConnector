using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines AttachmentType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttachmentTypeEnum
    {
            
        /// <summary>
        /// Enum Imported for value: Imported
        /// </summary>
        [EnumMember(Value = "Imported")]
        Imported = 1,
            
        /// <summary>
        /// Enum Linked for value: Linked
        /// </summary>
        [EnumMember(Value = "Linked")]
        Linked = 2,
            
        /// <summary>
        /// Enum URL for value: URL
        /// </summary>
        [EnumMember(Value = "URL")]
        URL = 3
    }
}
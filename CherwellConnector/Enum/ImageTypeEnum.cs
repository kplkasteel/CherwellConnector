using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines ImageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageTypeEnum
    {
            
        /// <summary>
        /// Enum Imported for value: Imported
        /// </summary>
        [EnumMember(Value = "Imported")]
        Imported = 1,
            
        /// <summary>
        /// Enum File for value: File
        /// </summary>
        [EnumMember(Value = "File")]
        File = 2,
            
        /// <summary>
        /// Enum Url for value: Url
        /// </summary>
        [EnumMember(Value = "Url")]
        Url = 3
    }
}
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    ///     Defines SearchRelatedOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchRelatedOptionEnum
    {
        /// <summary>
        ///     Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")] None = 1,

        /// <summary>
        ///     Enum Use for value: Use
        /// </summary>
        [EnumMember(Value = "Use")] Use = 2,

        /// <summary>
        ///     Enum Display for value: Display
        /// </summary>
        [EnumMember(Value = "Display")] Display = 3,

        /// <summary>
        ///     Enum UseAndDisplay for value: UseAndDisplay
        /// </summary>
        [EnumMember(Value = "UseAndDisplay")] UseAndDisplay = 4
    }
}
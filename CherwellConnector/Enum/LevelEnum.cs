using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    ///     Defines Level
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LevelEnum
    {
        /// <summary>
        ///     Enum Fatal for value: Fatal
        /// </summary>
        [EnumMember(Value = "Fatal")] Fatal = 1,

        /// <summary>
        ///     Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")] Error = 2,

        /// <summary>
        ///     Enum Warning for value: Warning
        /// </summary>
        [EnumMember(Value = "Warning")] Warning = 3,

        /// <summary>
        ///     Enum Info for value: Info
        /// </summary>
        [EnumMember(Value = "Info")] Info = 4,

        /// <summary>
        ///     Enum Stats for value: Stats
        /// </summary>
        [EnumMember(Value = "Stats")] Stats = 5,

        /// <summary>
        ///     Enum Debug for value: Debug
        /// </summary>
        [EnumMember(Value = "Debug")] Debug = 6
    }
}
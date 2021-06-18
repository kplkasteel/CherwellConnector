using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    ///     Defines ListDisplayOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListDisplayOptionEnum
    {
        /// <summary>
        ///     Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")] Auto = 1,

        /// <summary>
        ///     Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")] Text = 2,

        /// <summary>
        ///     Enum Combo for value: Combo
        /// </summary>
        [EnumMember(Value = "Combo")] Combo = 3,

        /// <summary>
        ///     Enum GridList for value: GridList
        /// </summary>
        [EnumMember(Value = "GridList")] GridList = 4,

        /// <summary>
        ///     Enum SimpleList for value: SimpleList
        /// </summary>
        [EnumMember(Value = "SimpleList")] SimpleList = 5,

        /// <summary>
        ///     Enum PromptSimpleGrid for value: PromptSimpleGrid
        /// </summary>
        [EnumMember(Value = "PromptSimpleGrid")]
        PromptSimpleGrid = 6
    }
}
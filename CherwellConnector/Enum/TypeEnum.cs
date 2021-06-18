using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    ///     Defines Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        ///     Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")] None = 1,

        /// <summary>
        ///     Enum File for value: File
        /// </summary>
        [EnumMember(Value = "File")] File = 2,

        /// <summary>
        ///     Enum FileManagerFile for value: FileManagerFile
        /// </summary>
        [EnumMember(Value = "FileManagerFile")]
        FileManagerFile = 3,

        /// <summary>
        ///     Enum BusOb for value: BusOb
        /// </summary>
        [EnumMember(Value = "BusOb")] BusOb = 4,

        /// <summary>
        ///     Enum History for value: History
        /// </summary>
        [EnumMember(Value = "History")] History = 5,

        /// <summary>
        ///     Enum Other for value: Other
        /// </summary>
        [EnumMember(Value = "Other")] Other = 6,

        /// <summary>
        ///     Enum Solution for value: Solution
        /// </summary>
        [EnumMember(Value = "Solution")] Solution = 7,

        /// <summary>
        ///     Enum UsedAsSolution for value: UsedAsSolution
        /// </summary>
        [EnumMember(Value = "UsedAsSolution")] UsedAsSolution = 8,

        /// <summary>
        ///     Enum ExternalSolution for value: ExternalSolution
        /// </summary>
        [EnumMember(Value = "ExternalSolution")]
        ExternalSolution = 9
    }
}
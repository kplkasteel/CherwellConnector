using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines SearchTargetType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchTargetTypeEnum
    {
            
        /// <summary>
        /// Enum BusOb for value: BusOb
        /// </summary>
        [EnumMember(Value = "BusOb")]
        BusOb = 1,
            
        /// <summary>
        /// Enum DocRepository for value: DocRepository
        /// </summary>
        [EnumMember(Value = "DocRepository")]
        DocRepository = 2
    }
}
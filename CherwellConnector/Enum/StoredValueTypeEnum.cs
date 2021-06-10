using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines StoredValueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StoredValueTypeEnum
    {
            
        /// <summary>
        /// Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 1,
            
        /// <summary>
        /// Enum Number for value: Number
        /// </summary>
        [EnumMember(Value = "Number")]
        Number = 2,
            
        /// <summary>
        /// Enum DateTime for value: DateTime
        /// </summary>
        [EnumMember(Value = "DateTime")]
        DateTime = 3,
            
        /// <summary>
        /// Enum Logical for value: Logical
        /// </summary>
        [EnumMember(Value = "Logical")]
        Logical = 4,
            
        /// <summary>
        /// Enum Color for value: Color
        /// </summary>
        [EnumMember(Value = "Color")]
        Color = 5,
            
        /// <summary>
        /// Enum Json for value: Json
        /// </summary>
        [EnumMember(Value = "Json")]
        Json = 6,
            
        /// <summary>
        /// Enum JsonArray for value: JsonArray
        /// </summary>
        [EnumMember(Value = "JsonArray")]
        JsonArray = 7,
            
        /// <summary>
        /// Enum Xml for value: Xml
        /// </summary>
        [EnumMember(Value = "Xml")]
        Xml = 8,
            
        /// <summary>
        /// Enum XmlCollection for value: XmlCollection
        /// </summary>
        [EnumMember(Value = "XmlCollection")]
        XmlCollection = 9
    }
}
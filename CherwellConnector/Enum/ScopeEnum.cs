using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines Scope
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScopeEnum
    {
            
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,
            
        /// <summary>
        /// Enum Global for value: Global
        /// </summary>
        [EnumMember(Value = "Global")]
        Global = 2,
            
        /// <summary>
        /// Enum Team for value: Team
        /// </summary>
        [EnumMember(Value = "Team")]
        Team = 3,
            
        /// <summary>
        /// Enum Persona for value: Persona
        /// </summary>
        [EnumMember(Value = "Persona")]
        Persona = 4,
            
        /// <summary>
        /// Enum SecurityGroup for value: SecurityGroup
        /// </summary>
        [EnumMember(Value = "SecurityGroup")]
        SecurityGroup = 5,
            
        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 6,
            
        /// <summary>
        /// Enum UserInPersona for value: UserInPersona
        /// </summary>
        [EnumMember(Value = "UserInPersona")]
        UserInPersona = 7,
            
        /// <summary>
        /// Enum OtherUsers for value: OtherUsers
        /// </summary>
        [EnumMember(Value = "OtherUsers")]
        OtherUsers = 8,
            
        /// <summary>
        /// Enum Core for value: Core
        /// </summary>
        [EnumMember(Value = "Core")]
        Core = 9,
            
        /// <summary>
        /// Enum BusIntel for value: BusIntel
        /// </summary>
        [EnumMember(Value = "BusIntel")]
        BusIntel = 10,
            
        /// <summary>
        /// Enum FromResource for value: FromResource
        /// </summary>
        [EnumMember(Value = "FromResource")]
        FromResource = 11,
            
        /// <summary>
        /// Enum Site for value: Site
        /// </summary>
        [EnumMember(Value = "Site")]
        Site = 12,
            
        /// <summary>
        /// Enum Custom for value: Custom
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom = 13,
            
        /// <summary>
        /// Enum BusObRecord for value: BusObRecord
        /// </summary>
        [EnumMember(Value = "BusObRecord")]
        BusObRecord = 14
    }
}
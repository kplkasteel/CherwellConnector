using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    /// Defines ActionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionTypeEnum
    {
            
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,
            
        /// <summary>
        /// Enum OneStep for value: OneStep
        /// </summary>
        [EnumMember(Value = "OneStep")]
        OneStep = 2,
            
        /// <summary>
        /// Enum Command for value: Command
        /// </summary>
        [EnumMember(Value = "Command")]
        Command = 3,
            
        /// <summary>
        /// Enum BuiltIn for value: BuiltIn
        /// </summary>
        [EnumMember(Value = "BuiltIn")]
        BuiltIn = 4,
            
        /// <summary>
        /// Enum Category for value: Category
        /// </summary>
        [EnumMember(Value = "Category")]
        Category = 5,
            
        /// <summary>
        /// Enum SearchGrp for value: SearchGrp
        /// </summary>
        [EnumMember(Value = "SearchGrp")]
        SearchGrp = 6,
            
        /// <summary>
        /// Enum Report for value: Report
        /// </summary>
        [EnumMember(Value = "Report")]
        Report = 7,
            
        /// <summary>
        /// Enum Dashboard for value: Dashboard
        /// </summary>
        [EnumMember(Value = "Dashboard")]
        Dashboard = 8,
            
        /// <summary>
        /// Enum Calendar for value: Calendar
        /// </summary>
        [EnumMember(Value = "Calendar")]
        Calendar = 9,
            
        /// <summary>
        /// Enum Visualization for value: Visualization
        /// </summary>
        [EnumMember(Value = "Visualization")]
        Visualization = 10,
            
        /// <summary>
        /// Enum Group for value: Group
        /// </summary>
        [EnumMember(Value = "Group")]
        Group = 11,
            
        /// <summary>
        /// Enum Page for value: Page
        /// </summary>
        [EnumMember(Value = "Page")]
        Page = 12,
            
        /// <summary>
        /// Enum DocRepository for value: DocRepository
        /// </summary>
        [EnumMember(Value = "DocRepository")]
        DocRepository = 13,
            
        /// <summary>
        /// Enum PortalCommand for value: PortalCommand
        /// </summary>
        [EnumMember(Value = "PortalCommand")]
        PortalCommand = 14,
            
        /// <summary>
        /// Enum ActionCatalog for value: ActionCatalog
        /// </summary>
        [EnumMember(Value = "ActionCatalog")]
        ActionCatalog = 15,
            
        /// <summary>
        /// Enum OneStepForRecord for value: OneStepForRecord
        /// </summary>
        [EnumMember(Value = "OneStepForRecord")]
        OneStepForRecord = 16
    }
}
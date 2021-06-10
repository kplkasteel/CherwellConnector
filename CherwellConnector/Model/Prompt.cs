using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Prompt
    /// </summary>
    [DataContract]
    public sealed class Prompt :  IEquatable<Prompt>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ListDisplayOption
        /// </summary>
        [DataMember(Name="listDisplayOption", EmitDefaultValue=false)]
        public ListDisplayOptionEnum? ListDisplayOption { get; set; }
        /// <summary>
        /// Defines PromptType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PromptTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 2,
            
            /// <summary>
            /// Enum Number for value: Number
            /// </summary>
            [EnumMember(Value = "Number")]
            Number = 3,
            
            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 4,
            
            /// <summary>
            /// Enum Logical for value: Logical
            /// </summary>
            [EnumMember(Value = "Logical")]
            Logical = 5,
            
            /// <summary>
            /// Enum Binary for value: Binary
            /// </summary>
            [EnumMember(Value = "Binary")]
            Binary = 6,
            
            /// <summary>
            /// Enum DateOnly for value: DateOnly
            /// </summary>
            [EnumMember(Value = "DateOnly")]
            DateOnly = 7,
            
            /// <summary>
            /// Enum TimeOnly for value: TimeOnly
            /// </summary>
            [EnumMember(Value = "TimeOnly")]
            TimeOnly = 8,
            
            /// <summary>
            /// Enum Json for value: Json
            /// </summary>
            [EnumMember(Value = "Json")]
            Json = 9,
            
            /// <summary>
            /// Enum JsonArray for value: JsonArray
            /// </summary>
            [EnumMember(Value = "JsonArray")]
            JsonArray = 10,
            
            /// <summary>
            /// Enum Xml for value: Xml
            /// </summary>
            [EnumMember(Value = "Xml")]
            Xml = 11,
            
            /// <summary>
            /// Enum XmlCollection for value: XmlCollection
            /// </summary>
            [EnumMember(Value = "XmlCollection")]
            XmlCollection = 12,
            
            /// <summary>
            /// Enum TimeValue for value: TimeValue
            /// </summary>
            [EnumMember(Value = "TimeValue")]
            TimeValue = 13
        }

        /// <summary>
        /// Gets or Sets PromptType
        /// </summary>
        [DataMember(Name="promptType", EmitDefaultValue=false)]
        public PromptTypeEnum? PromptType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        /// <param name="allowValuesOnly">allowValuesOnly.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="collectionStoreEntireRow">collectionStoreEntireRow.</param>
        /// <param name="collectionValueField">collectionValueField.</param>
        /// <param name="constraintXml">constraintXml.</param>
        /// <param name="contents">contents.</param>
        /// <param name="_default">_default.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="isDateRange">isDateRange.</param>
        /// <param name="listDisplayOption">listDisplayOption.</param>
        /// <param name="listReturnFieldId">listReturnFieldId.</param>
        /// <param name="multiLine">multiLine.</param>
        /// <param name="promptId">promptId.</param>
        /// <param name="promptType">promptType.</param>
        /// <param name="promptTypeName">promptTypeName.</param>
        /// <param name="required">required.</param>
        /// <param name="text">text.</param>
        /// <param name="value">value.</param>
        /// <param name="values">values.</param>
        public Prompt(bool? allowValuesOnly = default, string busObId = default, string collectionStoreEntireRow = default, string collectionValueField = default, string constraintXml = default, string contents = default, string _default = default, string fieldId = default, bool? isDateRange = default, ListDisplayOptionEnum? listDisplayOption = default, string listReturnFieldId = default, bool? multiLine = default, string promptId = default, PromptTypeEnum? promptType = default, string promptTypeName = default, bool? required = default, string text = default, Object value = default, List<string> values = default)
        {
            AllowValuesOnly = allowValuesOnly;
            BusObId = busObId;
            CollectionStoreEntireRow = collectionStoreEntireRow;
            CollectionValueField = collectionValueField;
            ConstraintXml = constraintXml;
            Contents = contents;
            Default = _default;
            FieldId = fieldId;
            IsDateRange = isDateRange;
            ListDisplayOption = listDisplayOption;
            ListReturnFieldId = listReturnFieldId;
            MultiLine = multiLine;
            PromptId = promptId;
            PromptType = promptType;
            PromptTypeName = promptTypeName;
            Required = required;
            Text = text;
            Value = value;
            Values = values;
        }
        
        /// <summary>
        /// Gets or Sets AllowValuesOnly
        /// </summary>
        [DataMember(Name="allowValuesOnly", EmitDefaultValue=false)]
        public bool? AllowValuesOnly { get; set; }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets CollectionStoreEntireRow
        /// </summary>
        [DataMember(Name="collectionStoreEntireRow", EmitDefaultValue=false)]
        public string CollectionStoreEntireRow { get; set; }

        /// <summary>
        /// Gets or Sets CollectionValueField
        /// </summary>
        [DataMember(Name="collectionValueField", EmitDefaultValue=false)]
        public string CollectionValueField { get; set; }

        /// <summary>
        /// Gets or Sets ConstraintXml
        /// </summary>
        [DataMember(Name="constraintXml", EmitDefaultValue=false)]
        public string ConstraintXml { get; set; }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public string Contents { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public string Default { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets IsDateRange
        /// </summary>
        [DataMember(Name="isDateRange", EmitDefaultValue=false)]
        public bool? IsDateRange { get; set; }


        /// <summary>
        /// Gets or Sets ListReturnFieldId
        /// </summary>
        [DataMember(Name="listReturnFieldId", EmitDefaultValue=false)]
        public string ListReturnFieldId { get; set; }

        /// <summary>
        /// Gets or Sets MultiLine
        /// </summary>
        [DataMember(Name="multiLine", EmitDefaultValue=false)]
        public bool? MultiLine { get; set; }

        /// <summary>
        /// Gets or Sets PromptId
        /// </summary>
        [DataMember(Name="promptId", EmitDefaultValue=false)]
        public string PromptId { get; set; }


        /// <summary>
        /// Gets or Sets PromptTypeName
        /// </summary>
        [DataMember(Name="promptTypeName", EmitDefaultValue=false)]
        public string PromptTypeName { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Prompt {\n");
            sb.Append("  AllowValuesOnly: ").Append(AllowValuesOnly).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  CollectionStoreEntireRow: ").Append(CollectionStoreEntireRow).Append("\n");
            sb.Append("  CollectionValueField: ").Append(CollectionValueField).Append("\n");
            sb.Append("  ConstraintXml: ").Append(ConstraintXml).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  IsDateRange: ").Append(IsDateRange).Append("\n");
            sb.Append("  ListDisplayOption: ").Append(ListDisplayOption).Append("\n");
            sb.Append("  ListReturnFieldId: ").Append(ListReturnFieldId).Append("\n");
            sb.Append("  MultiLine: ").Append(MultiLine).Append("\n");
            sb.Append("  PromptId: ").Append(PromptId).Append("\n");
            sb.Append("  PromptType: ").Append(PromptType).Append("\n");
            sb.Append("  PromptTypeName: ").Append(PromptTypeName).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Prompt);
        }

        /// <summary>
        /// Returns true if Prompt instances are equal
        /// </summary>
        /// <param name="input">Instance of Prompt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Prompt input)
        {
            if (input == null)
                return false;

            return 
                (
                    AllowValuesOnly == input.AllowValuesOnly ||
                    (AllowValuesOnly != null &&
                    AllowValuesOnly.Equals(input.AllowValuesOnly))
                ) && 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    CollectionStoreEntireRow == input.CollectionStoreEntireRow ||
                    (CollectionStoreEntireRow != null &&
                    CollectionStoreEntireRow.Equals(input.CollectionStoreEntireRow))
                ) && 
                (
                    CollectionValueField == input.CollectionValueField ||
                    (CollectionValueField != null &&
                    CollectionValueField.Equals(input.CollectionValueField))
                ) && 
                (
                    ConstraintXml == input.ConstraintXml ||
                    (ConstraintXml != null &&
                    ConstraintXml.Equals(input.ConstraintXml))
                ) && 
                (
                    Contents == input.Contents ||
                    (Contents != null &&
                    Contents.Equals(input.Contents))
                ) && 
                (
                    Default == input.Default ||
                    (Default != null &&
                    Default.Equals(input.Default))
                ) && 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    IsDateRange == input.IsDateRange ||
                    (IsDateRange != null &&
                    IsDateRange.Equals(input.IsDateRange))
                ) && 
                (
                    ListDisplayOption == input.ListDisplayOption ||
                    (ListDisplayOption != null &&
                    ListDisplayOption.Equals(input.ListDisplayOption))
                ) && 
                (
                    ListReturnFieldId == input.ListReturnFieldId ||
                    (ListReturnFieldId != null &&
                    ListReturnFieldId.Equals(input.ListReturnFieldId))
                ) && 
                (
                    MultiLine == input.MultiLine ||
                    (MultiLine != null &&
                    MultiLine.Equals(input.MultiLine))
                ) && 
                (
                    PromptId == input.PromptId ||
                    (PromptId != null &&
                    PromptId.Equals(input.PromptId))
                ) && 
                (
                    PromptType == input.PromptType ||
                    (PromptType != null &&
                    PromptType.Equals(input.PromptType))
                ) && 
                (
                    PromptTypeName == input.PromptTypeName ||
                    (PromptTypeName != null &&
                    PromptTypeName.Equals(input.PromptTypeName))
                ) && 
                (
                    Required == input.Required ||
                    (Required != null &&
                    Required.Equals(input.Required))
                ) && 
                (
                    Text == input.Text ||
                    (Text != null &&
                    Text.Equals(input.Text))
                ) && 
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
                ) && 
                (
                    Values == input.Values ||
                    Values != null &&
                    Values.SequenceEqual(input.Values)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AllowValuesOnly != null)
                    hashCode = hashCode * 59 + AllowValuesOnly.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (CollectionStoreEntireRow != null)
                    hashCode = hashCode * 59 + CollectionStoreEntireRow.GetHashCode();
                if (CollectionValueField != null)
                    hashCode = hashCode * 59 + CollectionValueField.GetHashCode();
                if (ConstraintXml != null)
                    hashCode = hashCode * 59 + ConstraintXml.GetHashCode();
                if (Contents != null)
                    hashCode = hashCode * 59 + Contents.GetHashCode();
                if (Default != null)
                    hashCode = hashCode * 59 + Default.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (IsDateRange != null)
                    hashCode = hashCode * 59 + IsDateRange.GetHashCode();
                if (ListDisplayOption != null)
                    hashCode = hashCode * 59 + ListDisplayOption.GetHashCode();
                if (ListReturnFieldId != null)
                    hashCode = hashCode * 59 + ListReturnFieldId.GetHashCode();
                if (MultiLine != null)
                    hashCode = hashCode * 59 + MultiLine.GetHashCode();
                if (PromptId != null)
                    hashCode = hashCode * 59 + PromptId.GetHashCode();
                if (PromptType != null)
                    hashCode = hashCode * 59 + PromptType.GetHashCode();
                if (PromptTypeName != null)
                    hashCode = hashCode * 59 + PromptTypeName.GetHashCode();
                if (Required != null)
                    hashCode = hashCode * 59 + Required.GetHashCode();
                if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}

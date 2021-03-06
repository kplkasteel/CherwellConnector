using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     Action
    /// </summary>
    [DataContract]
    public sealed class Action : IEquatable<Action>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="actionCommand">actionCommand.</param>
        /// <param name="actionType">actionType.</param>
        /// <param name="alwaysTextAndImage">alwaysTextAndImage.</param>
        /// <param name="beginGroup">beginGroup.</param>
        /// <param name="childActions">childActions.</param>
        /// <param name="dependencies">dependencies.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="helpText">helpText.</param>
        /// <param name="loginEnabledMode">loginEnabledMode.</param>
        /// <param name="loginVisibilityMode">loginVisibilityMode.</param>
        /// <param name="name">name.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="visible">visible.</param>
        public Action(string actionCommand = default, ActionTypeEnum? actionType = default,
            bool? alwaysTextAndImage = default, bool? beginGroup = default, List<Action> childActions = default,
            List<string> dependencies = default, string displayText = default, bool? enabled = default,
            string galleryImage = default, string helpText = default, LoginEnabledModeEnum? loginEnabledMode = default,
            LoginVisibilityModeEnum? loginVisibilityMode = default, string name = default,
            Dictionary<string, string> parameters = default, bool? visible = default)
        {
            ActionCommand = actionCommand;
            ActionType = actionType;
            AlwaysTextAndImage = alwaysTextAndImage;
            BeginGroup = beginGroup;
            ChildActions = childActions;
            Dependencies = dependencies;
            DisplayText = displayText;
            Enabled = enabled;
            GalleryImage = galleryImage;
            HelpText = helpText;
            LoginEnabledMode = loginEnabledMode;
            LoginVisibilityMode = loginVisibilityMode;
            Name = name;
            Parameters = parameters;
            Visible = visible;
        }

        /// <summary>
        ///     Gets or Sets ActionType
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public ActionTypeEnum? ActionType { get; set; }

        /// <summary>
        ///     Gets or Sets LoginEnabledMode
        /// </summary>
        [DataMember(Name = "loginEnabledMode", EmitDefaultValue = false)]
        public LoginEnabledModeEnum? LoginEnabledMode { get; set; }

        /// <summary>
        ///     Gets or Sets LoginVisibilityMode
        /// </summary>
        [DataMember(Name = "loginVisibilityMode", EmitDefaultValue = false)]
        public LoginVisibilityModeEnum? LoginVisibilityMode { get; set; }

        /// <summary>
        ///     Gets or Sets ActionCommand
        /// </summary>
        [DataMember(Name = "actionCommand", EmitDefaultValue = false)]
        public string ActionCommand { get; set; }


        /// <summary>
        ///     Gets or Sets AlwaysTextAndImage
        /// </summary>
        [DataMember(Name = "alwaysTextAndImage", EmitDefaultValue = false)]
        public bool? AlwaysTextAndImage { get; set; }

        /// <summary>
        ///     Gets or Sets BeginGroup
        /// </summary>
        [DataMember(Name = "beginGroup", EmitDefaultValue = false)]
        public bool? BeginGroup { get; set; }

        /// <summary>
        ///     Gets or Sets ChildActions
        /// </summary>
        [DataMember(Name = "childActions", EmitDefaultValue = false)]
        public List<Action> ChildActions { get; set; }

        /// <summary>
        ///     Gets or Sets Dependencies
        /// </summary>
        [DataMember(Name = "dependencies", EmitDefaultValue = false)]
        public List<string> Dependencies { get; set; }

        /// <summary>
        ///     Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name = "displayText", EmitDefaultValue = false)]
        public string DisplayText { get; set; }

        /// <summary>
        ///     Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        ///     Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }

        /// <summary>
        ///     Gets or Sets HelpText
        /// </summary>
        [DataMember(Name = "helpText", EmitDefaultValue = false)]
        public string HelpText { get; set; }


        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        ///     Gets or Sets Visible
        /// </summary>
        [DataMember(Name = "visible", EmitDefaultValue = false)]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Returns true if Action instances are equal
        /// </summary>
        /// <param name="input">Instance of Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Action input)
        {
            if (input == null)
                return false;

            return
                (
                    ActionCommand == input.ActionCommand ||
                    ActionCommand != null &&
                    ActionCommand.Equals(input.ActionCommand)
                ) &&
                (
                    ActionType == input.ActionType ||
                    ActionType != null &&
                    ActionType.Equals(input.ActionType)
                ) &&
                (
                    AlwaysTextAndImage == input.AlwaysTextAndImage ||
                    AlwaysTextAndImage != null &&
                    AlwaysTextAndImage.Equals(input.AlwaysTextAndImage)
                ) &&
                (
                    BeginGroup == input.BeginGroup ||
                    BeginGroup != null &&
                    BeginGroup.Equals(input.BeginGroup)
                ) &&
                (
                    ChildActions == input.ChildActions ||
                    ChildActions != null &&
                    ChildActions.SequenceEqual(input.ChildActions)
                ) &&
                (
                    Dependencies == input.Dependencies ||
                    Dependencies != null &&
                    Dependencies.SequenceEqual(input.Dependencies)
                ) &&
                (
                    DisplayText == input.DisplayText ||
                    DisplayText != null &&
                    DisplayText.Equals(input.DisplayText)
                ) &&
                (
                    Enabled == input.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(input.Enabled)
                ) &&
                (
                    GalleryImage == input.GalleryImage ||
                    GalleryImage != null &&
                    GalleryImage.Equals(input.GalleryImage)
                ) &&
                (
                    HelpText == input.HelpText ||
                    HelpText != null &&
                    HelpText.Equals(input.HelpText)
                ) &&
                (
                    LoginEnabledMode == input.LoginEnabledMode ||
                    LoginEnabledMode != null &&
                    LoginEnabledMode.Equals(input.LoginEnabledMode)
                ) &&
                (
                    LoginVisibilityMode == input.LoginVisibilityMode ||
                    LoginVisibilityMode != null &&
                    LoginVisibilityMode.Equals(input.LoginVisibilityMode)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Parameters == input.Parameters ||
                    Parameters != null &&
                    Parameters.SequenceEqual(input.Parameters)
                ) &&
                (
                    Visible == input.Visible ||
                    Visible != null &&
                    Visible.Equals(input.Visible)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Action {\n");
            sb.Append("  ActionCommand: ").Append(ActionCommand).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  AlwaysTextAndImage: ").Append(AlwaysTextAndImage).Append("\n");
            sb.Append("  BeginGroup: ").Append(BeginGroup).Append("\n");
            sb.Append("  ChildActions: ").Append(ChildActions).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
            sb.Append("  LoginEnabledMode: ").Append(LoginEnabledMode).Append("\n");
            sb.Append("  LoginVisibilityMode: ").Append(LoginVisibilityMode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Action);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (ActionCommand != null)
                    hashCode = hashCode * 59 + ActionCommand.GetHashCode();
                if (ActionType != null)
                    hashCode = hashCode * 59 + ActionType.GetHashCode();
                if (AlwaysTextAndImage != null)
                    hashCode = hashCode * 59 + AlwaysTextAndImage.GetHashCode();
                if (BeginGroup != null)
                    hashCode = hashCode * 59 + BeginGroup.GetHashCode();
                if (ChildActions != null)
                    hashCode = hashCode * 59 + ChildActions.GetHashCode();
                if (Dependencies != null)
                    hashCode = hashCode * 59 + Dependencies.GetHashCode();
                if (DisplayText != null)
                    hashCode = hashCode * 59 + DisplayText.GetHashCode();
                if (Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (GalleryImage != null)
                    hashCode = hashCode * 59 + GalleryImage.GetHashCode();
                if (HelpText != null)
                    hashCode = hashCode * 59 + HelpText.GetHashCode();
                if (LoginEnabledMode != null)
                    hashCode = hashCode * 59 + LoginEnabledMode.GetHashCode();
                if (LoginVisibilityMode != null)
                    hashCode = hashCode * 59 + LoginVisibilityMode.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Parameters != null)
                    hashCode = hashCode * 59 + Parameters.GetHashCode();
                if (Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();
                return hashCode;
            }
        }
    }
}
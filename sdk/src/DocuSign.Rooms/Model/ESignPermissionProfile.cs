/* 
 * DocuSign Rooms API - v2
 *
 * An API for an integrator to access the features of DocuSign Rooms
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Rooms.Model
{
    /// <summary>
    /// ESignPermissionProfile
    /// </summary>
    [DataContract]
    public partial class ESignPermissionProfile :  IEquatable<ESignPermissionProfile>, IValidatableObject
    {
        public ESignPermissionProfile()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ESignPermissionProfile" /> class.
        /// </summary>
        /// <param name="ESignPermissionProfileId">ESignPermissionProfileId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Settings">Settings.</param>
        public ESignPermissionProfile(string ESignPermissionProfileId = default(string), string Name = default(string), ESignAccountRoleSettings Settings = default(ESignAccountRoleSettings))
        {
            this.ESignPermissionProfileId = ESignPermissionProfileId;
            this.Name = Name;
            this.Settings = Settings;
        }
        
        /// <summary>
        /// Gets or Sets ESignPermissionProfileId
        /// </summary>
        [DataMember(Name="eSignPermissionProfileId", EmitDefaultValue=false)]
        public string ESignPermissionProfileId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public ESignAccountRoleSettings Settings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESignPermissionProfile {\n");
            sb.Append("  ESignPermissionProfileId: ").Append(ESignPermissionProfileId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ESignPermissionProfile);
        }

        /// <summary>
        /// Returns true if ESignPermissionProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of ESignPermissionProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESignPermissionProfile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ESignPermissionProfileId == other.ESignPermissionProfileId ||
                    this.ESignPermissionProfileId != null &&
                    this.ESignPermissionProfileId.Equals(other.ESignPermissionProfileId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ESignPermissionProfileId != null)
                    hash = hash * 59 + this.ESignPermissionProfileId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

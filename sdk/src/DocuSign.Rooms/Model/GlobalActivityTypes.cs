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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.Rooms.Client.SwaggerDateConverter;

namespace DocuSign.Rooms.Model
{
    /// <summary>
    /// GlobalActivityTypes
    /// </summary>
    [DataContract]
    public partial class GlobalActivityTypes :  IEquatable<GlobalActivityTypes>, IValidatableObject
    {
        public GlobalActivityTypes()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalActivityTypes" /> class.
        /// </summary>
        /// <param name="ActivityTypes">ActivityTypes.</param>
        public GlobalActivityTypes(List<ActivityType> ActivityTypes = default(List<ActivityType>))
        {
            this.ActivityTypes = ActivityTypes;
        }
        
        /// <summary>
        /// Gets or Sets ActivityTypes
        /// </summary>
        [DataMember(Name="activityTypes", EmitDefaultValue=false)]
        public List<ActivityType> ActivityTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalActivityTypes {\n");
            sb.Append("  ActivityTypes: ").Append(ActivityTypes).Append("\n");
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
            return this.Equals(obj as GlobalActivityTypes);
        }

        /// <summary>
        /// Returns true if GlobalActivityTypes instances are equal
        /// </summary>
        /// <param name="other">Instance of GlobalActivityTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalActivityTypes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActivityTypes == other.ActivityTypes ||
                    this.ActivityTypes != null &&
                    this.ActivityTypes.SequenceEqual(other.ActivityTypes)
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
                if (this.ActivityTypes != null)
                    hash = hash * 59 + this.ActivityTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
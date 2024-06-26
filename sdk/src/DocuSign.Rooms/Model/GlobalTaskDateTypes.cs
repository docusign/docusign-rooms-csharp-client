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
    /// GlobalTaskDateTypes
    /// </summary>
    [DataContract]
    public partial class GlobalTaskDateTypes :  IEquatable<GlobalTaskDateTypes>, IValidatableObject
    {
        public GlobalTaskDateTypes()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalTaskDateTypes" /> class.
        /// </summary>
        /// <param name="TaskDateTypes">TaskDateTypes.</param>
        public GlobalTaskDateTypes(List<TaskDateType> TaskDateTypes = default(List<TaskDateType>))
        {
            this.TaskDateTypes = TaskDateTypes;
        }
        
        /// <summary>
        /// Gets or Sets TaskDateTypes
        /// </summary>
        [DataMember(Name="taskDateTypes", EmitDefaultValue=false)]
        public List<TaskDateType> TaskDateTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalTaskDateTypes {\n");
            sb.Append("  TaskDateTypes: ").Append(TaskDateTypes).Append("\n");
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
            return this.Equals(obj as GlobalTaskDateTypes);
        }

        /// <summary>
        /// Returns true if GlobalTaskDateTypes instances are equal
        /// </summary>
        /// <param name="other">Instance of GlobalTaskDateTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalTaskDateTypes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskDateTypes == other.TaskDateTypes ||
                    this.TaskDateTypes != null &&
                    this.TaskDateTypes.SequenceEqual(other.TaskDateTypes)
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
                if (this.TaskDateTypes != null)
                    hash = hash * 59 + this.TaskDateTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

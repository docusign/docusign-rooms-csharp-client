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
    /// TaskResponsibilityType
    /// </summary>
    [DataContract]
    public partial class TaskResponsibilityType :  IEquatable<TaskResponsibilityType>, IValidatableObject
    {
        public TaskResponsibilityType()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponsibilityType" /> class.
        /// </summary>
        /// <param name="TaskResponsibilityTypeId">TaskResponsibilityTypeId.</param>
        /// <param name="Name">Name.</param>
        public TaskResponsibilityType(string TaskResponsibilityTypeId = default(string), string Name = default(string))
        {
            this.TaskResponsibilityTypeId = TaskResponsibilityTypeId;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets TaskResponsibilityTypeId
        /// </summary>
        [DataMember(Name="taskResponsibilityTypeId", EmitDefaultValue=false)]
        public string TaskResponsibilityTypeId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskResponsibilityType {\n");
            sb.Append("  TaskResponsibilityTypeId: ").Append(TaskResponsibilityTypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as TaskResponsibilityType);
        }

        /// <summary>
        /// Returns true if TaskResponsibilityType instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskResponsibilityType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskResponsibilityType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskResponsibilityTypeId == other.TaskResponsibilityTypeId ||
                    this.TaskResponsibilityTypeId != null &&
                    this.TaskResponsibilityTypeId.Equals(other.TaskResponsibilityTypeId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.TaskResponsibilityTypeId != null)
                    hash = hash * 59 + this.TaskResponsibilityTypeId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

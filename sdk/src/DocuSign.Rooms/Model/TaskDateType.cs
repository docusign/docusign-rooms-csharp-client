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
    /// TaskDateType
    /// </summary>
    [DataContract]
    public partial class TaskDateType :  IEquatable<TaskDateType>, IValidatableObject
    {
        public TaskDateType()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDateType" /> class.
        /// </summary>
        /// <param name="TaskDateTypeId">TaskDateTypeId.</param>
        /// <param name="Name">Name.</param>
        public TaskDateType(string TaskDateTypeId = default(string), string Name = default(string))
        {
            this.TaskDateTypeId = TaskDateTypeId;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets TaskDateTypeId
        /// </summary>
        [DataMember(Name="taskDateTypeId", EmitDefaultValue=false)]
        public string TaskDateTypeId { get; set; }
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
            sb.Append("class TaskDateType {\n");
            sb.Append("  TaskDateTypeId: ").Append(TaskDateTypeId).Append("\n");
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
            return this.Equals(obj as TaskDateType);
        }

        /// <summary>
        /// Returns true if TaskDateType instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskDateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDateType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskDateTypeId == other.TaskDateTypeId ||
                    this.TaskDateTypeId != null &&
                    this.TaskDateTypeId.Equals(other.TaskDateTypeId)
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
                if (this.TaskDateTypeId != null)
                    hash = hash * 59 + this.TaskDateTypeId.GetHashCode();
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

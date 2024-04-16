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
    /// FormGroupSummary
    /// </summary>
    [DataContract]
    public partial class FormGroupSummary :  IEquatable<FormGroupSummary>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormGroupSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FormGroupSummary()
        {
        }
        
        /// <summary>
        /// Gets or Sets FormGroupId
        /// </summary>
        [DataMember(Name="formGroupId", EmitDefaultValue=false)]
        public string FormGroupId { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Gets or Sets FormCount
        /// </summary>
        [DataMember(Name="formCount", EmitDefaultValue=false)]
        public int? FormCount { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormGroupSummary {\n");
            sb.Append("  FormGroupId: ").Append(FormGroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FormCount: ").Append(FormCount).Append("\n");
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
            return this.Equals(obj as FormGroupSummary);
        }

        /// <summary>
        /// Returns true if FormGroupSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of FormGroupSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormGroupSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FormGroupId == other.FormGroupId ||
                    this.FormGroupId != null &&
                    this.FormGroupId.Equals(other.FormGroupId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FormCount == other.FormCount ||
                    this.FormCount != null &&
                    this.FormCount.Equals(other.FormCount)
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
                if (this.FormGroupId != null)
                    hash = hash * 59 + this.FormGroupId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FormCount != null)
                    hash = hash * 59 + this.FormCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

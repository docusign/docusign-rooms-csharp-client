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
    /// FormLibrarySummary
    /// </summary>
    [DataContract]
    public partial class FormLibrarySummary :  IEquatable<FormLibrarySummary>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLibrarySummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FormLibrarySummary()
        {
        }
        
        /// <summary>
        /// Gets or Sets FormsLibraryId
        /// </summary>
        [DataMember(Name="formsLibraryId", EmitDefaultValue=false)]
        public Guid? FormsLibraryId { get; private set; }
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
            sb.Append("class FormLibrarySummary {\n");
            sb.Append("  FormsLibraryId: ").Append(FormsLibraryId).Append("\n");
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
            return this.Equals(obj as FormLibrarySummary);
        }

        /// <summary>
        /// Returns true if FormLibrarySummary instances are equal
        /// </summary>
        /// <param name="other">Instance of FormLibrarySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormLibrarySummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FormsLibraryId == other.FormsLibraryId ||
                    this.FormsLibraryId != null &&
                    this.FormsLibraryId.Equals(other.FormsLibraryId)
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
                if (this.FormsLibraryId != null)
                    hash = hash * 59 + this.FormsLibraryId.GetHashCode();
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

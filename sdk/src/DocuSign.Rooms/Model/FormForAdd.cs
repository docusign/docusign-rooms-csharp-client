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
    /// FormForAdd
    /// </summary>
    [DataContract]
    public partial class FormForAdd :  IEquatable<FormForAdd>, IValidatableObject
    {
        public FormForAdd()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormForAdd" /> class.
        /// </summary>
        /// <param name="FormId">FormId (required).</param>
        public FormForAdd(Guid? FormId = default(Guid?))
        {
            // to ensure "FormId" is required (not null)
            if (FormId == null)
            {
                throw new InvalidDataException("FormId is a required property for FormForAdd and cannot be null");
            }
            else
            {
                this.FormId = FormId;
            }
        }
        
        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="formId", EmitDefaultValue=false)]
        public Guid? FormId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormForAdd {\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
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
            return this.Equals(obj as FormForAdd);
        }

        /// <summary>
        /// Returns true if FormForAdd instances are equal
        /// </summary>
        /// <param name="other">Instance of FormForAdd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormForAdd other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FormId == other.FormId ||
                    this.FormId != null &&
                    this.FormId.Equals(other.FormId)
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
                if (this.FormId != null)
                    hash = hash * 59 + this.FormId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

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
    /// DesignatedOffice
    /// </summary>
    [DataContract]
    public partial class DesignatedOffice :  IEquatable<DesignatedOffice>, IValidatableObject
    {
        public DesignatedOffice()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignatedOffice" /> class.
        /// </summary>
        /// <param name="OfficeId">OfficeId (required).</param>
        public DesignatedOffice(int? OfficeId = default(int?))
        {
            // to ensure "OfficeId" is required (not null)
            if (OfficeId == null)
            {
                throw new InvalidDataException("OfficeId is a required property for DesignatedOffice and cannot be null");
            }
            else
            {
                this.OfficeId = OfficeId;
            }
        }
        
        /// <summary>
        /// Gets or Sets OfficeId
        /// </summary>
        [DataMember(Name="officeId", EmitDefaultValue=false)]
        public int? OfficeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignatedOffice {\n");
            sb.Append("  OfficeId: ").Append(OfficeId).Append("\n");
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
            return this.Equals(obj as DesignatedOffice);
        }

        /// <summary>
        /// Returns true if DesignatedOffice instances are equal
        /// </summary>
        /// <param name="other">Instance of DesignatedOffice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignatedOffice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OfficeId == other.OfficeId ||
                    this.OfficeId != null &&
                    this.OfficeId.Equals(other.OfficeId)
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
                if (this.OfficeId != null)
                    hash = hash * 59 + this.OfficeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

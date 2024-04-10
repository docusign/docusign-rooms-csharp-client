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
    /// OfficeReferenceCountList
    /// </summary>
    [DataContract]
    public partial class OfficeReferenceCountList :  IEquatable<OfficeReferenceCountList>, IValidatableObject
    {
        public OfficeReferenceCountList()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfficeReferenceCountList" /> class.
        /// </summary>
        /// <param name="ReferencesCounts">ReferencesCounts.</param>
        public OfficeReferenceCountList(List<OfficeReferenceCount> ReferencesCounts = default(List<OfficeReferenceCount>))
        {
            this.ReferencesCounts = ReferencesCounts;
        }
        
        /// <summary>
        /// Gets or Sets ReferencesCounts
        /// </summary>
        [DataMember(Name="referencesCounts", EmitDefaultValue=false)]
        public List<OfficeReferenceCount> ReferencesCounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfficeReferenceCountList {\n");
            sb.Append("  ReferencesCounts: ").Append(ReferencesCounts).Append("\n");
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
            return this.Equals(obj as OfficeReferenceCountList);
        }

        /// <summary>
        /// Returns true if OfficeReferenceCountList instances are equal
        /// </summary>
        /// <param name="other">Instance of OfficeReferenceCountList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfficeReferenceCountList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReferencesCounts == other.ReferencesCounts ||
                    this.ReferencesCounts != null &&
                    this.ReferencesCounts.SequenceEqual(other.ReferencesCounts)
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
                if (this.ReferencesCounts != null)
                    hash = hash * 59 + this.ReferencesCounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

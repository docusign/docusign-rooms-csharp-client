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
    /// RegionReferenceCount
    /// </summary>
    [DataContract]
    public partial class RegionReferenceCount :  IEquatable<RegionReferenceCount>, IValidatableObject
    {
        public RegionReferenceCount()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionReferenceCount" /> class.
        /// </summary>
        /// <param name="ReferenceType">ReferenceType.</param>
        /// <param name="ReferenceCount">ReferenceCount.</param>
        public RegionReferenceCount(string ReferenceType = default(string), int? ReferenceCount = default(int?))
        {
            this.ReferenceType = ReferenceType;
            this.ReferenceCount = ReferenceCount;
        }
        
        /// <summary>
        /// Gets or Sets ReferenceType
        /// </summary>
        [DataMember(Name="referenceType", EmitDefaultValue=false)]
        public string ReferenceType { get; set; }
        /// <summary>
        /// Gets or Sets ReferenceCount
        /// </summary>
        [DataMember(Name="referenceCount", EmitDefaultValue=false)]
        public int? ReferenceCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionReferenceCount {\n");
            sb.Append("  ReferenceType: ").Append(ReferenceType).Append("\n");
            sb.Append("  ReferenceCount: ").Append(ReferenceCount).Append("\n");
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
            return this.Equals(obj as RegionReferenceCount);
        }

        /// <summary>
        /// Returns true if RegionReferenceCount instances are equal
        /// </summary>
        /// <param name="other">Instance of RegionReferenceCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegionReferenceCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReferenceType == other.ReferenceType ||
                    this.ReferenceType != null &&
                    this.ReferenceType.Equals(other.ReferenceType)
                ) && 
                (
                    this.ReferenceCount == other.ReferenceCount ||
                    this.ReferenceCount != null &&
                    this.ReferenceCount.Equals(other.ReferenceCount)
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
                if (this.ReferenceType != null)
                    hash = hash * 59 + this.ReferenceType.GetHashCode();
                if (this.ReferenceCount != null)
                    hash = hash * 59 + this.ReferenceCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

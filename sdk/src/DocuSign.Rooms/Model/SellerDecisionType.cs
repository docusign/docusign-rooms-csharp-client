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
    /// SellerDecisionType
    /// </summary>
    [DataContract]
    public partial class SellerDecisionType :  IEquatable<SellerDecisionType>, IValidatableObject
    {
        public SellerDecisionType()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SellerDecisionType" /> class.
        /// </summary>
        /// <param name="SellerDecisionTypeId">SellerDecisionTypeId.</param>
        /// <param name="Name">Name.</param>
        public SellerDecisionType(string SellerDecisionTypeId = default(string), string Name = default(string))
        {
            this.SellerDecisionTypeId = SellerDecisionTypeId;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets SellerDecisionTypeId
        /// </summary>
        [DataMember(Name="sellerDecisionTypeId", EmitDefaultValue=false)]
        public string SellerDecisionTypeId { get; set; }
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
            sb.Append("class SellerDecisionType {\n");
            sb.Append("  SellerDecisionTypeId: ").Append(SellerDecisionTypeId).Append("\n");
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
            return this.Equals(obj as SellerDecisionType);
        }

        /// <summary>
        /// Returns true if SellerDecisionType instances are equal
        /// </summary>
        /// <param name="other">Instance of SellerDecisionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerDecisionType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SellerDecisionTypeId == other.SellerDecisionTypeId ||
                    this.SellerDecisionTypeId != null &&
                    this.SellerDecisionTypeId.Equals(other.SellerDecisionTypeId)
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
                if (this.SellerDecisionTypeId != null)
                    hash = hash * 59 + this.SellerDecisionTypeId.GetHashCode();
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

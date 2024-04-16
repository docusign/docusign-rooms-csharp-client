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
    /// GlobalSellerDecisionTypes
    /// </summary>
    [DataContract]
    public partial class GlobalSellerDecisionTypes :  IEquatable<GlobalSellerDecisionTypes>, IValidatableObject
    {
        public GlobalSellerDecisionTypes()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSellerDecisionTypes" /> class.
        /// </summary>
        /// <param name="SellerDecisionTypes">SellerDecisionTypes.</param>
        public GlobalSellerDecisionTypes(List<SellerDecisionType> SellerDecisionTypes = default(List<SellerDecisionType>))
        {
            this.SellerDecisionTypes = SellerDecisionTypes;
        }
        
        /// <summary>
        /// Gets or Sets SellerDecisionTypes
        /// </summary>
        [DataMember(Name="sellerDecisionTypes", EmitDefaultValue=false)]
        public List<SellerDecisionType> SellerDecisionTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalSellerDecisionTypes {\n");
            sb.Append("  SellerDecisionTypes: ").Append(SellerDecisionTypes).Append("\n");
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
            return this.Equals(obj as GlobalSellerDecisionTypes);
        }

        /// <summary>
        /// Returns true if GlobalSellerDecisionTypes instances are equal
        /// </summary>
        /// <param name="other">Instance of GlobalSellerDecisionTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalSellerDecisionTypes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SellerDecisionTypes == other.SellerDecisionTypes ||
                    this.SellerDecisionTypes != null &&
                    this.SellerDecisionTypes.SequenceEqual(other.SellerDecisionTypes)
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
                if (this.SellerDecisionTypes != null)
                    hash = hash * 59 + this.SellerDecisionTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

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
    /// FinancingType
    /// </summary>
    [DataContract]
    public partial class FinancingType :  IEquatable<FinancingType>, IValidatableObject
    {
        public FinancingType()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancingType" /> class.
        /// </summary>
        /// <param name="FinancingTypeId">FinancingTypeId.</param>
        /// <param name="Name">Name.</param>
        public FinancingType(string FinancingTypeId = default(string), string Name = default(string))
        {
            this.FinancingTypeId = FinancingTypeId;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets FinancingTypeId
        /// </summary>
        [DataMember(Name="financingTypeId", EmitDefaultValue=false)]
        public string FinancingTypeId { get; set; }
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
            sb.Append("class FinancingType {\n");
            sb.Append("  FinancingTypeId: ").Append(FinancingTypeId).Append("\n");
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
            return this.Equals(obj as FinancingType);
        }

        /// <summary>
        /// Returns true if FinancingType instances are equal
        /// </summary>
        /// <param name="other">Instance of FinancingType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancingType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FinancingTypeId == other.FinancingTypeId ||
                    this.FinancingTypeId != null &&
                    this.FinancingTypeId.Equals(other.FinancingTypeId)
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
                if (this.FinancingTypeId != null)
                    hash = hash * 59 + this.FinancingTypeId.GetHashCode();
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

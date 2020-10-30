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
    /// GlobalSpecialCircumstanceTypes
    /// </summary>
    [DataContract]
    public partial class GlobalSpecialCircumstanceTypes :  IEquatable<GlobalSpecialCircumstanceTypes>, IValidatableObject
    {
        public GlobalSpecialCircumstanceTypes()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSpecialCircumstanceTypes" /> class.
        /// </summary>
        /// <param name="SpecialCircumstanceTypes">SpecialCircumstanceTypes.</param>
        public GlobalSpecialCircumstanceTypes(List<SpecialCircumstanceType> SpecialCircumstanceTypes = default(List<SpecialCircumstanceType>))
        {
            this.SpecialCircumstanceTypes = SpecialCircumstanceTypes;
        }
        
        /// <summary>
        /// Gets or Sets SpecialCircumstanceTypes
        /// </summary>
        [DataMember(Name="specialCircumstanceTypes", EmitDefaultValue=false)]
        public List<SpecialCircumstanceType> SpecialCircumstanceTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalSpecialCircumstanceTypes {\n");
            sb.Append("  SpecialCircumstanceTypes: ").Append(SpecialCircumstanceTypes).Append("\n");
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
            return this.Equals(obj as GlobalSpecialCircumstanceTypes);
        }

        /// <summary>
        /// Returns true if GlobalSpecialCircumstanceTypes instances are equal
        /// </summary>
        /// <param name="other">Instance of GlobalSpecialCircumstanceTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalSpecialCircumstanceTypes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SpecialCircumstanceTypes == other.SpecialCircumstanceTypes ||
                    this.SpecialCircumstanceTypes != null &&
                    this.SpecialCircumstanceTypes.SequenceEqual(other.SpecialCircumstanceTypes)
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
                if (this.SpecialCircumstanceTypes != null)
                    hash = hash * 59 + this.SpecialCircumstanceTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

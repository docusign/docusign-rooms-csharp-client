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
    /// CustomData
    /// </summary>
    [DataContract]
    public partial class CustomData :  IEquatable<CustomData>, IValidatableObject
    {
        public CustomData()
        {
            // Empty Constructor
        }

        
        /// <summary>
        /// Gets or Sets IsRequiredOnCreate
        /// </summary>
        [DataMember(Name="isRequiredOnCreate", EmitDefaultValue=false)]
        public bool? IsRequiredOnCreate { get; private set; }
        /// <summary>
        /// Gets or Sets IsRequiredOnSubmit
        /// </summary>
        [DataMember(Name="isRequiredOnSubmit", EmitDefaultValue=false)]
        public bool? IsRequiredOnSubmit { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomData {\n");
            sb.Append("  IsRequiredOnCreate: ").Append(IsRequiredOnCreate).Append("\n");
            sb.Append("  IsRequiredOnSubmit: ").Append(IsRequiredOnSubmit).Append("\n");
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
            return this.Equals(obj as CustomData);
        }

        /// <summary>
        /// Returns true if CustomData instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsRequiredOnCreate == other.IsRequiredOnCreate ||
                    this.IsRequiredOnCreate != null &&
                    this.IsRequiredOnCreate.Equals(other.IsRequiredOnCreate)
                ) && 
                (
                    this.IsRequiredOnSubmit == other.IsRequiredOnSubmit ||
                    this.IsRequiredOnSubmit != null &&
                    this.IsRequiredOnSubmit.Equals(other.IsRequiredOnSubmit)
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
                if (this.IsRequiredOnCreate != null)
                    hash = hash * 59 + this.IsRequiredOnCreate.GetHashCode();
                if (this.IsRequiredOnSubmit != null)
                    hash = hash * 59 + this.IsRequiredOnSubmit.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

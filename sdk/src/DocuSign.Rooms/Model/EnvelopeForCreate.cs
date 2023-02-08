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
    /// EnvelopeForCreate
    /// </summary>
    [DataContract]
    public partial class EnvelopeForCreate :  IEquatable<EnvelopeForCreate>, IValidatableObject
    {
        public EnvelopeForCreate()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeForCreate" /> class.
        /// </summary>
        /// <param name="EnvelopeName">EnvelopeName.</param>
        /// <param name="DocumentIds">DocumentIds.</param>
        public EnvelopeForCreate(string EnvelopeName = default(string), List<int?> DocumentIds = default(List<int?>))
        {
            this.EnvelopeName = EnvelopeName;
            this.DocumentIds = DocumentIds;
        }
        
        /// <summary>
        /// Gets or Sets EnvelopeName
        /// </summary>
        [DataMember(Name="envelopeName", EmitDefaultValue=false)]
        public string EnvelopeName { get; set; }
        /// <summary>
        /// Gets or Sets DocumentIds
        /// </summary>
        [DataMember(Name="documentIds", EmitDefaultValue=false)]
        public List<int?> DocumentIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeForCreate {\n");
            sb.Append("  EnvelopeName: ").Append(EnvelopeName).Append("\n");
            sb.Append("  DocumentIds: ").Append(DocumentIds).Append("\n");
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
            return this.Equals(obj as EnvelopeForCreate);
        }

        /// <summary>
        /// Returns true if EnvelopeForCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeForCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeForCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeName == other.EnvelopeName ||
                    this.EnvelopeName != null &&
                    this.EnvelopeName.Equals(other.EnvelopeName)
                ) && 
                (
                    this.DocumentIds == other.DocumentIds ||
                    this.DocumentIds != null &&
                    this.DocumentIds.SequenceEqual(other.DocumentIds)
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
                if (this.EnvelopeName != null)
                    hash = hash * 59 + this.EnvelopeName.GetHashCode();
                if (this.DocumentIds != null)
                    hash = hash * 59 + this.DocumentIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
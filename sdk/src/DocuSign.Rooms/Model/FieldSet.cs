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
    /// FieldSet
    /// </summary>
    [DataContract]
    public partial class FieldSet :  IEquatable<FieldSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FieldSet()
        {
        }
        
        /// <summary>
        /// Gets or Sets FieldSetId
        /// </summary>
        [DataMember(Name="fieldSetId", EmitDefaultValue=false)]
        public Guid? FieldSetId { get; private set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<Field> Fields { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldSet {\n");
            sb.Append("  FieldSetId: ").Append(FieldSetId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(obj as FieldSet);
        }

        /// <summary>
        /// Returns true if FieldSet instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldSetId == other.FieldSetId ||
                    this.FieldSetId != null &&
                    this.FieldSetId.Equals(other.FieldSetId)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
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
                if (this.FieldSetId != null)
                    hash = hash * 59 + this.FieldSetId.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

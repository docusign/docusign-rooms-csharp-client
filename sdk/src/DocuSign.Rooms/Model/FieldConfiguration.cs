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
    /// FieldConfiguration
    /// </summary>
    [DataContract]
    public partial class FieldConfiguration :  IEquatable<FieldConfiguration>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FieldConfiguration()
        {
        }
        
        /// <summary>
        /// Gets or Sets MaxValue
        /// </summary>
        [DataMember(Name="maxValue", EmitDefaultValue=false)]
        public double? MaxValue { get; private set; }
        /// <summary>
        /// Gets or Sets MinValue
        /// </summary>
        [DataMember(Name="minValue", EmitDefaultValue=false)]
        public double? MinValue { get; private set; }
        /// <summary>
        /// Gets or Sets MultipleOf
        /// </summary>
        [DataMember(Name="multipleOf", EmitDefaultValue=false)]
        public double? MultipleOf { get; private set; }
        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; private set; }
        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name="minLength", EmitDefaultValue=false)]
        public int? MinLength { get; private set; }
        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public string Pattern { get; private set; }
        /// <summary>
        /// Gets or Sets IsPublisher
        /// </summary>
        [DataMember(Name="isPublisher", EmitDefaultValue=false)]
        public bool? IsPublisher { get; private set; }
        /// <summary>
        /// Gets or Sets DependsOn
        /// </summary>
        [DataMember(Name="dependsOn", EmitDefaultValue=false)]
        public List<DependsOn> DependsOn { get; private set; }
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<SelectListFieldOption> Options { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldConfiguration {\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MultipleOf: ").Append(MultipleOf).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  IsPublisher: ").Append(IsPublisher).Append("\n");
            sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(obj as FieldConfiguration);
        }

        /// <summary>
        /// Returns true if FieldConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaxValue == other.MaxValue ||
                    this.MaxValue != null &&
                    this.MaxValue.Equals(other.MaxValue)
                ) && 
                (
                    this.MinValue == other.MinValue ||
                    this.MinValue != null &&
                    this.MinValue.Equals(other.MinValue)
                ) && 
                (
                    this.MultipleOf == other.MultipleOf ||
                    this.MultipleOf != null &&
                    this.MultipleOf.Equals(other.MultipleOf)
                ) && 
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
                ) && 
                (
                    this.MinLength == other.MinLength ||
                    this.MinLength != null &&
                    this.MinLength.Equals(other.MinLength)
                ) && 
                (
                    this.Pattern == other.Pattern ||
                    this.Pattern != null &&
                    this.Pattern.Equals(other.Pattern)
                ) && 
                (
                    this.IsPublisher == other.IsPublisher ||
                    this.IsPublisher != null &&
                    this.IsPublisher.Equals(other.IsPublisher)
                ) && 
                (
                    this.DependsOn == other.DependsOn ||
                    this.DependsOn != null &&
                    this.DependsOn.SequenceEqual(other.DependsOn)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
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
                if (this.MaxValue != null)
                    hash = hash * 59 + this.MaxValue.GetHashCode();
                if (this.MinValue != null)
                    hash = hash * 59 + this.MinValue.GetHashCode();
                if (this.MultipleOf != null)
                    hash = hash * 59 + this.MultipleOf.GetHashCode();
                if (this.MaxLength != null)
                    hash = hash * 59 + this.MaxLength.GetHashCode();
                if (this.MinLength != null)
                    hash = hash * 59 + this.MinLength.GetHashCode();
                if (this.Pattern != null)
                    hash = hash * 59 + this.Pattern.GetHashCode();
                if (this.IsPublisher != null)
                    hash = hash * 59 + this.IsPublisher.GetHashCode();
                if (this.DependsOn != null)
                    hash = hash * 59 + this.DependsOn.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

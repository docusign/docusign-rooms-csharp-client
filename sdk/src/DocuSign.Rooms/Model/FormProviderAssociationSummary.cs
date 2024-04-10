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
    /// FormProviderAssociationSummary
    /// </summary>
    [DataContract]
    public partial class FormProviderAssociationSummary :  IEquatable<FormProviderAssociationSummary>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormProviderAssociationSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FormProviderAssociationSummary()
        {
        }
        
        /// <summary>
        /// Gets or Sets AssociationId
        /// </summary>
        [DataMember(Name="associationId", EmitDefaultValue=false)]
        public string AssociationId { get; private set; }
        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name="providerId", EmitDefaultValue=false)]
        public string ProviderId { get; private set; }
        /// <summary>
        /// Gets or Sets LastUpdateDate
        /// </summary>
        [DataMember(Name="lastUpdateDate", EmitDefaultValue=false)]
        public DateTime? LastUpdateDate { get; private set; }
        /// <summary>
        /// Gets or Sets FormProviderAssociationGuid
        /// </summary>
        [DataMember(Name="formProviderAssociationGuid", EmitDefaultValue=false)]
        public Guid? FormProviderAssociationGuid { get; private set; }
        /// <summary>
        /// Gets or Sets FormProviderAssociationName
        /// </summary>
        [DataMember(Name="formProviderAssociationName", EmitDefaultValue=false)]
        public string FormProviderAssociationName { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormProviderAssociationSummary {\n");
            sb.Append("  AssociationId: ").Append(AssociationId).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  FormProviderAssociationGuid: ").Append(FormProviderAssociationGuid).Append("\n");
            sb.Append("  FormProviderAssociationName: ").Append(FormProviderAssociationName).Append("\n");
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
            return this.Equals(obj as FormProviderAssociationSummary);
        }

        /// <summary>
        /// Returns true if FormProviderAssociationSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of FormProviderAssociationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormProviderAssociationSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssociationId == other.AssociationId ||
                    this.AssociationId != null &&
                    this.AssociationId.Equals(other.AssociationId)
                ) && 
                (
                    this.ProviderId == other.ProviderId ||
                    this.ProviderId != null &&
                    this.ProviderId.Equals(other.ProviderId)
                ) && 
                (
                    this.LastUpdateDate == other.LastUpdateDate ||
                    this.LastUpdateDate != null &&
                    this.LastUpdateDate.Equals(other.LastUpdateDate)
                ) && 
                (
                    this.FormProviderAssociationGuid == other.FormProviderAssociationGuid ||
                    this.FormProviderAssociationGuid != null &&
                    this.FormProviderAssociationGuid.Equals(other.FormProviderAssociationGuid)
                ) && 
                (
                    this.FormProviderAssociationName == other.FormProviderAssociationName ||
                    this.FormProviderAssociationName != null &&
                    this.FormProviderAssociationName.Equals(other.FormProviderAssociationName)
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
                if (this.AssociationId != null)
                    hash = hash * 59 + this.AssociationId.GetHashCode();
                if (this.ProviderId != null)
                    hash = hash * 59 + this.ProviderId.GetHashCode();
                if (this.LastUpdateDate != null)
                    hash = hash * 59 + this.LastUpdateDate.GetHashCode();
                if (this.FormProviderAssociationGuid != null)
                    hash = hash * 59 + this.FormProviderAssociationGuid.GetHashCode();
                if (this.FormProviderAssociationName != null)
                    hash = hash * 59 + this.FormProviderAssociationName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

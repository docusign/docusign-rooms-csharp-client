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
    /// AccountSummary
    /// </summary>
    [DataContract]
    public partial class AccountSummary :  IEquatable<AccountSummary>, IValidatableObject
    {
        public AccountSummary()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Defines CompanyVersion
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductVersion
        {
            
            /// <summary>
            /// Enum V5 for value: v5
            /// </summary>
            [EnumMember(Value = "v5")]
            V5 = 1,
            
            /// <summary>
            /// Enum V6 for value: v6
            /// </summary>
            [EnumMember(Value = "v6")]
            V6 = 2
        }

        /// <summary>
        /// Gets or Sets CompanyVersion
        /// </summary>
        [DataMember(Name="companyVersion", EmitDefaultValue=false)]
        public ProductVersion? CompanyVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSummary" /> class.
        /// </summary>
        /// <param name="CompanyVersion">CompanyVersion.</param>
        public AccountSummary(ProductVersion? CompanyVersion = default(ProductVersion?))
        {
            this.CompanyVersion = CompanyVersion;
        }
        
        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public int? CompanyId { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Gets or Sets DocuSignAccountGuid
        /// </summary>
        [DataMember(Name="docuSignAccountGuid", EmitDefaultValue=false)]
        public string DocuSignAccountGuid { get; private set; }
        /// <summary>
        /// Gets or Sets DefaultFieldSetId
        /// </summary>
        [DataMember(Name="defaultFieldSetId", EmitDefaultValue=false)]
        public Guid? DefaultFieldSetId { get; private set; }
        /// <summary>
        /// Gets or Sets RequireOfficeLibraryAssignments
        /// </summary>
        [DataMember(Name="requireOfficeLibraryAssignments", EmitDefaultValue=false)]
        public bool? RequireOfficeLibraryAssignments { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSummary {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CompanyVersion: ").Append(CompanyVersion).Append("\n");
            sb.Append("  DocuSignAccountGuid: ").Append(DocuSignAccountGuid).Append("\n");
            sb.Append("  DefaultFieldSetId: ").Append(DefaultFieldSetId).Append("\n");
            sb.Append("  RequireOfficeLibraryAssignments: ").Append(RequireOfficeLibraryAssignments).Append("\n");
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
            return this.Equals(obj as AccountSummary);
        }

        /// <summary>
        /// Returns true if AccountSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CompanyVersion == other.CompanyVersion ||
                    this.CompanyVersion != null &&
                    this.CompanyVersion.Equals(other.CompanyVersion)
                ) && 
                (
                    this.DocuSignAccountGuid == other.DocuSignAccountGuid ||
                    this.DocuSignAccountGuid != null &&
                    this.DocuSignAccountGuid.Equals(other.DocuSignAccountGuid)
                ) && 
                (
                    this.DefaultFieldSetId == other.DefaultFieldSetId ||
                    this.DefaultFieldSetId != null &&
                    this.DefaultFieldSetId.Equals(other.DefaultFieldSetId)
                ) && 
                (
                    this.RequireOfficeLibraryAssignments == other.RequireOfficeLibraryAssignments ||
                    this.RequireOfficeLibraryAssignments != null &&
                    this.RequireOfficeLibraryAssignments.Equals(other.RequireOfficeLibraryAssignments)
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
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.CompanyVersion != null)
                    hash = hash * 59 + this.CompanyVersion.GetHashCode();
                if (this.DocuSignAccountGuid != null)
                    hash = hash * 59 + this.DocuSignAccountGuid.GetHashCode();
                if (this.DefaultFieldSetId != null)
                    hash = hash * 59 + this.DefaultFieldSetId.GetHashCode();
                if (this.RequireOfficeLibraryAssignments != null)
                    hash = hash * 59 + this.RequireOfficeLibraryAssignments.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

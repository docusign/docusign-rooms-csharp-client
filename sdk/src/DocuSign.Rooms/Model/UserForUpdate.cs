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
    /// UserForUpdate
    /// </summary>
    [DataContract]
    public partial class UserForUpdate :  IEquatable<UserForUpdate>, IValidatableObject
    {
        public UserForUpdate()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdate" /> class.
        /// </summary>
        /// <param name="DefaultOfficeId">DefaultOfficeId (required).</param>
        public UserForUpdate(int? DefaultOfficeId = default(int?))
        {
            // to ensure "DefaultOfficeId" is required (not null)
            if (DefaultOfficeId == null)
            {
                throw new InvalidDataException("DefaultOfficeId is a required property for UserForUpdate and cannot be null");
            }
            else
            {
                this.DefaultOfficeId = DefaultOfficeId;
            }
        }
        
        /// <summary>
        /// Gets or Sets DefaultOfficeId
        /// </summary>
        [DataMember(Name="defaultOfficeId", EmitDefaultValue=false)]
        public int? DefaultOfficeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserForUpdate {\n");
            sb.Append("  DefaultOfficeId: ").Append(DefaultOfficeId).Append("\n");
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
            return this.Equals(obj as UserForUpdate);
        }

        /// <summary>
        /// Returns true if UserForUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of UserForUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserForUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DefaultOfficeId == other.DefaultOfficeId ||
                    this.DefaultOfficeId != null &&
                    this.DefaultOfficeId.Equals(other.DefaultOfficeId)
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
                if (this.DefaultOfficeId != null)
                    hash = hash * 59 + this.DefaultOfficeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

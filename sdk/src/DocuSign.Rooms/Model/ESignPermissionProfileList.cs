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
    /// ESignPermissionProfileList
    /// </summary>
    [DataContract]
    public partial class ESignPermissionProfileList :  IEquatable<ESignPermissionProfileList>, IValidatableObject
    {
        public ESignPermissionProfileList()
        {
            // Empty Constructor
        }
        
        /// <summary>
        /// Gets or Sets PermissionProfiles
        /// </summary>
        [DataMember(Name="permissionProfiles", EmitDefaultValue=false)]
        public List<ESignPermissionProfile> PermissionProfiles { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESignPermissionProfileList {\n");
            sb.Append("  PermissionProfiles: ").Append(PermissionProfiles).Append("\n");
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
            return this.Equals(obj as ESignPermissionProfileList);
        }

        /// <summary>
        /// Returns true if ESignPermissionProfileList instances are equal
        /// </summary>
        /// <param name="other">Instance of ESignPermissionProfileList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESignPermissionProfileList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PermissionProfiles == other.PermissionProfiles ||
                    this.PermissionProfiles != null &&
                    this.PermissionProfiles.SequenceEqual(other.PermissionProfiles)
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
                if (this.PermissionProfiles != null)
                    hash = hash * 59 + this.PermissionProfiles.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

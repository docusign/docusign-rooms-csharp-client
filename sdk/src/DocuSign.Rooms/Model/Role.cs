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
    /// Role
    /// </summary>
    [DataContract]
    public partial class Role :  IEquatable<Role>, IValidatableObject
    {
        public Role()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="RoleId">RoleId.</param>
        /// <param name="LegacyRoleId">LegacyRoleId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="IsDefaultForAdmin">IsDefaultForAdmin.</param>
        /// <param name="IsExternal">IsExternal.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="IsAssigned">IsAssigned.</param>
        /// <param name="Permissions">Permissions.</param>
        public Role(int? RoleId = default(int?), string LegacyRoleId = default(string), string Name = default(string), bool? IsDefaultForAdmin = default(bool?), bool? IsExternal = default(bool?), DateTime? CreatedDate = default(DateTime?), bool? IsAssigned = default(bool?), Permissions Permissions = default(Permissions))
        {
            this.RoleId = RoleId;
            this.LegacyRoleId = LegacyRoleId;
            this.Name = Name;
            this.IsDefaultForAdmin = IsDefaultForAdmin;
            this.IsExternal = IsExternal;
            this.CreatedDate = CreatedDate;
            this.IsAssigned = IsAssigned;
            this.Permissions = Permissions;
        }
        
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public int? RoleId { get; set; }
        /// <summary>
        /// Gets or Sets LegacyRoleId
        /// </summary>
        [DataMember(Name="legacyRoleId", EmitDefaultValue=false)]
        public string LegacyRoleId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets IsDefaultForAdmin
        /// </summary>
        [DataMember(Name="isDefaultForAdmin", EmitDefaultValue=false)]
        public bool? IsDefaultForAdmin { get; set; }
        /// <summary>
        /// Gets or Sets IsExternal
        /// </summary>
        [DataMember(Name="isExternal", EmitDefaultValue=false)]
        public bool? IsExternal { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets IsAssigned
        /// </summary>
        [DataMember(Name="isAssigned", EmitDefaultValue=false)]
        public bool? IsAssigned { get; set; }
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public Permissions Permissions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Role {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  LegacyRoleId: ").Append(LegacyRoleId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsDefaultForAdmin: ").Append(IsDefaultForAdmin).Append("\n");
            sb.Append("  IsExternal: ").Append(IsExternal).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  IsAssigned: ").Append(IsAssigned).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(obj as Role);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="other">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.LegacyRoleId == other.LegacyRoleId ||
                    this.LegacyRoleId != null &&
                    this.LegacyRoleId.Equals(other.LegacyRoleId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.IsDefaultForAdmin == other.IsDefaultForAdmin ||
                    this.IsDefaultForAdmin != null &&
                    this.IsDefaultForAdmin.Equals(other.IsDefaultForAdmin)
                ) && 
                (
                    this.IsExternal == other.IsExternal ||
                    this.IsExternal != null &&
                    this.IsExternal.Equals(other.IsExternal)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.IsAssigned == other.IsAssigned ||
                    this.IsAssigned != null &&
                    this.IsAssigned.Equals(other.IsAssigned)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.Equals(other.Permissions)
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
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.LegacyRoleId != null)
                    hash = hash * 59 + this.LegacyRoleId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.IsDefaultForAdmin != null)
                    hash = hash * 59 + this.IsDefaultForAdmin.GetHashCode();
                if (this.IsExternal != null)
                    hash = hash * 59 + this.IsExternal.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.IsAssigned != null)
                    hash = hash * 59 + this.IsAssigned.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

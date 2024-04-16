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
    /// RoomUserSummary
    /// </summary>
    [DataContract]
    public partial class RoomUserSummary :  IEquatable<RoomUserSummary>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomUserSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RoomUserSummary()
        {
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; private set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; private set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; private set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; private set; }
        /// <summary>
        /// Gets or Sets TransactionSideId
        /// </summary>
        [DataMember(Name="transactionSideId", EmitDefaultValue=false)]
        public string TransactionSideId { get; private set; }
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public int? RoleId { get; private set; }
        /// <summary>
        /// Gets or Sets TitleId
        /// </summary>
        [DataMember(Name="titleId", EmitDefaultValue=false)]
        public int? TitleId { get; private set; }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; private set; }
        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomUserSummary {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  TransactionSideId: ").Append(TransactionSideId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  TitleId: ").Append(TitleId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
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
            return this.Equals(obj as RoomUserSummary);
        }

        /// <summary>
        /// Returns true if RoomUserSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomUserSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomUserSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.TransactionSideId == other.TransactionSideId ||
                    this.TransactionSideId != null &&
                    this.TransactionSideId.Equals(other.TransactionSideId)
                ) && 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.TitleId == other.TitleId ||
                    this.TitleId != null &&
                    this.TitleId.Equals(other.TitleId)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.TransactionSideId != null)
                    hash = hash * 59 + this.TransactionSideId.GetHashCode();
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.TitleId != null)
                    hash = hash * 59 + this.TitleId.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.RoleName != null)
                    hash = hash * 59 + this.RoleName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

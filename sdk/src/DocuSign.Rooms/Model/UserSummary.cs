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
    /// UserSummary
    /// </summary>
    [DataContract]
    public partial class UserSummary :  IEquatable<UserSummary>, IValidatableObject
    {
        public UserSummary()
        {
            // Empty Constructor
        }

                /// <summary>
        /// Defines AccessLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessLevelEnum
        {
            
            /// <summary>
            /// Enum Contributor for value: Contributor
            /// </summary>
            [EnumMember(Value = "Contributor")]
            Contributor = 1,
            
            /// <summary>
            /// Enum Office for value: Office
            /// </summary>
            [EnumMember(Value = "Office")]
            Office = 2,
            
            /// <summary>
            /// Enum Region for value: Region
            /// </summary>
            [EnumMember(Value = "Region")]
            Region = 3,
            
            /// <summary>
            /// Enum Company for value: Company
            /// </summary>
            [EnumMember(Value = "Company")]
            Company = 4,
            
            /// <summary>
            /// Enum Admin for value: Admin
            /// </summary>
            [EnumMember(Value = "Admin")]
            Admin = 5
        }

        /// <summary>
        /// Gets or Sets AccessLevel
        /// </summary>
        [DataMember(Name="accessLevel", EmitDefaultValue=false)]
        public AccessLevelEnum? AccessLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSummary" /> class.
        /// </summary>
        /// <param name="AccessLevel">AccessLevel.</param>
        public UserSummary(AccessLevelEnum? AccessLevel = default(AccessLevelEnum?))
        {
            this.AccessLevel = AccessLevel;
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
        /// Gets or Sets IsLockedOut
        /// </summary>
        [DataMember(Name="isLockedOut", EmitDefaultValue=false)]
        public bool? IsLockedOut { get; private set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
        /// <summary>
        /// Gets or Sets DefaultOfficeId
        /// </summary>
        [DataMember(Name="defaultOfficeId", EmitDefaultValue=false)]
        public int? DefaultOfficeId { get; private set; }
        /// <summary>
        /// Gets or Sets TitleId
        /// </summary>
        [DataMember(Name="titleId", EmitDefaultValue=false)]
        public int? TitleId { get; private set; }
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public int? RoleId { get; private set; }
        /// <summary>
        /// Gets or Sets ProfileImageUrl
        /// </summary>
        [DataMember(Name="profileImageUrl", EmitDefaultValue=false)]
        public string ProfileImageUrl { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSummary {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IsLockedOut: ").Append(IsLockedOut).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  DefaultOfficeId: ").Append(DefaultOfficeId).Append("\n");
            sb.Append("  TitleId: ").Append(TitleId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
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
            return this.Equals(obj as UserSummary);
        }

        /// <summary>
        /// Returns true if UserSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSummary other)
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
                    this.IsLockedOut == other.IsLockedOut ||
                    this.IsLockedOut != null &&
                    this.IsLockedOut.Equals(other.IsLockedOut)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.AccessLevel == other.AccessLevel ||
                    this.AccessLevel != null &&
                    this.AccessLevel.Equals(other.AccessLevel)
                ) && 
                (
                    this.DefaultOfficeId == other.DefaultOfficeId ||
                    this.DefaultOfficeId != null &&
                    this.DefaultOfficeId.Equals(other.DefaultOfficeId)
                ) && 
                (
                    this.TitleId == other.TitleId ||
                    this.TitleId != null &&
                    this.TitleId.Equals(other.TitleId)
                ) && 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.ProfileImageUrl == other.ProfileImageUrl ||
                    this.ProfileImageUrl != null &&
                    this.ProfileImageUrl.Equals(other.ProfileImageUrl)
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
                if (this.IsLockedOut != null)
                    hash = hash * 59 + this.IsLockedOut.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.AccessLevel != null)
                    hash = hash * 59 + this.AccessLevel.GetHashCode();
                if (this.DefaultOfficeId != null)
                    hash = hash * 59 + this.DefaultOfficeId.GetHashCode();
                if (this.TitleId != null)
                    hash = hash * 59 + this.TitleId.GetHashCode();
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.ProfileImageUrl != null)
                    hash = hash * 59 + this.ProfileImageUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

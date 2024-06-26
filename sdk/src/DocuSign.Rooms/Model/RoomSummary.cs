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
    /// RoomSummary
    /// </summary>
    [DataContract]
    public partial class RoomSummary :  IEquatable<RoomSummary>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RoomSummary()
        {
        }
        
        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public int? RoomId { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Gets or Sets OfficeId
        /// </summary>
        [DataMember(Name="officeId", EmitDefaultValue=false)]
        public int? OfficeId { get; private set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        /// <summary>
        /// Gets or Sets SubmittedForReviewDate
        /// </summary>
        [DataMember(Name="submittedForReviewDate", EmitDefaultValue=false)]
        public DateTime? SubmittedForReviewDate { get; private set; }
        /// <summary>
        /// Gets or Sets ClosedDate
        /// </summary>
        [DataMember(Name="closedDate", EmitDefaultValue=false)]
        public DateTime? ClosedDate { get; private set; }
        /// <summary>
        /// Gets or Sets RejectedDate
        /// </summary>
        [DataMember(Name="rejectedDate", EmitDefaultValue=false)]
        public DateTime? RejectedDate { get; private set; }
        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public int? CreatedByUserId { get; private set; }
        /// <summary>
        /// Gets or Sets RejectedByUserId
        /// </summary>
        [DataMember(Name="rejectedByUserId", EmitDefaultValue=false)]
        public int? RejectedByUserId { get; private set; }
        /// <summary>
        /// Gets or Sets ClosedStatusId
        /// </summary>
        [DataMember(Name="closedStatusId", EmitDefaultValue=false)]
        public string ClosedStatusId { get; private set; }
        /// <summary>
        /// Gets or Sets FieldDataLastUpdatedDate
        /// </summary>
        [DataMember(Name="fieldDataLastUpdatedDate", EmitDefaultValue=false)]
        public DateTime? FieldDataLastUpdatedDate { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomSummary {\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OfficeId: ").Append(OfficeId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  SubmittedForReviewDate: ").Append(SubmittedForReviewDate).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  RejectedDate: ").Append(RejectedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  RejectedByUserId: ").Append(RejectedByUserId).Append("\n");
            sb.Append("  ClosedStatusId: ").Append(ClosedStatusId).Append("\n");
            sb.Append("  FieldDataLastUpdatedDate: ").Append(FieldDataLastUpdatedDate).Append("\n");
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
            return this.Equals(obj as RoomSummary);
        }

        /// <summary>
        /// Returns true if RoomSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OfficeId == other.OfficeId ||
                    this.OfficeId != null &&
                    this.OfficeId.Equals(other.OfficeId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.SubmittedForReviewDate == other.SubmittedForReviewDate ||
                    this.SubmittedForReviewDate != null &&
                    this.SubmittedForReviewDate.Equals(other.SubmittedForReviewDate)
                ) && 
                (
                    this.ClosedDate == other.ClosedDate ||
                    this.ClosedDate != null &&
                    this.ClosedDate.Equals(other.ClosedDate)
                ) && 
                (
                    this.RejectedDate == other.RejectedDate ||
                    this.RejectedDate != null &&
                    this.RejectedDate.Equals(other.RejectedDate)
                ) && 
                (
                    this.CreatedByUserId == other.CreatedByUserId ||
                    this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    this.RejectedByUserId == other.RejectedByUserId ||
                    this.RejectedByUserId != null &&
                    this.RejectedByUserId.Equals(other.RejectedByUserId)
                ) && 
                (
                    this.ClosedStatusId == other.ClosedStatusId ||
                    this.ClosedStatusId != null &&
                    this.ClosedStatusId.Equals(other.ClosedStatusId)
                ) && 
                (
                    this.FieldDataLastUpdatedDate == other.FieldDataLastUpdatedDate ||
                    this.FieldDataLastUpdatedDate != null &&
                    this.FieldDataLastUpdatedDate.Equals(other.FieldDataLastUpdatedDate)
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
                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OfficeId != null)
                    hash = hash * 59 + this.OfficeId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.SubmittedForReviewDate != null)
                    hash = hash * 59 + this.SubmittedForReviewDate.GetHashCode();
                if (this.ClosedDate != null)
                    hash = hash * 59 + this.ClosedDate.GetHashCode();
                if (this.RejectedDate != null)
                    hash = hash * 59 + this.RejectedDate.GetHashCode();
                if (this.CreatedByUserId != null)
                    hash = hash * 59 + this.CreatedByUserId.GetHashCode();
                if (this.RejectedByUserId != null)
                    hash = hash * 59 + this.RejectedByUserId.GetHashCode();
                if (this.ClosedStatusId != null)
                    hash = hash * 59 + this.ClosedStatusId.GetHashCode();
                if (this.FieldDataLastUpdatedDate != null)
                    hash = hash * 59 + this.FieldDataLastUpdatedDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

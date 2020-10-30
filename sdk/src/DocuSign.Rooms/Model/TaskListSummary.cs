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
    /// TaskListSummary
    /// </summary>
    [DataContract]
    public partial class TaskListSummary :  IEquatable<TaskListSummary>, IValidatableObject
    {
        public TaskListSummary()
        {
            // Empty Constructor
        }
        
        /// <summary>
        /// Gets or Sets TaskListId
        /// </summary>
        [DataMember(Name="taskListId", EmitDefaultValue=false)]
        public int? TaskListId { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Gets or Sets TaskListTemplateId
        /// </summary>
        [DataMember(Name="taskListTemplateId", EmitDefaultValue=false)]
        public int? TaskListTemplateId { get; private set; }
        /// <summary>
        /// Gets or Sets SubmittedForReviewDate
        /// </summary>
        [DataMember(Name="submittedForReviewDate", EmitDefaultValue=false)]
        public DateTime SubmittedForReviewDate { get; private set; }
        /// <summary>
        /// Gets or Sets ApprovalDate
        /// </summary>
        [DataMember(Name="approvalDate", EmitDefaultValue=false)]
        public DateTime ApprovalDate { get; private set; }
        /// <summary>
        /// Gets or Sets RejectedDate
        /// </summary>
        [DataMember(Name="rejectedDate", EmitDefaultValue=false)]
        public DateTime RejectedDate { get; private set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; private set; }
        /// <summary>
        /// Gets or Sets ApprovedByUserId
        /// </summary>
        [DataMember(Name="approvedByUserId", EmitDefaultValue=false)]
        public int? ApprovedByUserId { get; private set; }
        /// <summary>
        /// Gets or Sets RejectedByUserId
        /// </summary>
        [DataMember(Name="rejectedByUserId", EmitDefaultValue=false)]
        public int? RejectedByUserId { get; private set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskListSummary {\n");
            sb.Append("  TaskListId: ").Append(TaskListId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaskListTemplateId: ").Append(TaskListTemplateId).Append("\n");
            sb.Append("  SubmittedForReviewDate: ").Append(SubmittedForReviewDate).Append("\n");
            sb.Append("  ApprovalDate: ").Append(ApprovalDate).Append("\n");
            sb.Append("  RejectedDate: ").Append(RejectedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ApprovedByUserId: ").Append(ApprovedByUserId).Append("\n");
            sb.Append("  RejectedByUserId: ").Append(RejectedByUserId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as TaskListSummary);
        }

        /// <summary>
        /// Returns true if TaskListSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskListSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskListSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskListId == other.TaskListId ||
                    this.TaskListId != null &&
                    this.TaskListId.Equals(other.TaskListId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TaskListTemplateId == other.TaskListTemplateId ||
                    this.TaskListTemplateId != null &&
                    this.TaskListTemplateId.Equals(other.TaskListTemplateId)
                ) && 
                (
                    this.SubmittedForReviewDate == other.SubmittedForReviewDate ||
                    this.SubmittedForReviewDate != null &&
                    this.SubmittedForReviewDate.Equals(other.SubmittedForReviewDate)
                ) && 
                (
                    this.ApprovalDate == other.ApprovalDate ||
                    this.ApprovalDate != null &&
                    this.ApprovalDate.Equals(other.ApprovalDate)
                ) && 
                (
                    this.RejectedDate == other.RejectedDate ||
                    this.RejectedDate != null &&
                    this.RejectedDate.Equals(other.RejectedDate)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.ApprovedByUserId == other.ApprovedByUserId ||
                    this.ApprovedByUserId != null &&
                    this.ApprovedByUserId.Equals(other.ApprovedByUserId)
                ) && 
                (
                    this.RejectedByUserId == other.RejectedByUserId ||
                    this.RejectedByUserId != null &&
                    this.RejectedByUserId.Equals(other.RejectedByUserId)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.TaskListId != null)
                    hash = hash * 59 + this.TaskListId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TaskListTemplateId != null)
                    hash = hash * 59 + this.TaskListTemplateId.GetHashCode();
                if (this.SubmittedForReviewDate != null)
                    hash = hash * 59 + this.SubmittedForReviewDate.GetHashCode();
                if (this.ApprovalDate != null)
                    hash = hash * 59 + this.ApprovalDate.GetHashCode();
                if (this.RejectedDate != null)
                    hash = hash * 59 + this.RejectedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.ApprovedByUserId != null)
                    hash = hash * 59 + this.ApprovedByUserId.GetHashCode();
                if (this.RejectedByUserId != null)
                    hash = hash * 59 + this.RejectedByUserId.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

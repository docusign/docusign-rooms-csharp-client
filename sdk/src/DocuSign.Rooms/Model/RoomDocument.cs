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
    /// RoomDocument
    /// </summary>
    [DataContract]
    public partial class RoomDocument :  IEquatable<RoomDocument>, IValidatableObject
    {
        public RoomDocument()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomDocument" /> class.
        /// </summary>
        /// <param name="DocumentId">DocumentId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OwnerId">OwnerId.</param>
        /// <param name="Size">Size.</param>
        /// <param name="FolderId">FolderId.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="IsSigned">IsSigned.</param>
        /// <param name="DocuSignFormId">DocuSignFormId.</param>
        /// <param name="IsArchived">IsArchived.</param>
        /// <param name="IsVirtual">IsVirtual.</param>
        /// <param name="IsDynamic">IsDynamic.</param>
        /// <param name="Owner">Owner.</param>
        public RoomDocument(int? DocumentId = default(int?), string Name = default(string), int? OwnerId = default(int?), long? Size = default(long?), int? FolderId = default(int?), DateTime? CreatedDate = default(DateTime?), bool? IsSigned = default(bool?), string DocuSignFormId = default(string), bool? IsArchived = default(bool?), bool? IsVirtual = default(bool?), bool? IsDynamic = default(bool?), RoomDocumentOwner Owner = default(RoomDocumentOwner))
        {
            this.DocumentId = DocumentId;
            this.Name = Name;
            this.OwnerId = OwnerId;
            this.Size = Size;
            this.FolderId = FolderId;
            this.CreatedDate = CreatedDate;
            this.IsSigned = IsSigned;
            this.DocuSignFormId = DocuSignFormId;
            this.IsArchived = IsArchived;
            this.IsVirtual = IsVirtual;
            this.IsDynamic = IsDynamic;
            this.Owner = Owner;
        }
        
        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public int? DocumentId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public int? FolderId { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets IsSigned
        /// </summary>
        [DataMember(Name="isSigned", EmitDefaultValue=false)]
        public bool? IsSigned { get; set; }
        /// <summary>
        /// Gets or Sets DocuSignFormId
        /// </summary>
        [DataMember(Name="docuSignFormId", EmitDefaultValue=false)]
        public string DocuSignFormId { get; set; }
        /// <summary>
        /// Gets or Sets IsArchived
        /// </summary>
        [DataMember(Name="isArchived", EmitDefaultValue=false)]
        public bool? IsArchived { get; set; }
        /// <summary>
        /// Gets or Sets IsVirtual
        /// </summary>
        [DataMember(Name="isVirtual", EmitDefaultValue=false)]
        public bool? IsVirtual { get; set; }
        /// <summary>
        /// Gets or Sets IsDynamic
        /// </summary>
        [DataMember(Name="isDynamic", EmitDefaultValue=false)]
        public bool? IsDynamic { get; set; }
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public RoomDocumentOwner Owner { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomDocument {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  IsSigned: ").Append(IsSigned).Append("\n");
            sb.Append("  DocuSignFormId: ").Append(DocuSignFormId).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
            sb.Append("  IsDynamic: ").Append(IsDynamic).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(obj as RoomDocument);
        }

        /// <summary>
        /// Returns true if RoomDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.IsSigned == other.IsSigned ||
                    this.IsSigned != null &&
                    this.IsSigned.Equals(other.IsSigned)
                ) && 
                (
                    this.DocuSignFormId == other.DocuSignFormId ||
                    this.DocuSignFormId != null &&
                    this.DocuSignFormId.Equals(other.DocuSignFormId)
                ) && 
                (
                    this.IsArchived == other.IsArchived ||
                    this.IsArchived != null &&
                    this.IsArchived.Equals(other.IsArchived)
                ) && 
                (
                    this.IsVirtual == other.IsVirtual ||
                    this.IsVirtual != null &&
                    this.IsVirtual.Equals(other.IsVirtual)
                ) && 
                (
                    this.IsDynamic == other.IsDynamic ||
                    this.IsDynamic != null &&
                    this.IsDynamic.Equals(other.IsDynamic)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
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
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.IsSigned != null)
                    hash = hash * 59 + this.IsSigned.GetHashCode();
                if (this.DocuSignFormId != null)
                    hash = hash * 59 + this.DocuSignFormId.GetHashCode();
                if (this.IsArchived != null)
                    hash = hash * 59 + this.IsArchived.GetHashCode();
                if (this.IsVirtual != null)
                    hash = hash * 59 + this.IsVirtual.GetHashCode();
                if (this.IsDynamic != null)
                    hash = hash * 59 + this.IsDynamic.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

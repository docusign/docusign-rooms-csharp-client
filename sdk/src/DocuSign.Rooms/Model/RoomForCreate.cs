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
    /// RoomForCreate
    /// </summary>
    [DataContract]
    public partial class RoomForCreate :  IEquatable<RoomForCreate>, IValidatableObject
    {
        public RoomForCreate()
        {
            // Empty Constructor
        }

                /// <summary>
        /// Defines ListingSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ListingSourceEnum
        {
            
            /// <summary>
            /// Enum PublicRecords for value: PublicRecords
            /// </summary>
            [EnumMember(Value = "PublicRecords")]
            PublicRecords = 1,
            
            /// <summary>
            /// Enum MLS for value: MLS
            /// </summary>
            [EnumMember(Value = "MLS")]
            MLS = 2
        }

        /// <summary>
        /// Gets or Sets ListingSource
        /// </summary>
        [DataMember(Name="listingSource", EmitDefaultValue=false)]
        public ListingSourceEnum? ListingSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomForCreate" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="RoleId">RoleId (required).</param>
        /// <param name="TransactionSideId">Required for a real estate company; otherwise ignored..</param>
        /// <param name="OwnerId">OwnerId.</param>
        /// <param name="TemplateId">TemplateId.</param>
        /// <param name="OfficeId">OfficeId.</param>
        /// <param name="FieldData">FieldData.</param>
        /// <param name="ListingSource">ListingSource.</param>
        public RoomForCreate(string Name = default(string), int? RoleId = default(int?), string TransactionSideId = default(string), int? OwnerId = default(int?), int? TemplateId = default(int?), int? OfficeId = default(int?), FieldDataForCreate FieldData = default(FieldDataForCreate), ListingSourceEnum? ListingSource = default(ListingSourceEnum?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RoomForCreate and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "RoleId" is required (not null)
            if (RoleId == null)
            {
                throw new InvalidDataException("RoleId is a required property for RoomForCreate and cannot be null");
            }
            else
            {
                this.RoleId = RoleId;
            }
            this.TransactionSideId = TransactionSideId;
            this.OwnerId = OwnerId;
            this.TemplateId = TemplateId;
            this.OfficeId = OfficeId;
            this.FieldData = FieldData;
            this.ListingSource = ListingSource;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public int? RoleId { get; set; }
        /// <summary>
        /// Required for a real estate company; otherwise ignored.
        /// </summary>
        /// <value>Required for a real estate company; otherwise ignored.</value>
        [DataMember(Name="transactionSideId", EmitDefaultValue=false)]
        public string TransactionSideId { get; set; }
        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets OfficeId
        /// </summary>
        [DataMember(Name="officeId", EmitDefaultValue=false)]
        public int? OfficeId { get; set; }
        /// <summary>
        /// Gets or Sets FieldData
        /// </summary>
        [DataMember(Name="fieldData", EmitDefaultValue=false)]
        public FieldDataForCreate FieldData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomForCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  TransactionSideId: ").Append(TransactionSideId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  OfficeId: ").Append(OfficeId).Append("\n");
            sb.Append("  FieldData: ").Append(FieldData).Append("\n");
            sb.Append("  ListingSource: ").Append(ListingSource).Append("\n");
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
            return this.Equals(obj as RoomForCreate);
        }

        /// <summary>
        /// Returns true if RoomForCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomForCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomForCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.TransactionSideId == other.TransactionSideId ||
                    this.TransactionSideId != null &&
                    this.TransactionSideId.Equals(other.TransactionSideId)
                ) && 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.OfficeId == other.OfficeId ||
                    this.OfficeId != null &&
                    this.OfficeId.Equals(other.OfficeId)
                ) && 
                (
                    this.FieldData == other.FieldData ||
                    this.FieldData != null &&
                    this.FieldData.Equals(other.FieldData)
                ) && 
                (
                    this.ListingSource == other.ListingSource ||
                    this.ListingSource != null &&
                    this.ListingSource.Equals(other.ListingSource)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.TransactionSideId != null)
                    hash = hash * 59 + this.TransactionSideId.GetHashCode();
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.OfficeId != null)
                    hash = hash * 59 + this.OfficeId.GetHashCode();
                if (this.FieldData != null)
                    hash = hash * 59 + this.FieldData.GetHashCode();
                if (this.ListingSource != null)
                    hash = hash * 59 + this.ListingSource.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

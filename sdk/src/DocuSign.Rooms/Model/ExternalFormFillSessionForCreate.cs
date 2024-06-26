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
    /// ExternalFormFillSessionForCreate
    /// </summary>
    [DataContract]
    public partial class ExternalFormFillSessionForCreate :  IEquatable<ExternalFormFillSessionForCreate>, IValidatableObject
    {
        public ExternalFormFillSessionForCreate()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFormFillSessionForCreate" /> class.
        /// </summary>
        /// <param name="FormId">FormId.</param>
        /// <param name="RoomId">RoomId (required).</param>
        /// <param name="FormIds">FormIds.</param>
        /// <param name="XFrameAllowedUrl">XFrameAllowedUrl.</param>
        public ExternalFormFillSessionForCreate(string FormId = default(string), int? RoomId = default(int?), List<Guid?> FormIds = default(List<Guid?>), string XFrameAllowedUrl = default(string))
        {
            // to ensure "RoomId" is required (not null)
            if (RoomId == null)
            {
                throw new InvalidDataException("RoomId is a required property for ExternalFormFillSessionForCreate and cannot be null");
            }
            else
            {
                this.RoomId = RoomId;
            }
            this.FormId = FormId;
            this.FormIds = FormIds;
            this.XFrameAllowedUrl = XFrameAllowedUrl;
        }
        
        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="formId", EmitDefaultValue=false)]
        public string FormId { get; set; }
        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public int? RoomId { get; set; }
        /// <summary>
        /// Gets or Sets FormIds
        /// </summary>
        [DataMember(Name="formIds", EmitDefaultValue=false)]
        public List<Guid?> FormIds { get; set; }
        /// <summary>
        /// Gets or Sets XFrameAllowedUrl
        /// </summary>
        [DataMember(Name="xFrameAllowedUrl", EmitDefaultValue=false)]
        public string XFrameAllowedUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalFormFillSessionForCreate {\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  FormIds: ").Append(FormIds).Append("\n");
            sb.Append("  XFrameAllowedUrl: ").Append(XFrameAllowedUrl).Append("\n");
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
            return this.Equals(obj as ExternalFormFillSessionForCreate);
        }

        /// <summary>
        /// Returns true if ExternalFormFillSessionForCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalFormFillSessionForCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalFormFillSessionForCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FormId == other.FormId ||
                    this.FormId != null &&
                    this.FormId.Equals(other.FormId)
                ) && 
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) && 
                (
                    this.FormIds == other.FormIds ||
                    this.FormIds != null &&
                    this.FormIds.SequenceEqual(other.FormIds)
                ) && 
                (
                    this.XFrameAllowedUrl == other.XFrameAllowedUrl ||
                    this.XFrameAllowedUrl != null &&
                    this.XFrameAllowedUrl.Equals(other.XFrameAllowedUrl)
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
                if (this.FormId != null)
                    hash = hash * 59 + this.FormId.GetHashCode();
                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();
                if (this.FormIds != null)
                    hash = hash * 59 + this.FormIds.GetHashCode();
                if (this.XFrameAllowedUrl != null)
                    hash = hash * 59 + this.XFrameAllowedUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

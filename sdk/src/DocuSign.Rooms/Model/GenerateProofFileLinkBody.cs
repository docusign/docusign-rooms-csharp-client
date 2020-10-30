/* 
 * ProofService API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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

namespace DocuSign.Rooms.Model
{
    /// <summary>
    /// Model representing the object passed to the GenerateProofFileLink endpoint.
    /// </summary>
    [DataContract]
    public partial class GenerateProofFileLinkBody :  IEquatable<GenerateProofFileLinkBody>, IValidatableObject
    {
        public GenerateProofFileLinkBody()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateProofFileLinkBody" /> class.
        /// </summary>
        /// <param name="ActorId">Actor identifier.</param>
        /// <param name="ViewName">ViewName of the WebApp called (required).</param>
        /// <param name="Authority">Name of the authority requesting these events. The rendering differs according to the accreditation level that this authority has. (required).</param>
        public GenerateProofFileLinkBody(string ActorId = default(string), string ViewName = default(string), string Authority = default(string))
        {
            // to ensure "ViewName" is required (not null)
            if (ViewName == null)
            {
                throw new InvalidDataException("ViewName is a required property for GenerateProofFileLinkBody and cannot be null");
            }
            else
            {
                this.ViewName = ViewName;
            }
            // to ensure "Authority" is required (not null)
            if (Authority == null)
            {
                throw new InvalidDataException("Authority is a required property for GenerateProofFileLinkBody and cannot be null");
            }
            else
            {
                this.Authority = Authority;
            }
            this.ActorId = ActorId;
        }
        
        /// <summary>
        /// Actor identifier
        /// </summary>
        /// <value>Actor identifier</value>
        [DataMember(Name="actor_id", EmitDefaultValue=false)]
        public string ActorId { get; set; }
        /// <summary>
        /// ViewName of the WebApp called
        /// </summary>
        /// <value>ViewName of the WebApp called</value>
        [DataMember(Name="view_name", EmitDefaultValue=false)]
        public string ViewName { get; set; }
        /// <summary>
        /// Name of the authority requesting these events. The rendering differs according to the accreditation level that this authority has.
        /// </summary>
        /// <value>Name of the authority requesting these events. The rendering differs according to the accreditation level that this authority has.</value>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateProofFileLinkBody {\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  ViewName: ").Append(ViewName).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
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
            return this.Equals(obj as GenerateProofFileLinkBody);
        }

        /// <summary>
        /// Returns true if GenerateProofFileLinkBody instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateProofFileLinkBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateProofFileLinkBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActorId == other.ActorId ||
                    this.ActorId != null &&
                    this.ActorId.Equals(other.ActorId)
                ) && 
                (
                    this.ViewName == other.ViewName ||
                    this.ViewName != null &&
                    this.ViewName.Equals(other.ViewName)
                ) && 
                (
                    this.Authority == other.Authority ||
                    this.Authority != null &&
                    this.Authority.Equals(other.Authority)
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
                if (this.ActorId != null)
                    hash = hash * 59 + this.ActorId.GetHashCode();
                if (this.ViewName != null)
                    hash = hash * 59 + this.ViewName.GetHashCode();
                if (this.Authority != null)
                    hash = hash * 59 + this.Authority.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
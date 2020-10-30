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
    /// Definition of a transaction (proof file). It is an entity that hold the events.
    /// </summary>
    [DataContract]
    public partial class IProofFileResponse :  IEquatable<IProofFileResponse>, IValidatableObject
    {
        public IProofFileResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Client identifier of the user that is initiating the transaction.
        /// </summary>
        /// <value>Client identifier of the user that is initiating the transaction.</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; private set; }
        /// <summary>
        /// The DocuSign entity identifier.
        /// </summary>
        /// <value>The DocuSign entity identifier.</value>
        [DataMember(Name="entity_id", EmitDefaultValue=false)]
        public Guid? EntityId { get; private set; }
        /// <summary>
        /// Type of the entity. i.e room, user, envelope...
        /// </summary>
        /// <value>Type of the entity. i.e room, user, envelope...</value>
        [DataMember(Name="entity_type", EmitDefaultValue=false)]
        public string EntityType { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IProofFileResponse {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return this.Equals(obj as IProofFileResponse);
        }

        /// <summary>
        /// Returns true if IProofFileResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IProofFileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IProofFileResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) && 
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
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
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
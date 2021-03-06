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
    /// Definition of a simple event item. The transaction hold by the proof file is made of a list of these items.
    /// </summary>
    [DataContract]
    public partial class IEventResponse :  IEquatable<IEventResponse>, IValidatableObject
    {
        public IEventResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEventResponse" /> class.
        /// </summary>
        /// <param name="Data">The event data that is inserted by  ID Evidence..</param>
        public IEventResponse(Object Data = default(Object))
        {
            this.Data = Data;
        }
        
        /// <summary>
        /// Type of the event.
        /// </summary>
        /// <value>Type of the event.</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public string EventType { get; private set; }
        /// <summary>
        /// The date the event was created. This information is useful for filtering events.
        /// </summary>
        /// <value>The date the event was created. This information is useful for filtering events.</value>
        [DataMember(Name="creation_date", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; private set; }
        /// <summary>
        /// The id of the actor.
        /// </summary>
        /// <value>The id of the actor.</value>
        [DataMember(Name="actor_id", EmitDefaultValue=false)]
        public string ActorId { get; private set; }
        /// <summary>
        /// The event data that is inserted by  ID Evidence.
        /// </summary>
        /// <value>The event data that is inserted by  ID Evidence.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }
        /// <summary>
        /// Indicates whether the object contains large media objects in its data.
        /// </summary>
        /// <value>Indicates whether the object contains large media objects in its data.</value>
        [DataMember(Name="has_media", EmitDefaultValue=false)]
        public bool? HasMedia { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEventResponse {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HasMedia: ").Append(HasMedia).Append("\n");
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
            return this.Equals(obj as IEventResponse);
        }

        /// <summary>
        /// Returns true if IEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEventResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.ActorId == other.ActorId ||
                    this.ActorId != null &&
                    this.ActorId.Equals(other.ActorId)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.HasMedia == other.HasMedia ||
                    this.HasMedia != null &&
                    this.HasMedia.Equals(other.HasMedia)
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
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.ActorId != null)
                    hash = hash * 59 + this.ActorId.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.HasMedia != null)
                    hash = hash * 59 + this.HasMedia.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

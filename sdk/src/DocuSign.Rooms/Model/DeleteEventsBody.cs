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
    /// Model representing the object passed to the delete event endpoint.
    /// </summary>
    [DataContract]
    public partial class DeleteEventsBody :  IEquatable<DeleteEventsBody>, IValidatableObject
    {
        public DeleteEventsBody()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEventsBody" /> class.
        /// </summary>
        /// <param name="EventId">Event identifier. If you get it, it can be a shortcut to delete only one event..</param>
        /// <param name="ClientId">Client identifier of the user that has inserted the event..</param>
        /// <param name="EventType">Type of the event added to the list of events tied to the transaction..</param>
        /// <param name="ActorId">Actor identifier. This enables to remove the events only related to a particular actor..</param>
        public DeleteEventsBody(Guid? EventId = default(Guid?), string ClientId = default(string), string EventType = default(string), string ActorId = default(string))
        {
            this.EventId = EventId;
            this.ClientId = ClientId;
            this.EventType = EventType;
            this.ActorId = ActorId;
        }
        
        /// <summary>
        /// Event identifier. If you get it, it can be a shortcut to delete only one event.
        /// </summary>
        /// <value>Event identifier. If you get it, it can be a shortcut to delete only one event.</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public Guid? EventId { get; set; }
        /// <summary>
        /// Client identifier of the user that has inserted the event.
        /// </summary>
        /// <value>Client identifier of the user that has inserted the event.</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// Type of the event added to the list of events tied to the transaction.
        /// </summary>
        /// <value>Type of the event added to the list of events tied to the transaction.</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public string EventType { get; set; }
        /// <summary>
        /// Actor identifier. This enables to remove the events only related to a particular actor.
        /// </summary>
        /// <value>Actor identifier. This enables to remove the events only related to a particular actor.</value>
        [DataMember(Name="actor_id", EmitDefaultValue=false)]
        public string ActorId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteEventsBody {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
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
            return this.Equals(obj as DeleteEventsBody);
        }

        /// <summary>
        /// Returns true if DeleteEventsBody instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteEventsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteEventsBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) && 
                (
                    this.ActorId == other.ActorId ||
                    this.ActorId != null &&
                    this.ActorId.Equals(other.ActorId)
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
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                if (this.ActorId != null)
                    hash = hash * 59 + this.ActorId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

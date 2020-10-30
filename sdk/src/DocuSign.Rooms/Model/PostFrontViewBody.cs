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
    /// Model representing the object passed to the create front view endpoint.
    /// </summary>
    [DataContract]
    public partial class PostFrontViewBody :  IEquatable<PostFrontViewBody>, IValidatableObject
    {
        public PostFrontViewBody()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFrontViewBody" /> class.
        /// </summary>
        /// <param name="EventsTypes">List of events types that are bound to a proof webapp view. These events types must be those we will use in the insertion of events. (required).</param>
        public PostFrontViewBody(List<string> EventsTypes = default(List<string>))
        {
            // to ensure "EventsTypes" is required (not null)
            if (EventsTypes == null)
            {
                throw new InvalidDataException("EventsTypes is a required property for PostFrontViewBody and cannot be null");
            }
            else
            {
                this.EventsTypes = EventsTypes;
            }
        }
        
        /// <summary>
        /// List of events types that are bound to a proof webapp view. These events types must be those we will use in the insertion of events.
        /// </summary>
        /// <value>List of events types that are bound to a proof webapp view. These events types must be those we will use in the insertion of events.</value>
        [DataMember(Name="events_types", EmitDefaultValue=false)]
        public List<string> EventsTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostFrontViewBody {\n");
            sb.Append("  EventsTypes: ").Append(EventsTypes).Append("\n");
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
            return this.Equals(obj as PostFrontViewBody);
        }

        /// <summary>
        /// Returns true if PostFrontViewBody instances are equal
        /// </summary>
        /// <param name="other">Instance of PostFrontViewBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostFrontViewBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventsTypes == other.EventsTypes ||
                    this.EventsTypes != null &&
                    this.EventsTypes.SequenceEqual(other.EventsTypes)
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
                if (this.EventsTypes != null)
                    hash = hash * 59 + this.EventsTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
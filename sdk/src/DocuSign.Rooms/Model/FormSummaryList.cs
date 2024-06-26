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
    /// FormSummaryList
    /// </summary>
    [DataContract]
    public partial class FormSummaryList :  IEquatable<FormSummaryList>, IValidatableObject
    {
        public FormSummaryList()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormSummaryList" /> class.
        /// </summary>
        /// <param name="Forms">Forms.</param>
        /// <param name="ResultSetSize">ResultSetSize.</param>
        /// <param name="StartPosition">StartPosition.</param>
        /// <param name="NextUri">NextUri.</param>
        /// <param name="PriorUri">PriorUri.</param>
        /// <param name="TotalRowCount">TotalRowCount.</param>
        public FormSummaryList(List<FormSummary> Forms = default(List<FormSummary>), int? ResultSetSize = default(int?), int? StartPosition = default(int?), string NextUri = default(string), string PriorUri = default(string), int? TotalRowCount = default(int?))
        {
            this.Forms = Forms;
            this.ResultSetSize = ResultSetSize;
            this.StartPosition = StartPosition;
            this.NextUri = NextUri;
            this.PriorUri = PriorUri;
            this.TotalRowCount = TotalRowCount;
        }
        
        /// <summary>
        /// Gets or Sets Forms
        /// </summary>
        [DataMember(Name="forms", EmitDefaultValue=false)]
        public List<FormSummary> Forms { get; set; }
        /// <summary>
        /// Gets or Sets ResultSetSize
        /// </summary>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public int? ResultSetSize { get; set; }
        /// <summary>
        /// Gets or Sets StartPosition
        /// </summary>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public int? StartPosition { get; set; }
        /// <summary>
        /// Gets or Sets EndPosition
        /// </summary>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public int? EndPosition { get; private set; }
        /// <summary>
        /// Gets or Sets NextUri
        /// </summary>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
        /// <summary>
        /// Gets or Sets PriorUri
        /// </summary>
        [DataMember(Name="priorUri", EmitDefaultValue=false)]
        public string PriorUri { get; set; }
        /// <summary>
        /// Gets or Sets TotalRowCount
        /// </summary>
        [DataMember(Name="totalRowCount", EmitDefaultValue=false)]
        public int? TotalRowCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormSummaryList {\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PriorUri: ").Append(PriorUri).Append("\n");
            sb.Append("  TotalRowCount: ").Append(TotalRowCount).Append("\n");
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
            return this.Equals(obj as FormSummaryList);
        }

        /// <summary>
        /// Returns true if FormSummaryList instances are equal
        /// </summary>
        /// <param name="other">Instance of FormSummaryList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormSummaryList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Forms == other.Forms ||
                    this.Forms != null &&
                    this.Forms.SequenceEqual(other.Forms)
                ) && 
                (
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.PriorUri == other.PriorUri ||
                    this.PriorUri != null &&
                    this.PriorUri.Equals(other.PriorUri)
                ) && 
                (
                    this.TotalRowCount == other.TotalRowCount ||
                    this.TotalRowCount != null &&
                    this.TotalRowCount.Equals(other.TotalRowCount)
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
                if (this.Forms != null)
                    hash = hash * 59 + this.Forms.GetHashCode();
                if (this.ResultSetSize != null)
                    hash = hash * 59 + this.ResultSetSize.GetHashCode();
                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();
                if (this.EndPosition != null)
                    hash = hash * 59 + this.EndPosition.GetHashCode();
                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();
                if (this.PriorUri != null)
                    hash = hash * 59 + this.PriorUri.GetHashCode();
                if (this.TotalRowCount != null)
                    hash = hash * 59 + this.TotalRowCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

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
    /// 
    /// </summary>
    [DataContract]
    public partial class IViewSchemasResponse :  IEquatable<IViewSchemasResponse>, IValidatableObject
    {
        public IViewSchemasResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IViewSchemasResponse" /> class.
        /// </summary>
        /// <param name="ViewSchemas">List of the view schema..</param>
        /// <param name="Paging">Paging info..</param>
        public IViewSchemasResponse(List<IViewSchemaResponse> ViewSchemas = default(List<IViewSchemaResponse>), IPaginated Paging = default(IPaginated))
        {
            this.ViewSchemas = ViewSchemas;
            this.Paging = Paging;
        }
        
        /// <summary>
        /// List of the view schema.
        /// </summary>
        /// <value>List of the view schema.</value>
        [DataMember(Name="view_schemas", EmitDefaultValue=false)]
        public List<IViewSchemaResponse> ViewSchemas { get; set; }
        /// <summary>
        /// Paging info.
        /// </summary>
        /// <value>Paging info.</value>
        [DataMember(Name="paging", EmitDefaultValue=false)]
        public IPaginated Paging { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IViewSchemasResponse {\n");
            sb.Append("  ViewSchemas: ").Append(ViewSchemas).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
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
            return this.Equals(obj as IViewSchemasResponse);
        }

        /// <summary>
        /// Returns true if IViewSchemasResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IViewSchemasResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IViewSchemasResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ViewSchemas == other.ViewSchemas ||
                    this.ViewSchemas != null &&
                    this.ViewSchemas.SequenceEqual(other.ViewSchemas)
                ) && 
                (
                    this.Paging == other.Paging ||
                    this.Paging != null &&
                    this.Paging.Equals(other.Paging)
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
                if (this.ViewSchemas != null)
                    hash = hash * 59 + this.ViewSchemas.GetHashCode();
                if (this.Paging != null)
                    hash = hash * 59 + this.Paging.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

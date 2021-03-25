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
    /// Defines MemberSortingOption
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MemberSortingOption
    {
        
        /// <summary>
        /// Enum FirstNameAsc for value: FirstNameAsc
        /// </summary>
        [EnumMember(Value = "FirstNameAsc")]
        FirstNameAsc = 1,
        
        /// <summary>
        /// Enum LastNameAsc for value: LastNameAsc
        /// </summary>
        [EnumMember(Value = "LastNameAsc")]
        LastNameAsc = 2,
        
        /// <summary>
        /// Enum EmailAsc for value: EmailAsc
        /// </summary>
        [EnumMember(Value = "EmailAsc")]
        EmailAsc = 3,
        
        /// <summary>
        /// Enum FirstNameDesc for value: FirstNameDesc
        /// </summary>
        [EnumMember(Value = "FirstNameDesc")]
        FirstNameDesc = 4,
        
        /// <summary>
        /// Enum LastNameDesc for value: LastNameDesc
        /// </summary>
        [EnumMember(Value = "LastNameDesc")]
        LastNameDesc = 5,
        
        /// <summary>
        /// Enum EmailDesc for value: EmailDesc
        /// </summary>
        [EnumMember(Value = "EmailDesc")]
        EmailDesc = 6
    }

}
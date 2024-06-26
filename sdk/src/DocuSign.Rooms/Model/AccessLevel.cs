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
    /// Defines AccessLevel
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccessLevel
    {
        
        /// <summary>
        /// Enum Contributor for value: Contributor
        /// </summary>
        [EnumMember(Value = "Contributor")]
        Contributor = 1,
        
        /// <summary>
        /// Enum Office for value: Office
        /// </summary>
        [EnumMember(Value = "Office")]
        Office = 2,
        
        /// <summary>
        /// Enum Region for value: Region
        /// </summary>
        [EnumMember(Value = "Region")]
        Region = 3,
        
        /// <summary>
        /// Enum Company for value: Company
        /// </summary>
        [EnumMember(Value = "Company")]
        Company = 4,
        
        /// <summary>
        /// Enum Admin for value: Admin
        /// </summary>
        [EnumMember(Value = "Admin")]
        Admin = 5
    }

}

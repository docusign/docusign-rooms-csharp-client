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
    /// Defines RolesFilterContextTypes
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RolesFilterContextTypes
    {
        
        /// <summary>
        /// Enum AllRoles for value: AllRoles
        /// </summary>
        [EnumMember(Value = "AllRoles")]
        AllRoles = 1,
        
        /// <summary>
        /// Enum AssignableRolesBasedOnCompanyPermissions for value: AssignableRolesBasedOnCompanyPermissions
        /// </summary>
        [EnumMember(Value = "AssignableRolesBasedOnCompanyPermissions")]
        AssignableRolesBasedOnCompanyPermissions = 2,
        
        /// <summary>
        /// Enum AssignableRolesBasedOnAllPermissions for value: AssignableRolesBasedOnAllPermissions
        /// </summary>
        [EnumMember(Value = "AssignableRolesBasedOnAllPermissions")]
        AssignableRolesBasedOnAllPermissions = 3
    }

}

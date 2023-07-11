/*
 * API MVP Карты
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Map.Service.Converters;

namespace Map.Service.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RoutesDeleteRequest : IEquatable<RoutesDeleteRequest>
    {
        /// <summary>
        /// Gets or Sets RouteName
        /// </summary>
        [DataMember(Name="routeName", EmitDefaultValue=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// Gets or Sets Since
        /// </summary>
        [DataMember(Name="since", EmitDefaultValue=false)]
        public string Since { get; set; }

        /// <summary>
        /// Gets or Sets Till
        /// </summary>
        [DataMember(Name="till", EmitDefaultValue=false)]
        public string Till { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutesDeleteRequest {\n");
            sb.Append("  RouteName: ").Append(RouteName).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  Till: ").Append(Till).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RoutesDeleteRequest)obj);
        }

        /// <summary>
        /// Returns true if RoutesDeleteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutesDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutesDeleteRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RouteName == other.RouteName ||
                    RouteName != null &&
                    RouteName.Equals(other.RouteName)
                ) && 
                (
                    Since == other.Since ||
                    Since != null &&
                    Since.Equals(other.Since)
                ) && 
                (
                    Till == other.Till ||
                    Till != null &&
                    Till.Equals(other.Till)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RouteName != null)
                    hashCode = hashCode * 59 + RouteName.GetHashCode();
                    if (Since != null)
                    hashCode = hashCode * 59 + Since.GetHashCode();
                    if (Till != null)
                    hashCode = hashCode * 59 + Till.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RoutesDeleteRequest left, RoutesDeleteRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RoutesDeleteRequest left, RoutesDeleteRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
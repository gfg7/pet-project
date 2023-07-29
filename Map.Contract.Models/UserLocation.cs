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
using Map.Contract.Converters;

namespace Map.Contract.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class UserLocation : IEquatable<UserLocation>
    {
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public long UserId { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets LastLocation
        /// </summary>
        [DataMember(Name="lastLocation", EmitDefaultValue=false)]
        public Location LastLocation { get; set; }

        /// <summary>
        /// Gets or Sets IsHidden
        /// </summary>
        [DataMember(Name="isHidden", EmitDefaultValue=true)]
        public bool IsHidden { get; set; } = true;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLocation {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  LastLocation: ").Append(LastLocation).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserLocation)obj);
        }

        /// <summary>
        /// Returns true if UserLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLocation other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) && 
                (
                    LastLocation == other.LastLocation ||
                    LastLocation != null &&
                    LastLocation.Equals(other.LastLocation)
                ) && 
                (
                    IsHidden == other.IsHidden ||
                    
                    IsHidden.Equals(other.IsHidden)
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
                    
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                    if (LastLocation != null)
                    hashCode = hashCode * 59 + LastLocation.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsHidden.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserLocation left, UserLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserLocation left, UserLocation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

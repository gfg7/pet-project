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
    public partial class ErrorMessage : IEquatable<ErrorMessage>
    {
        /// <summary>
        /// Gets or Sets UserErrorMessage
        /// </summary>
        [DataMember(Name="userErrorMessage", EmitDefaultValue=false)]
        public string UserErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Arguments
        /// </summary>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<Object> Arguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorMessage {\n");
            sb.Append("  UserErrorMessage: ").Append(UserErrorMessage).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ErrorMessage)obj);
        }

        /// <summary>
        /// Returns true if ErrorMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorMessage other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserErrorMessage == other.UserErrorMessage ||
                    UserErrorMessage != null &&
                    UserErrorMessage.Equals(other.UserErrorMessage)
                ) && 
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error)
                ) && 
                (
                    Arguments == other.Arguments ||
                    Arguments != null &&
                    other.Arguments != null &&
                    Arguments.SequenceEqual(other.Arguments)
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
                    if (UserErrorMessage != null)
                    hashCode = hashCode * 59 + UserErrorMessage.GetHashCode();
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                    if (Arguments != null)
                    hashCode = hashCode * 59 + Arguments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ErrorMessage left, ErrorMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ErrorMessage left, ErrorMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
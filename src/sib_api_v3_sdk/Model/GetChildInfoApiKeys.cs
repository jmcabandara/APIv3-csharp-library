/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// API Keys associated to child account
    /// </summary>
    [DataContract]
    public partial class GetChildInfoApiKeys :  IEquatable<GetChildInfoApiKeys>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChildInfoApiKeys" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetChildInfoApiKeys() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChildInfoApiKeys" /> class.
        /// </summary>
        /// <param name="v2">v2 (required).</param>
        /// <param name="v3">v3.</param>
        public GetChildInfoApiKeys(List<GetChildInfoApiKeysV2> v2 = default(List<GetChildInfoApiKeysV2>), List<GetChildInfoApiKeysV3> v3 = default(List<GetChildInfoApiKeysV3>))
        {
            // to ensure "v2" is required (not null)
            if (v2 == null)
            {
                throw new InvalidDataException("v2 is a required property for GetChildInfoApiKeys and cannot be null");
            }
            else
            {
                this.V2 = v2;
            }
            this.V3 = v3;
        }
        
        /// <summary>
        /// Gets or Sets V2
        /// </summary>
        [DataMember(Name="v2", EmitDefaultValue=false)]
        public List<GetChildInfoApiKeysV2> V2 { get; set; }

        /// <summary>
        /// Gets or Sets V3
        /// </summary>
        [DataMember(Name="v3", EmitDefaultValue=false)]
        public List<GetChildInfoApiKeysV3> V3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetChildInfoApiKeys {\n");
            sb.Append("  V2: ").Append(V2).Append("\n");
            sb.Append("  V3: ").Append(V3).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetChildInfoApiKeys);
        }

        /// <summary>
        /// Returns true if GetChildInfoApiKeys instances are equal
        /// </summary>
        /// <param name="input">Instance of GetChildInfoApiKeys to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetChildInfoApiKeys input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.V2 == input.V2 ||
                    this.V2 != null &&
                    this.V2.SequenceEqual(input.V2)
                ) && 
                (
                    this.V3 == input.V3 ||
                    this.V3 != null &&
                    this.V3.SequenceEqual(input.V3)
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
                int hashCode = 41;
                if (this.V2 != null)
                    hashCode = hashCode * 59 + this.V2.GetHashCode();
                if (this.V3 != null)
                    hashCode = hashCode * 59 + this.V3.GetHashCode();
                return hashCode;
            }
        }
    }

}

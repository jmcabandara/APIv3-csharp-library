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
    /// GetEmailCampaigns
    /// </summary>
    [DataContract]
    public partial class GetEmailCampaigns :  IEquatable<GetEmailCampaigns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailCampaigns" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEmailCampaigns() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailCampaigns" /> class.
        /// </summary>
        /// <param name="campaigns">campaigns.</param>
        /// <param name="count">Number of Email campaigns retrieved (required).</param>
        public GetEmailCampaigns(List<Object> campaigns = default(List<Object>), long? count = default(long?))
        {
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for GetEmailCampaigns and cannot be null");
            }
            else
            {
                this.Count = count;
            }
            this.Campaigns = campaigns;
        }
        
        /// <summary>
        /// Gets or Sets Campaigns
        /// </summary>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<Object> Campaigns { get; set; }

        /// <summary>
        /// Number of Email campaigns retrieved
        /// </summary>
        /// <value>Number of Email campaigns retrieved</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEmailCampaigns {\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as GetEmailCampaigns);
        }

        /// <summary>
        /// Returns true if GetEmailCampaigns instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEmailCampaigns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEmailCampaigns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Campaigns == input.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(input.Campaigns)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Campaigns != null)
                    hashCode = hashCode * 59 + this.Campaigns.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }

}

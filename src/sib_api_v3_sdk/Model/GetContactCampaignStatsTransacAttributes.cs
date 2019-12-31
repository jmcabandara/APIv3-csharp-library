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
    /// GetContactCampaignStatsTransacAttributes
    /// </summary>
    [DataContract]
    public partial class GetContactCampaignStatsTransacAttributes :  IEquatable<GetContactCampaignStatsTransacAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactCampaignStatsTransacAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetContactCampaignStatsTransacAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactCampaignStatsTransacAttributes" /> class.
        /// </summary>
        /// <param name="orderDate">Date of the order (required).</param>
        /// <param name="orderPrice">Price of the order (required).</param>
        /// <param name="orderId">ID of the order (required).</param>
        public GetContactCampaignStatsTransacAttributes(DateTime? orderDate = default(DateTime?), float? orderPrice = default(float?), long? orderId = default(long?))
        {
            // to ensure "orderDate" is required (not null)
            if (orderDate == null)
            {
                throw new InvalidDataException("orderDate is a required property for GetContactCampaignStatsTransacAttributes and cannot be null");
            }
            else
            {
                this.OrderDate = orderDate;
            }
            // to ensure "orderPrice" is required (not null)
            if (orderPrice == null)
            {
                throw new InvalidDataException("orderPrice is a required property for GetContactCampaignStatsTransacAttributes and cannot be null");
            }
            else
            {
                this.OrderPrice = orderPrice;
            }
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for GetContactCampaignStatsTransacAttributes and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
        }
        
        /// <summary>
        /// Date of the order
        /// </summary>
        /// <value>Date of the order</value>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Price of the order
        /// </summary>
        /// <value>Price of the order</value>
        [DataMember(Name="orderPrice", EmitDefaultValue=false)]
        public float? OrderPrice { get; set; }

        /// <summary>
        /// ID of the order
        /// </summary>
        /// <value>ID of the order</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContactCampaignStatsTransacAttributes {\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  OrderPrice: ").Append(OrderPrice).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as GetContactCampaignStatsTransacAttributes);
        }

        /// <summary>
        /// Returns true if GetContactCampaignStatsTransacAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContactCampaignStatsTransacAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContactCampaignStatsTransacAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.OrderPrice == input.OrderPrice ||
                    (this.OrderPrice != null &&
                    this.OrderPrice.Equals(input.OrderPrice))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.OrderPrice != null)
                    hashCode = hashCode * 59 + this.OrderPrice.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                return hashCode;
            }
        }
    }

}

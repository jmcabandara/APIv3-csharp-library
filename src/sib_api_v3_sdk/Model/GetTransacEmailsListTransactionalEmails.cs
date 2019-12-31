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
    /// GetTransacEmailsListTransactionalEmails
    /// </summary>
    [DataContract]
    public partial class GetTransacEmailsListTransactionalEmails :  IEquatable<GetTransacEmailsListTransactionalEmails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacEmailsListTransactionalEmails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransacEmailsListTransactionalEmails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacEmailsListTransactionalEmails" /> class.
        /// </summary>
        /// <param name="email">Email address to which transactional email has been sent (required).</param>
        /// <param name="subject">Subject of the sent email (required).</param>
        /// <param name="templateId">Id of the template.</param>
        /// <param name="messageId">Message Id of the sent email (required).</param>
        /// <param name="uuid">Unique id of the email sent to a particular contact (required).</param>
        /// <param name="date">Date on which transactional email was sent (required).</param>
        public GetTransacEmailsListTransactionalEmails(string email = default(string), string subject = default(string), long? templateId = default(long?), string messageId = default(string), string uuid = default(string), DateTime? date = default(DateTime?))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetTransacEmailsListTransactionalEmails and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for GetTransacEmailsListTransactionalEmails and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for GetTransacEmailsListTransactionalEmails and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new InvalidDataException("uuid is a required property for GetTransacEmailsListTransactionalEmails and cannot be null");
            }
            else
            {
                this.Uuid = uuid;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for GetTransacEmailsListTransactionalEmails and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            this.TemplateId = templateId;
        }
        
        /// <summary>
        /// Email address to which transactional email has been sent
        /// </summary>
        /// <value>Email address to which transactional email has been sent</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Subject of the sent email
        /// </summary>
        /// <value>Subject of the sent email</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Id of the template
        /// </summary>
        /// <value>Id of the template</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// Message Id of the sent email
        /// </summary>
        /// <value>Message Id of the sent email</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Unique id of the email sent to a particular contact
        /// </summary>
        /// <value>Unique id of the email sent to a particular contact</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Date on which transactional email was sent
        /// </summary>
        /// <value>Date on which transactional email was sent</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransacEmailsListTransactionalEmails {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as GetTransacEmailsListTransactionalEmails);
        }

        /// <summary>
        /// Returns true if GetTransacEmailsListTransactionalEmails instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransacEmailsListTransactionalEmails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransacEmailsListTransactionalEmails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                return hashCode;
            }
        }
    }

}

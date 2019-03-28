// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ManagedFieldsEntry is a workflow-id, a FieldSet and the group version
    /// of the resource that the fieldset applies to.
    /// </summary>
    public partial class V1ManagedFieldsEntry
    {
        /// <summary>
        /// Initializes a new instance of the V1ManagedFieldsEntry class.
        /// </summary>
        public V1ManagedFieldsEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ManagedFieldsEntry class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the version of this
        /// resource that this field set applies to. The format is
        /// "group/version" just like the top-level APIVersion field. It is
        /// necessary to track the version of a field set because it cannot be
        /// automatically converted.</param>
        /// <param name="fields">Fields identifies a set of fields.</param>
        /// <param name="manager">Manager is an identifier of the workflow
        /// managing these fields.</param>
        /// <param name="operation">Operation is the type of operation which
        /// lead to this ManagedFieldsEntry being created. The only valid
        /// values for this field are 'Apply' and 'Update'.</param>
        /// <param name="time">Time is timestamp of when these fields were set.
        /// It should always be empty if Operation is 'Apply'</param>
        public V1ManagedFieldsEntry(string apiVersion = default(string), object fields = default(object), string manager = default(string), string operation = default(string), System.DateTime? time = default(System.DateTime?))
        {
            ApiVersion = apiVersion;
            Fields = fields;
            Manager = manager;
            Operation = operation;
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the version of this resource that
        /// this field set applies to. The format is "group/version" just like
        /// the top-level APIVersion field. It is necessary to track the
        /// version of a field set because it cannot be automatically
        /// converted.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets fields identifies a set of fields.
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public object Fields { get; set; }

        /// <summary>
        /// Gets or sets manager is an identifier of the workflow managing
        /// these fields.
        /// </summary>
        [JsonProperty(PropertyName = "manager")]
        public string Manager { get; set; }

        /// <summary>
        /// Gets or sets operation is the type of operation which lead to this
        /// ManagedFieldsEntry being created. The only valid values for this
        /// field are 'Apply' and 'Update'.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets time is timestamp of when these fields were set. It
        /// should always be empty if Operation is 'Apply'
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

    }
}

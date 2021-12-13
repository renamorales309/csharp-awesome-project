// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// CustomResourceDefinitionCondition contains details for the current condition of
        /// this pod.
    /// </summary>
    public partial class V1CustomResourceDefinitionCondition
    {
        /// <summary>
        /// Initializes a new instance of the V1CustomResourceDefinitionCondition class.
        /// </summary>
        public V1CustomResourceDefinitionCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CustomResourceDefinitionCondition class.
        /// </summary>
        /// <param name="status">
        /// status is the status of the condition. Can be True, False, Unknown.
        /// </param>
        /// <param name="type">
        /// type is the type of the condition. Types include Established, NamesAccepted and
        /// Terminating.
        /// </param>
        /// <param name="lastTransitionTime">
        /// lastTransitionTime last time the condition transitioned from one status to
        /// another.
        /// </param>
        /// <param name="message">
        /// message is a human-readable message indicating details about last transition.
        /// </param>
        /// <param name="reason">
        /// reason is a unique, one-word, CamelCase reason for the condition&apos;s last
        /// transition.
        /// </param>
        public V1CustomResourceDefinitionCondition(string status, string type, System.DateTime? lastTransitionTime = null, string message = null, string reason = null)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// lastTransitionTime last time the condition transitioned from one status to
        /// another.
        /// </summary>
        [JsonPropertyName("lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// message is a human-readable message indicating details about last transition.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// reason is a unique, one-word, CamelCase reason for the condition&apos;s last
        /// transition.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// status is the status of the condition. Can be True, False, Unknown.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// type is the type of the condition. Types include Established, NamesAccepted and
        /// Terminating.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}

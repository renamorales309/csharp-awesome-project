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
    /// DEPRECATED - This group version of DaemonSet is deprecated by
    /// apps/v1/DaemonSet. See the release notes for more information.
    /// DaemonSet represents the configuration of a daemon set.
    /// </summary>
    public partial class V1beta2DaemonSet
    {
        /// <summary>
        /// Initializes a new instance of the V1beta2DaemonSet class.
        /// </summary>
        public V1beta2DaemonSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta2DaemonSet class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</param>
        /// <param name="spec">The desired behavior of this daemon set. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</param>
        /// <param name="status">The current status of this daemon set. This
        /// data may be out of date by some window of time. Populated by the
        /// system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</param>
        public V1beta2DaemonSet(string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), V1beta2DaemonSetSpec spec = default(V1beta2DaemonSetSpec), V1beta2DaemonSetStatus status = default(V1beta2DaemonSetStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets the desired behavior of this daemon set. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1beta2DaemonSetSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets the current status of this daemon set. This data may
        /// be out of date by some window of time. Populated by the system.
        /// Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public V1beta2DaemonSetStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Spec != null)
            {
                Spec.Validate();
            }
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}

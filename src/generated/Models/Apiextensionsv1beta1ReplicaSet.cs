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
    /// DEPRECATED - This group version of ReplicaSet is deprecated by
    /// apps/v1beta2/ReplicaSet. See the release notes for more information.
    /// ReplicaSet ensures that a specified number of pod replicas are running
    /// at any given time.
    /// </summary>
    public partial class Apiextensionsv1beta1ReplicaSet
    {
        /// <summary>
        /// Initializes a new instance of the Apiextensionsv1beta1ReplicaSet
        /// class.
        /// </summary>
        public Apiextensionsv1beta1ReplicaSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Apiextensionsv1beta1ReplicaSet
        /// class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">If the Labels of a ReplicaSet are empty,
        /// they are defaulted to be the same as the Pod(s) that the ReplicaSet
        /// manages. Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</param>
        /// <param name="spec">Spec defines the specification of the desired
        /// behavior of the ReplicaSet. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</param>
        /// <param name="status">Status is the most recently observed status of
        /// the ReplicaSet. This data may be out of date by some window of
        /// time. Populated by the system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</param>
        public Apiextensionsv1beta1ReplicaSet(string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), Apiextensionsv1beta1ReplicaSetSpec spec = default(Apiextensionsv1beta1ReplicaSetSpec), Apiextensionsv1beta1ReplicaSetStatus status = default(Apiextensionsv1beta1ReplicaSetStatus))
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
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets if the Labels of a ReplicaSet are empty, they are
        /// defaulted to be the same as the Pod(s) that the ReplicaSet manages.
        /// Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets spec defines the specification of the desired behavior
        /// of the ReplicaSet. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Apiextensionsv1beta1ReplicaSetSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets status is the most recently observed status of the
        /// ReplicaSet. This data may be out of date by some window of time.
        /// Populated by the system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Apiextensionsv1beta1ReplicaSetStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Metadata != null)
            {
                Metadata.Validate();
            }
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

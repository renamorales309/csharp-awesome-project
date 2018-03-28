// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VolumeAttachment captures the intent to attach or detach the specified
    /// volume to/from the specified node.
    ///
    /// VolumeAttachment objects are non-namespaced.
    /// </summary>
    public partial class V1beta1VolumeAttachment
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1VolumeAttachment class.
        /// </summary>
        public V1beta1VolumeAttachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1VolumeAttachment class.
        /// </summary>
        /// <param name="spec">Specification of the desired attach/detach
        /// volume behavior. Populated by the Kubernetes system.</param>
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
        /// <param name="metadata">Standard object metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</param>
        /// <param name="status">Status of the VolumeAttachment request.
        /// Populated by the entity completing the attach or detach operation,
        /// i.e. the external-attacher.</param>
        public V1beta1VolumeAttachment(V1beta1VolumeAttachmentSpec spec, string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), V1beta1VolumeAttachmentStatus status = default(V1beta1VolumeAttachmentStatus))
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
        /// Gets or sets standard object metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets specification of the desired attach/detach volume
        /// behavior. Populated by the Kubernetes system.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1beta1VolumeAttachmentSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets status of the VolumeAttachment request. Populated by
        /// the entity completing the attach or detach operation, i.e. the
        /// external-attacher.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public V1beta1VolumeAttachmentStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Spec == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Spec");
            }
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

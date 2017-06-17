// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SelfSubjectAccessReview checks whether or the current user can perform
    /// an action.  Not filling in a spec.namespace means "in all namespaces".
    /// Self is a special case, because users should always be able to check
    /// whether they can perform an action
    /// </summary>
    public partial class V1SelfSubjectAccessReview
    {
        /// <summary>
        /// Initializes a new instance of the V1SelfSubjectAccessReview class.
        /// </summary>
        public V1SelfSubjectAccessReview()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SelfSubjectAccessReview class.
        /// </summary>
        /// <param name="spec">Spec holds information about the request being
        /// evaluated.  user and groups must be empty</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</param>
        /// <param name="status">Status is filled in by the server and
        /// indicates whether the request is allowed or not</param>
        public V1SelfSubjectAccessReview(V1SelfSubjectAccessReviewSpec spec, string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), V1SubjectAccessReviewStatus status = default(V1SubjectAccessReviewStatus))
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
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets spec holds information about the request being
        /// evaluated.  user and groups must be empty
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1SelfSubjectAccessReviewSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets status is filled in by the server and indicates
        /// whether the request is allowed or not
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public V1SubjectAccessReviewStatus Status { get; set; }

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
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}

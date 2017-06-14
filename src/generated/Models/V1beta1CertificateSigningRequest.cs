// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a certificate signing request
    /// </summary>
    public partial class V1beta1CertificateSigningRequest
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1CertificateSigningRequest
        /// class.
        /// </summary>
        public V1beta1CertificateSigningRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1CertificateSigningRequest
        /// class.
        /// </summary>
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
        /// <param name="spec">The certificate request itself and any
        /// additional information.</param>
        /// <param name="status">Derived information about the request.</param>
        public V1beta1CertificateSigningRequest(string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), V1beta1CertificateSigningRequestSpec spec = default(V1beta1CertificateSigningRequestSpec), V1beta1CertificateSigningRequestStatus status = default(V1beta1CertificateSigningRequestStatus))
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
        /// Gets or sets the certificate request itself and any additional
        /// information.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1beta1CertificateSigningRequestSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets derived information about the request.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public V1beta1CertificateSigningRequestStatus Status { get; set; }

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
        }
    }
}

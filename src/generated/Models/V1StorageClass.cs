// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StorageClass describes the parameters for a class of storage for which
    /// PersistentVolumes can be dynamically provisioned.
    ///
    /// StorageClasses are non-namespaced; the name of the storage class
    /// according to etcd is in ObjectMeta.Name.
    /// </summary>
    public partial class V1StorageClass
    {
        /// <summary>
        /// Initializes a new instance of the V1StorageClass class.
        /// </summary>
        public V1StorageClass()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1StorageClass class.
        /// </summary>
        /// <param name="provisioner">Provisioner indicates the type of the
        /// provisioner.</param>
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
        /// <param name="metadata">Standard object's metadata. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</param>
        /// <param name="parameters">Parameters holds the parameters for the
        /// provisioner that should create volumes of this storage
        /// class.</param>
        public V1StorageClass(string provisioner, string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), IDictionary<string, string> parameters = default(IDictionary<string, string>))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Parameters = parameters;
            Provisioner = provisioner;
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
        /// Gets or sets standard object's metadata. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets parameters holds the parameters for the provisioner
        /// that should create volumes of this storage class.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets provisioner indicates the type of the provisioner.
        /// </summary>
        [JsonProperty(PropertyName = "provisioner")]
        public string Provisioner { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Provisioner == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Provisioner");
            }
        }
    }
}

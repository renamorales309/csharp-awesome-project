// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// MutatingWebhookConfiguration describes the configuration of and admission
        /// webhook that accept or reject and may change the object.
    /// </summary>
    public partial class V1MutatingWebhookConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the V1MutatingWebhookConfiguration class.
        /// </summary>
        public V1MutatingWebhookConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1MutatingWebhookConfiguration class.
        /// </summary>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object metadata; More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </param>
        /// <param name="webhooks">
        /// Webhooks is a list of webhooks and the affected resources and operations.
        /// </param>
        public V1MutatingWebhookConfiguration(string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, IList<V1MutatingWebhook> webhooks = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Webhooks = webhooks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object metadata; More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Webhooks is a list of webhooks and the affected resources and operations.
        /// </summary>
        [JsonProperty(PropertyName = "webhooks")]
        public IList<V1MutatingWebhook> Webhooks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Metadata?.Validate();
            if (Webhooks != null){
                foreach(var obj in Webhooks)
                {
                    obj.Validate();
                }
            }
        }
    }
}

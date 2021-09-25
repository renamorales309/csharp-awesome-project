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
    /// Endpoints is a collection of endpoints that implement the actual service.
        /// Example:
        /// Name: &quot;mysvc&quot;,
        /// Subsets: [
        /// {
        /// Addresses: [{&quot;ip&quot;: &quot;10.10.1.1&quot;}, {&quot;ip&quot;: &quot;10.10.2.2&quot;}],
        /// Ports: [{&quot;name&quot;: &quot;a&quot;, &quot;port&quot;: 8675}, {&quot;name&quot;: &quot;b&quot;, &quot;port&quot;: 309}]
        /// },
        /// {
        /// Addresses: [{&quot;ip&quot;: &quot;10.10.3.3&quot;}],
        /// Ports: [{&quot;name&quot;: &quot;a&quot;, &quot;port&quot;: 93}, {&quot;name&quot;: &quot;b&quot;, &quot;port&quot;: 76}]
        /// },
        /// ]
    /// </summary>
    public partial class V1Endpoints
    {
        /// <summary>
        /// Initializes a new instance of the V1Endpoints class.
        /// </summary>
        public V1Endpoints()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Endpoints class.
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
        /// Standard object&apos;s metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </param>
        /// <param name="subsets">
        /// The set of all endpoints is the union of all subsets. Addresses are placed into
        /// subsets according to the IPs they share. A single address with multiple ports,
        /// some of which are ready and some of which are not (because they come from
        /// different containers) will result in the address being displayed in different
        /// subsets for the different ports. No address will appear in both Addresses and
        /// NotReadyAddresses in the same subset. Sets of addresses and ports that comprise
        /// a service.
        /// </param>
        public V1Endpoints(string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, IList<V1EndpointSubset> subsets = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Subsets = subsets;
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
        /// Standard object&apos;s metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// The set of all endpoints is the union of all subsets. Addresses are placed into
        /// subsets according to the IPs they share. A single address with multiple ports,
        /// some of which are ready and some of which are not (because they come from
        /// different containers) will result in the address being displayed in different
        /// subsets for the different ports. No address will appear in both Addresses and
        /// NotReadyAddresses in the same subset. Sets of addresses and ports that comprise
        /// a service.
        /// </summary>
        [JsonProperty(PropertyName = "subsets")]
        public IList<V1EndpointSubset> Subsets { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Metadata?.Validate();
            if (Subsets != null){
                foreach(var obj in Subsets)
                {
                    obj.Validate();
                }
            }
        }
    }
}

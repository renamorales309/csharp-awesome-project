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
    /// DaemonEndpoint contains information about a single Daemon endpoint.
    /// </summary>
    public partial class V1DaemonEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the V1DaemonEndpoint class.
        /// </summary>
        public V1DaemonEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1DaemonEndpoint class.
        /// </summary>
        /// <param name="port">
        /// Port number of the given endpoint.
        /// </param>
        public V1DaemonEndpoint(int port)
        {
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Port number of the given endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "Port")]
        public int Port { get; set; }

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

// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ContainerPort represents a network port in a single container.
    /// </summary>
    public partial class V1ContainerPort
    {
        /// <summary>
        /// Initializes a new instance of the V1ContainerPort class.
        /// </summary>
        public V1ContainerPort()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ContainerPort class.
        /// </summary>
        /// <param name="containerPort">Number of port to expose on the pod's
        /// IP address. This must be a valid port number, 0 &lt; x &lt;
        /// 65536.</param>
        /// <param name="hostIP">What host IP to bind the external port
        /// to.</param>
        /// <param name="hostPort">Number of port to expose on the host. If
        /// specified, this must be a valid port number, 0 &lt; x &lt; 65536.
        /// If HostNetwork is specified, this must match ContainerPort. Most
        /// containers do not need this.</param>
        /// <param name="name">If specified, this must be an IANA_SVC_NAME and
        /// unique within the pod. Each named port in a pod must have a unique
        /// name. Name for the port that can be referred to by
        /// services.</param>
        /// <param name="protocol">Protocol for port. Must be UDP or TCP.
        /// Defaults to "TCP".</param>
        public V1ContainerPort(int containerPort, string hostIP = default(string), int? hostPort = default(int?), string name = default(string), string protocol = default(string))
        {
            ContainerPort = containerPort;
            HostIP = hostIP;
            HostPort = hostPort;
            Name = name;
            Protocol = protocol;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of port to expose on the pod's IP address. This
        /// must be a valid port number, 0 &amp;lt; x &amp;lt; 65536.
        /// </summary>
        [JsonProperty(PropertyName = "containerPort")]
        public int ContainerPort { get; set; }

        /// <summary>
        /// Gets or sets what host IP to bind the external port to.
        /// </summary>
        [JsonProperty(PropertyName = "hostIP")]
        public string HostIP { get; set; }

        /// <summary>
        /// Gets or sets number of port to expose on the host. If specified,
        /// this must be a valid port number, 0 &amp;lt; x &amp;lt; 65536. If
        /// HostNetwork is specified, this must match ContainerPort. Most
        /// containers do not need this.
        /// </summary>
        [JsonProperty(PropertyName = "hostPort")]
        public int? HostPort { get; set; }

        /// <summary>
        /// Gets or sets if specified, this must be an IANA_SVC_NAME and unique
        /// within the pod. Each named port in a pod must have a unique name.
        /// Name for the port that can be referred to by services.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets protocol for port. Must be UDP or TCP. Defaults to
        /// "TCP".
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}

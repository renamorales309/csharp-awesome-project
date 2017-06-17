// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// LoadBalancerIngress represents the status of a load-balancer ingress
    /// point: traffic intended for the service should be sent to an ingress
    /// point.
    /// </summary>
    public partial class V1LoadBalancerIngress
    {
        /// <summary>
        /// Initializes a new instance of the V1LoadBalancerIngress class.
        /// </summary>
        public V1LoadBalancerIngress()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1LoadBalancerIngress class.
        /// </summary>
        /// <param name="hostname">Hostname is set for load-balancer ingress
        /// points that are DNS based (typically AWS load-balancers)</param>
        /// <param name="ip">IP is set for load-balancer ingress points that
        /// are IP based (typically GCE or OpenStack load-balancers)</param>
        public V1LoadBalancerIngress(string hostname = default(string), string ip = default(string))
        {
            Hostname = hostname;
            Ip = ip;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hostname is set for load-balancer ingress points that
        /// are DNS based (typically AWS load-balancers)
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets IP is set for load-balancer ingress points that are IP
        /// based (typically GCE or OpenStack load-balancers)
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

    }
}

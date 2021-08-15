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
    /// ContainerState holds a possible state of container. Only one of its members may
        /// be specified. If none of them is specified, the default one is
        /// ContainerStateWaiting.
    /// </summary>
    public partial class V1ContainerState
    {
        /// <summary>
        /// Initializes a new instance of the V1ContainerState class.
        /// </summary>
        public V1ContainerState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ContainerState class.
        /// </summary>
        /// <param name="running">
        /// Details about a running container
        /// </param>
        /// <param name="terminated">
        /// Details about a terminated container
        /// </param>
        /// <param name="waiting">
        /// Details about a waiting container
        /// </param>
        public V1ContainerState(V1ContainerStateRunning running = null, V1ContainerStateTerminated terminated = null, V1ContainerStateWaiting waiting = null)
        {
            Running = running;
            Terminated = terminated;
            Waiting = waiting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Details about a running container
        /// </summary>
        [JsonProperty(PropertyName = "running")]
        public V1ContainerStateRunning Running { get; set; }

        /// <summary>
        /// Details about a terminated container
        /// </summary>
        [JsonProperty(PropertyName = "terminated")]
        public V1ContainerStateTerminated Terminated { get; set; }

        /// <summary>
        /// Details about a waiting container
        /// </summary>
        [JsonProperty(PropertyName = "waiting")]
        public V1ContainerStateWaiting Waiting { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Running?.Validate();
            Terminated?.Validate();
            Waiting?.Validate();
        }
    }
}

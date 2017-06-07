// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Lifecycle describes actions that the management system should take in
    /// response to container lifecycle events. For the PostStart and PreStop
    /// lifecycle handlers, management of the container blocks until the action
    /// is complete, unless the container process fails, in which case the
    /// handler is aborted.
    /// </summary>
    public partial class V1Lifecycle
    {
        /// <summary>
        /// Initializes a new instance of the V1Lifecycle class.
        /// </summary>
        public V1Lifecycle()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Lifecycle class.
        /// </summary>
        /// <param name="postStart">PostStart is called immediately after a
        /// container is created. If the handler fails, the container is
        /// terminated and restarted according to its restart policy. Other
        /// management of the container blocks until the hook completes. More
        /// info:
        /// http://kubernetes.io/docs/user-guide/container-environment#hook-details</param>
        /// <param name="preStop">PreStop is called immediately before a
        /// container is terminated. The container is terminated after the
        /// handler completes. The reason for termination is passed to the
        /// handler. Regardless of the outcome of the handler, the container is
        /// eventually terminated. Other management of the container blocks
        /// until the hook completes. More info:
        /// http://kubernetes.io/docs/user-guide/container-environment#hook-details</param>
        public V1Lifecycle(V1Handler postStart = default(V1Handler), V1Handler preStop = default(V1Handler))
        {
            PostStart = postStart;
            PreStop = preStop;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets postStart is called immediately after a container is
        /// created. If the handler fails, the container is terminated and
        /// restarted according to its restart policy. Other management of the
        /// container blocks until the hook completes. More info:
        /// http://kubernetes.io/docs/user-guide/container-environment#hook-details
        /// </summary>
        [JsonProperty(PropertyName = "postStart")]
        public V1Handler PostStart { get; set; }

        /// <summary>
        /// Gets or sets preStop is called immediately before a container is
        /// terminated. The container is terminated after the handler
        /// completes. The reason for termination is passed to the handler.
        /// Regardless of the outcome of the handler, the container is
        /// eventually terminated. Other management of the container blocks
        /// until the hook completes. More info:
        /// http://kubernetes.io/docs/user-guide/container-environment#hook-details
        /// </summary>
        [JsonProperty(PropertyName = "preStop")]
        public V1Handler PreStop { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PostStart != null)
            {
                PostStart.Validate();
            }
            if (PreStop != null)
            {
                PreStop.Validate();
            }
        }
    }
}

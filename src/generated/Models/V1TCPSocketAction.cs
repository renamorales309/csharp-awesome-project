// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TCPSocketAction describes an action based on opening a socket
    /// </summary>
    public partial class V1TCPSocketAction
    {
        /// <summary>
        /// Initializes a new instance of the V1TCPSocketAction class.
        /// </summary>
        public V1TCPSocketAction()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1TCPSocketAction class.
        /// </summary>
        /// <param name="port">Number or name of the port to access on the
        /// container. Number must be in the range 1 to 65535. Name must be an
        /// IANA_SVC_NAME.</param>
        public V1TCPSocketAction(string port)
        {
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number or name of the port to access on the container.
        /// Number must be in the range 1 to 65535. Name must be an
        /// IANA_SVC_NAME.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Port == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Port");
            }
        }
    }
}

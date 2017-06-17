// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TokenReviewSpec is a description of the token authentication request.
    /// </summary>
    public partial class V1beta1TokenReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1TokenReviewSpec class.
        /// </summary>
        public V1beta1TokenReviewSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1TokenReviewSpec class.
        /// </summary>
        /// <param name="token">Token is the opaque bearer token.</param>
        public V1beta1TokenReviewSpec(string token = default(string))
        {
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets token is the opaque bearer token.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

    }
}

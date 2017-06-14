// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Preconditions must be fulfilled before an operation (update, delete,
    /// etc.) is carried out.
    /// </summary>
    public partial class V1Preconditions
    {
        /// <summary>
        /// Initializes a new instance of the V1Preconditions class.
        /// </summary>
        public V1Preconditions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Preconditions class.
        /// </summary>
        /// <param name="uid">Specifies the target UID.</param>
        public V1Preconditions(string uid = default(string))
        {
            Uid = uid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the target UID.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

    }
}

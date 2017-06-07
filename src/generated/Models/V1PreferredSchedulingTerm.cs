// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An empty preferred scheduling term matches all objects with implicit
    /// weight 0 (i.e. it's a no-op). A null preferred scheduling term matches
    /// no objects (i.e. is also a no-op).
    /// </summary>
    public partial class V1PreferredSchedulingTerm
    {
        /// <summary>
        /// Initializes a new instance of the V1PreferredSchedulingTerm class.
        /// </summary>
        public V1PreferredSchedulingTerm()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PreferredSchedulingTerm class.
        /// </summary>
        /// <param name="preference">A node selector term, associated with the
        /// corresponding weight.</param>
        /// <param name="weight">Weight associated with matching the
        /// corresponding nodeSelectorTerm, in the range 1-100.</param>
        public V1PreferredSchedulingTerm(V1NodeSelectorTerm preference, int weight)
        {
            Preference = preference;
            Weight = weight;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a node selector term, associated with the
        /// corresponding weight.
        /// </summary>
        [JsonProperty(PropertyName = "preference")]
        public V1NodeSelectorTerm Preference { get; set; }

        /// <summary>
        /// Gets or sets weight associated with matching the corresponding
        /// nodeSelectorTerm, in the range 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Preference == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Preference");
            }
            if (Preference != null)
            {
                Preference.Validate();
            }
        }
    }
}

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PriorityLevelConfigurationSpec specifies the configuration of a
    /// priority level.
    /// </summary>
    public partial class V1alpha1PriorityLevelConfigurationSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1alpha1PriorityLevelConfigurationSpec class.
        /// </summary>
        public V1alpha1PriorityLevelConfigurationSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1alpha1PriorityLevelConfigurationSpec class.
        /// </summary>
        /// <param name="type">`type` indicates whether this priority level is
        /// subject to limitation on request execution.  A value of `"Exempt"`
        /// means that requests of this priority level are not subject to a
        /// limit (and thus are never queued) and do not detract from the
        /// capacity made available to other priority levels.  A value of
        /// `"Limited"` means that (a) requests of this priority level _are_
        /// subject to limits and (b) some of the server's limited capacity is
        /// made available exclusively to this priority level.
        /// Required.</param>
        /// <param name="limited">`limited` specifies how requests are handled
        /// for a Limited priority level. This field must be non-empty if and
        /// only if `type` is `"Limited"`.</param>
        public V1alpha1PriorityLevelConfigurationSpec(string type, V1alpha1LimitedPriorityLevelConfiguration limited = default(V1alpha1LimitedPriorityLevelConfiguration))
        {
            Limited = limited;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets `limited` specifies how requests are handled for a
        /// Limited priority level. This field must be non-empty if and only if
        /// `type` is `"Limited"`.
        /// </summary>
        [JsonProperty(PropertyName = "limited")]
        public V1alpha1LimitedPriorityLevelConfiguration Limited { get; set; }

        /// <summary>
        /// Gets or sets `type` indicates whether this priority level is
        /// subject to limitation on request execution.  A value of `"Exempt"`
        /// means that requests of this priority level are not subject to a
        /// limit (and thus are never queued) and do not detract from the
        /// capacity made available to other priority levels.  A value of
        /// `"Limited"` means that (a) requests of this priority level _are_
        /// subject to limits and (b) some of the server's limited capacity is
        /// made available exclusively to this priority level. Required.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Limited != null)
            {
                Limited.Validate();
            }
        }
    }
}

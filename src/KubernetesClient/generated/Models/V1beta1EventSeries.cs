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
    /// EventSeries contain information on series of events, i.e. thing that
    /// was/is happening continuously for some time.
    /// </summary>
    public partial class V1beta1EventSeries
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1EventSeries class.
        /// </summary>
        public V1beta1EventSeries()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1EventSeries class.
        /// </summary>
        /// <param name="count">Number of occurrences in this series up to the
        /// last heartbeat time</param>
        /// <param name="lastObservedTime">Time when last Event from the series
        /// was seen before last heartbeat.</param>
        /// <param name="state">Information whether this series is ongoing or
        /// finished. Deprecated. Planned removal for 1.18</param>
        public V1beta1EventSeries(int count, System.DateTime lastObservedTime, string state)
        {
            Count = count;
            LastObservedTime = lastObservedTime;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of occurrences in this series up to the last
        /// heartbeat time
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets time when last Event from the series was seen before
        /// last heartbeat.
        /// </summary>
        [JsonProperty(PropertyName = "lastObservedTime")]
        public System.DateTime LastObservedTime { get; set; }

        /// <summary>
        /// Gets or sets information whether this series is ongoing or
        /// finished. Deprecated. Planned removal for 1.18
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
        }
    }
}

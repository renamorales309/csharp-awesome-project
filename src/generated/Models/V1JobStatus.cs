// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// JobStatus represents the current state of a Job.
    /// </summary>
    public partial class V1JobStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1JobStatus class.
        /// </summary>
        public V1JobStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1JobStatus class.
        /// </summary>
        /// <param name="active">Active is the number of actively running
        /// pods.</param>
        /// <param name="completionTime">CompletionTime represents time when
        /// the job was completed. It is not guaranteed to be set in
        /// happens-before order across separate operations. It is represented
        /// in RFC3339 form and is in UTC.</param>
        /// <param name="conditions">Conditions represent the latest available
        /// observations of an object's current state. More info:
        /// http://kubernetes.io/docs/user-guide/jobs</param>
        /// <param name="failed">Failed is the number of pods which reached
        /// Phase Failed.</param>
        /// <param name="startTime">StartTime represents time when the job was
        /// acknowledged by the Job Manager. It is not guaranteed to be set in
        /// happens-before order across separate operations. It is represented
        /// in RFC3339 form and is in UTC.</param>
        /// <param name="succeeded">Succeeded is the number of pods which
        /// reached Phase Succeeded.</param>
        public V1JobStatus(int? active = default(int?), System.DateTime? completionTime = default(System.DateTime?), IList<V1JobCondition> conditions = default(IList<V1JobCondition>), int? failed = default(int?), System.DateTime? startTime = default(System.DateTime?), int? succeeded = default(int?))
        {
            Active = active;
            CompletionTime = completionTime;
            Conditions = conditions;
            Failed = failed;
            StartTime = startTime;
            Succeeded = succeeded;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets active is the number of actively running pods.
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public int? Active { get; set; }

        /// <summary>
        /// Gets or sets completionTime represents time when the job was
        /// completed. It is not guaranteed to be set in happens-before order
        /// across separate operations. It is represented in RFC3339 form and
        /// is in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "completionTime")]
        public System.DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Gets or sets conditions represent the latest available observations
        /// of an object's current state. More info:
        /// http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V1JobCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets failed is the number of pods which reached Phase
        /// Failed.
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Gets or sets startTime represents time when the job was
        /// acknowledged by the Job Manager. It is not guaranteed to be set in
        /// happens-before order across separate operations. It is represented
        /// in RFC3339 form and is in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets succeeded is the number of pods which reached Phase
        /// Succeeded.
        /// </summary>
        [JsonProperty(PropertyName = "succeeded")]
        public int? Succeeded { get; set; }

    }
}

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
    /// HorizontalPodAutoscalerStatus describes the current status of a horizontal pod
        /// autoscaler.
    /// </summary>
    public partial class V2beta1HorizontalPodAutoscalerStatus
    {
        /// <summary>
        /// Initializes a new instance of the V2beta1HorizontalPodAutoscalerStatus class.
        /// </summary>
        public V2beta1HorizontalPodAutoscalerStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta1HorizontalPodAutoscalerStatus class.
        /// </summary>
        /// <param name="conditions">
        /// conditions is the set of conditions required for this autoscaler to scale its
        /// target, and indicates whether or not those conditions are met.
        /// </param>
        /// <param name="currentReplicas">
        /// currentReplicas is current number of replicas of pods managed by this
        /// autoscaler, as last seen by the autoscaler.
        /// </param>
        /// <param name="desiredReplicas">
        /// desiredReplicas is the desired number of replicas of pods managed by this
        /// autoscaler, as last calculated by the autoscaler.
        /// </param>
        /// <param name="currentMetrics">
        /// currentMetrics is the last read state of the metrics used by this autoscaler.
        /// </param>
        /// <param name="lastScaleTime">
        /// lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of
        /// pods, used by the autoscaler to control how often the number of pods is changed.
        /// </param>
        /// <param name="observedGeneration">
        /// observedGeneration is the most recent generation observed by this autoscaler.
        /// </param>
        public V2beta1HorizontalPodAutoscalerStatus(IList<V2beta1HorizontalPodAutoscalerCondition> conditions, int currentReplicas, int desiredReplicas, IList<V2beta1MetricStatus> currentMetrics = null, System.DateTime? lastScaleTime = null, long? observedGeneration = null)
        {
            Conditions = conditions;
            CurrentMetrics = currentMetrics;
            CurrentReplicas = currentReplicas;
            DesiredReplicas = desiredReplicas;
            LastScaleTime = lastScaleTime;
            ObservedGeneration = observedGeneration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// conditions is the set of conditions required for this autoscaler to scale its
        /// target, and indicates whether or not those conditions are met.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V2beta1HorizontalPodAutoscalerCondition> Conditions { get; set; }

        /// <summary>
        /// currentMetrics is the last read state of the metrics used by this autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "currentMetrics")]
        public IList<V2beta1MetricStatus> CurrentMetrics { get; set; }

        /// <summary>
        /// currentReplicas is current number of replicas of pods managed by this
        /// autoscaler, as last seen by the autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "currentReplicas")]
        public int CurrentReplicas { get; set; }

        /// <summary>
        /// desiredReplicas is the desired number of replicas of pods managed by this
        /// autoscaler, as last calculated by the autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "desiredReplicas")]
        public int DesiredReplicas { get; set; }

        /// <summary>
        /// lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of
        /// pods, used by the autoscaler to control how often the number of pods is changed.
        /// </summary>
        [JsonProperty(PropertyName = "lastScaleTime")]
        public System.DateTime? LastScaleTime { get; set; }

        /// <summary>
        /// observedGeneration is the most recent generation observed by this autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null){
                foreach(var obj in Conditions)
                {
                    obj.Validate();
                }
            }
            if (CurrentMetrics != null){
                foreach(var obj in CurrentMetrics)
                {
                    obj.Validate();
                }
            }
        }
    }
}

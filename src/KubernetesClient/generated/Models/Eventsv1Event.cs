// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Event is a report of an event somewhere in the cluster. It generally denotes
        /// some state change in the system. Events have a limited retention time and
        /// triggers and messages may evolve with time.  Event consumers should not rely on
        /// the timing of an event with a given Reason reflecting a consistent underlying
        /// trigger, or the continued existence of events with that Reason.  Events should
        /// be treated as informative, best-effort, supplemental data.
    /// </summary>
    public partial class Eventsv1Event
    {
        /// <summary>
        /// Initializes a new instance of the Eventsv1Event class.
        /// </summary>
        public Eventsv1Event()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Eventsv1Event class.
        /// </summary>
        /// <param name="eventTime">
        /// eventTime is the time when this Event was first observed. It is required.
        /// </param>
        /// <param name="action">
        /// action is what action was taken/failed regarding to the regarding object. It is
        /// machine-readable. This field cannot be empty for new Events and it can have at
        /// most 128 characters.
        /// </param>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="deprecatedCount">
        /// deprecatedCount is the deprecated field assuring backward compatibility with
        /// core.v1 Event type.
        /// </param>
        /// <param name="deprecatedFirstTimestamp">
        /// deprecatedFirstTimestamp is the deprecated field assuring backward compatibility
        /// with core.v1 Event type.
        /// </param>
        /// <param name="deprecatedLastTimestamp">
        /// deprecatedLastTimestamp is the deprecated field assuring backward compatibility
        /// with core.v1 Event type.
        /// </param>
        /// <param name="deprecatedSource">
        /// deprecatedSource is the deprecated field assuring backward compatibility with
        /// core.v1 Event type.
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object&apos;s metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </param>
        /// <param name="note">
        /// note is a human-readable description of the status of this operation. Maximal
        /// length of the note is 1kB, but libraries should be prepared to handle values up
        /// to 64kB.
        /// </param>
        /// <param name="reason">
        /// reason is why the action was taken. It is human-readable. This field cannot be
        /// empty for new Events and it can have at most 128 characters.
        /// </param>
        /// <param name="regarding">
        /// regarding contains the object this Event is about. In most cases it&apos;s an Object
        /// reporting controller implements, e.g. ReplicaSetController implements
        /// ReplicaSets and this event is emitted because it acts on some changes in a
        /// ReplicaSet object.
        /// </param>
        /// <param name="related">
        /// related is the optional secondary object for more complex actions. E.g. when
        /// regarding object triggers a creation or deletion of related object.
        /// </param>
        /// <param name="reportingController">
        /// reportingController is the name of the controller that emitted this Event, e.g.
        /// `kubernetes.io/kubelet`. This field cannot be empty for new Events.
        /// </param>
        /// <param name="reportingInstance">
        /// reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`.
        /// This field cannot be empty for new Events and it can have at most 128
        /// characters.
        /// </param>
        /// <param name="series">
        /// series is data about the Event series this event represents or nil if it&apos;s a
        /// singleton Event.
        /// </param>
        /// <param name="type">
        /// type is the type of this event (Normal, Warning), new types could be added in
        /// the future. It is machine-readable. This field cannot be empty for new Events.
        /// </param>
        public Eventsv1Event(System.DateTime eventTime, string action = null, string apiVersion = null, int? deprecatedCount = null, System.DateTime? deprecatedFirstTimestamp = null, System.DateTime? deprecatedLastTimestamp = null, V1EventSource deprecatedSource = null, string kind = null, V1ObjectMeta metadata = null, string note = null, string reason = null, V1ObjectReference regarding = null, V1ObjectReference related = null, string reportingController = null, string reportingInstance = null, Eventsv1EventSeries series = null, string type = null)
        {
            Action = action;
            ApiVersion = apiVersion;
            DeprecatedCount = deprecatedCount;
            DeprecatedFirstTimestamp = deprecatedFirstTimestamp;
            DeprecatedLastTimestamp = deprecatedLastTimestamp;
            DeprecatedSource = deprecatedSource;
            EventTime = eventTime;
            Kind = kind;
            Metadata = metadata;
            Note = note;
            Reason = reason;
            Regarding = regarding;
            Related = related;
            ReportingController = reportingController;
            ReportingInstance = reportingInstance;
            Series = series;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// action is what action was taken/failed regarding to the regarding object. It is
        /// machine-readable. This field cannot be empty for new Events and it can have at
        /// most 128 characters.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// deprecatedCount is the deprecated field assuring backward compatibility with
        /// core.v1 Event type.
        /// </summary>
        [JsonPropertyName("deprecatedCount")]
        public int? DeprecatedCount { get; set; }

        /// <summary>
        /// deprecatedFirstTimestamp is the deprecated field assuring backward compatibility
        /// with core.v1 Event type.
        /// </summary>
        [JsonPropertyName("deprecatedFirstTimestamp")]
        public System.DateTime? DeprecatedFirstTimestamp { get; set; }

        /// <summary>
        /// deprecatedLastTimestamp is the deprecated field assuring backward compatibility
        /// with core.v1 Event type.
        /// </summary>
        [JsonPropertyName("deprecatedLastTimestamp")]
        public System.DateTime? DeprecatedLastTimestamp { get; set; }

        /// <summary>
        /// deprecatedSource is the deprecated field assuring backward compatibility with
        /// core.v1 Event type.
        /// </summary>
        [JsonPropertyName("deprecatedSource")]
        public V1EventSource DeprecatedSource { get; set; }

        /// <summary>
        /// eventTime is the time when this Event was first observed. It is required.
        /// </summary>
        [JsonPropertyName("eventTime")]
        public System.DateTime EventTime { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&apos;s metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonPropertyName("metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// note is a human-readable description of the status of this operation. Maximal
        /// length of the note is 1kB, but libraries should be prepared to handle values up
        /// to 64kB.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// reason is why the action was taken. It is human-readable. This field cannot be
        /// empty for new Events and it can have at most 128 characters.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// regarding contains the object this Event is about. In most cases it&apos;s an Object
        /// reporting controller implements, e.g. ReplicaSetController implements
        /// ReplicaSets and this event is emitted because it acts on some changes in a
        /// ReplicaSet object.
        /// </summary>
        [JsonPropertyName("regarding")]
        public V1ObjectReference Regarding { get; set; }

        /// <summary>
        /// related is the optional secondary object for more complex actions. E.g. when
        /// regarding object triggers a creation or deletion of related object.
        /// </summary>
        [JsonPropertyName("related")]
        public V1ObjectReference Related { get; set; }

        /// <summary>
        /// reportingController is the name of the controller that emitted this Event, e.g.
        /// `kubernetes.io/kubelet`. This field cannot be empty for new Events.
        /// </summary>
        [JsonPropertyName("reportingController")]
        public string ReportingController { get; set; }

        /// <summary>
        /// reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`.
        /// This field cannot be empty for new Events and it can have at most 128
        /// characters.
        /// </summary>
        [JsonPropertyName("reportingInstance")]
        public string ReportingInstance { get; set; }

        /// <summary>
        /// series is data about the Event series this event represents or nil if it&apos;s a
        /// singleton Event.
        /// </summary>
        [JsonPropertyName("series")]
        public Eventsv1EventSeries Series { get; set; }

        /// <summary>
        /// type is the type of this event (Normal, Warning), new types could be added in
        /// the future. It is machine-readable. This field cannot be empty for new Events.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            DeprecatedSource?.Validate();
            Metadata?.Validate();
            Regarding?.Validate();
            Related?.Validate();
            Series?.Validate();
        }
    }
}

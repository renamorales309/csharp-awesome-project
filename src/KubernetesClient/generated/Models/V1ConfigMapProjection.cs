// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Adapts a ConfigMap into a projected volume.
    ///
    /// The contents of the target ConfigMap's Data field will be presented in
    /// a projected volume as files using the keys in the Data field as the
    /// file names, unless the items element is populated with specific
    /// mappings of keys to paths. Note that this is identical to a configmap
    /// volume source without the default mode.
    /// </summary>
    public partial class V1ConfigMapProjection
    {
        /// <summary>
        /// Initializes a new instance of the V1ConfigMapProjection class.
        /// </summary>
        public V1ConfigMapProjection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ConfigMapProjection class.
        /// </summary>
        /// <param name="items">If unspecified, each key-value pair in the Data
        /// field of the referenced ConfigMap will be projected into the volume
        /// as a file whose name is the key and content is the value. If
        /// specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified
        /// which is not present in the ConfigMap, the volume setup will error
        /// unless it is marked optional. Paths must be relative and may not
        /// contain the '..' path or start with '..'.</param>
        /// <param name="name">Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</param>
        /// <param name="optional">Specify whether the ConfigMap or its keys
        /// must be defined</param>
        public V1ConfigMapProjection(IList<V1KeyToPath> items = default(IList<V1KeyToPath>), string name = default(string), bool? optional = default(bool?))
        {
            Items = items;
            Name = name;
            Optional = optional;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if unspecified, each key-value pair in the Data field
        /// of the referenced ConfigMap will be projected into the volume as a
        /// file whose name is the key and content is the value. If specified,
        /// the listed keys will be projected into the specified paths, and
        /// unlisted keys will not be present. If a key is specified which is
        /// not present in the ConfigMap, the volume setup will error unless it
        /// is marked optional. Paths must be relative and may not contain the
        /// '..' path or start with '..'.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<V1KeyToPath> Items { get; set; }

        /// <summary>
        /// Gets or sets name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specify whether the ConfigMap or its keys must be
        /// defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

    }
}

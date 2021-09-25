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
    /// DownwardAPIVolumeSource represents a volume containing downward API info.
        /// Downward API volumes support ownership management and SELinux relabeling.
    /// </summary>
    public partial class V1DownwardAPIVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1DownwardAPIVolumeSource class.
        /// </summary>
        public V1DownwardAPIVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1DownwardAPIVolumeSource class.
        /// </summary>
        /// <param name="defaultMode">
        /// Optional: mode bits to use on created files by default. Must be a Optional: mode
        /// bits used to set permissions on created files by default. Must be an octal value
        /// between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both
        /// octal and decimal values, JSON requires decimal values for mode bits. Defaults
        /// to 0644. Directories within the path are not affected by this setting. This
        /// might be in conflict with other options that affect the file mode, like fsGroup,
        /// and the result can be other mode bits set.
        /// </param>
        /// <param name="items">
        /// Items is a list of downward API volume file
        /// </param>
        public V1DownwardAPIVolumeSource(int? defaultMode = null, IList<V1DownwardAPIVolumeFile> items = null)
        {
            DefaultMode = defaultMode;
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Optional: mode bits to use on created files by default. Must be a Optional: mode
        /// bits used to set permissions on created files by default. Must be an octal value
        /// between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both
        /// octal and decimal values, JSON requires decimal values for mode bits. Defaults
        /// to 0644. Directories within the path are not affected by this setting. This
        /// might be in conflict with other options that affect the file mode, like fsGroup,
        /// and the result can be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// Items is a list of downward API volume file
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<V1DownwardAPIVolumeFile> Items { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Items != null){
                foreach(var obj in Items)
                {
                    obj.Validate();
                }
            }
        }
    }
}

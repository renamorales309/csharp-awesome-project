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
    /// Info contains versioning information. how we'll want to distribute that
    /// information.
    /// </summary>
    public partial class VersionInfo
    {
        /// <summary>
        /// Initializes a new instance of the VersionInfo class.
        /// </summary>
        public VersionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionInfo class.
        /// </summary>
        public VersionInfo(string buildDate, string compiler, string gitCommit, string gitTreeState, string gitVersion, string goVersion, string major, string minor, string platform)
        {
            BuildDate = buildDate;
            Compiler = compiler;
            GitCommit = gitCommit;
            GitTreeState = gitTreeState;
            GitVersion = gitVersion;
            GoVersion = goVersion;
            Major = major;
            Minor = minor;
            Platform = platform;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "buildDate")]
        public string BuildDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compiler")]
        public string Compiler { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gitCommit")]
        public string GitCommit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gitTreeState")]
        public string GitTreeState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gitVersion")]
        public string GitVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goVersion")]
        public string GoVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "major")]
        public string Major { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minor")]
        public string Minor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BuildDate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BuildDate");
            }
            if (Compiler == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Compiler");
            }
            if (GitCommit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GitCommit");
            }
            if (GitTreeState == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GitTreeState");
            }
            if (GitVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GitVersion");
            }
            if (GoVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GoVersion");
            }
            if (Major == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Major");
            }
            if (Minor == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Minor");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
        }
    }
}

// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Quantity is a fixed-point representation of a number. It provides convenient
        /// marshaling/unmarshaling in JSON and YAML, in addition to String() and AsInt64()
        /// accessors.
        /// 
        /// The serialization format is:
        /// 
        /// &lt;quantity&gt;        ::= &lt;signedNumber&gt;&lt;suffix&gt;
        /// (Note that &lt;suffix&gt; may be empty, from the &quot;&quot; case in &lt;decimalSI&gt;.)
        /// &lt;digit&gt;           ::= 0 | 1 | ... | 9 &lt;digits&gt;          ::= &lt;digit&gt; |
        /// &lt;digit&gt;&lt;digits&gt; &lt;number&gt;          ::= &lt;digits&gt; | &lt;digits&gt;.&lt;digits&gt; | &lt;digits&gt;. |
        /// .&lt;digits&gt; &lt;sign&gt;            ::= &quot;+&quot; | &quot;-&quot; &lt;signedNumber&gt;    ::= &lt;number&gt; |
        /// &lt;sign&gt;&lt;number&gt; &lt;suffix&gt;          ::= &lt;binarySI&gt; | &lt;decimalExponent&gt; |
        /// &lt;decimalSI&gt; &lt;binarySI&gt;        ::= Ki | Mi | Gi | Ti | Pi | Ei
        /// (International System of units; See:
        /// http://physics.nist.gov/cuu/Units/binary.html)
        /// &lt;decimalSI&gt;       ::= m | &quot;&quot; | k | M | G | T | P | E
        /// (Note that 1024 = 1Ki but 1000 = 1k; I didn&apos;t choose the capitalization.)
        /// &lt;decimalExponent&gt; ::= &quot;e&quot; &lt;signedNumber&gt; | &quot;E&quot; &lt;signedNumber&gt;
        /// 
        /// No matter which of the three exponent forms is used, no quantity may represent a
        /// number greater than 2^63-1 in magnitude, nor may it have more than 3 decimal
        /// places. Numbers larger or more precise will be capped or rounded up. (E.g.: 0.1m
        /// will rounded up to 1m.) This may be extended in the future if we require larger
        /// or smaller quantities.
        /// 
        /// When a Quantity is parsed from a string, it will remember the type of suffix it
        /// had, and will use the same type again when it is serialized.
        /// 
        /// Before serializing, Quantity will be put in &quot;canonical form&quot;. This means that
        /// Exponent/suffix will be adjusted up or down (with a corresponding increase or
        /// decrease in Mantissa) such that:
        /// a. No precision is lost
        /// b. No fractional digits will be emitted
        /// c. The exponent (or suffix) is as large as possible.
        /// The sign will be omitted unless the number is negative.
        /// 
        /// Examples:
        /// 1.5 will be serialized as &quot;1500m&quot;
        /// 1.5Gi will be serialized as &quot;1536Mi&quot;
        /// 
        /// Note that the quantity will NEVER be internally represented by a floating point
        /// number. That is the whole point of this exercise.
        /// 
        /// Non-canonical values will still parse as long as they are well formed, but will
        /// be re-emitted in their canonical form. (So always use canonical form, or don&apos;t
        /// diff.)
        /// 
        /// This format is intended to make it difficult to use these numbers without
        /// writing some sort of special handling code in the hopes that that will cause
        /// implementors to also use a fixed point implementation.
    /// </summary>
    public partial class ResourceQuantity
    {
        /// <summary>
        /// Initializes a new instance of the ResourceQuantity class.
        /// </summary>
        public ResourceQuantity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceQuantity class.
        /// </summary>
        /// <param name="value">
        /// 
        /// </param>
        public ResourceQuantity(string value = null)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}

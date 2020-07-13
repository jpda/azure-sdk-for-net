// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Enables a graph to capture media from a RTSP server.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphRtspSource")]
    public partial class MediaGraphRtspSource : MediaGraphSource
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphRtspSource class.
        /// </summary>
        public MediaGraphRtspSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphRtspSource class.
        /// </summary>
        /// <param name="name">The name to be used for this source
        /// node.</param>
        /// <param name="endpoint">RTSP endpoint of the stream that is being
        /// connected to.</param>
        /// <param name="transport">Underlying RTSP transport. This is used to
        /// enable or disable HTTP tunneling. Possible values include: 'Http',
        /// 'Tcp'</param>
        public MediaGraphRtspSource(string name, MediaGraphEndpoint endpoint, string transport = default(string))
            : base(name)
        {
            Transport = transport;
            Endpoint = endpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets underlying RTSP transport. This is used to enable or
        /// disable HTTP tunneling. Possible values include: 'Http', 'Tcp'
        /// </summary>
        [JsonProperty(PropertyName = "transport")]
        public string Transport { get; set; }

        /// <summary>
        /// Gets or sets RTSP endpoint of the stream that is being connected
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public MediaGraphEndpoint Endpoint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (Endpoint != null)
            {
                Endpoint.Validate();
            }
        }
    }
}
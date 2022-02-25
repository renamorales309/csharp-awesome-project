// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace k8s.Autorest
{
    /// <summary>
    /// Extensions for manipulating HTTP request and response objects.
    /// </summary>
    internal static class HttpExtensions
    {
        /// <summary>
        /// Get the content headers of an HtttRequestMessage.
        /// </summary>
        /// <param name="request">The request message.</param>
        /// <returns>The content headers.</returns>
        public static HttpHeaders GetContentHeaders(this HttpRequestMessage request)
        {
            if (request != null && request.Content != null)
            {
                return request.Content.Headers;
            }

            return null;
        }

        /// <summary>
        /// Get the content headers of an HttpResponseMessage.
        /// </summary>
        /// <param name="response">The response message.</param>
        /// <returns>The content headers.</returns>
        public static HttpHeaders GetContentHeaders(this HttpResponseMessage response)
        {
            if (response != null && response.Content != null)
            {
                return response.Content.Headers;
            }

            return null;
        }
    }
}

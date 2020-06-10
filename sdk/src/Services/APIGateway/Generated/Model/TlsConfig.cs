/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TlsConfig
    {
        private bool? _insecureSkipVerification;

        /// <summary>
        /// Gets and sets the property InsecureSkipVerification. 
        /// <para>
        /// Specifies whether API Gateway skips trust chain validation of the server certificate
        /// during the TLS handshake. Supported only for <code>HTTP</code> and <code>HTTP_PROXY</code>
        /// integrations. By default, API Gateway validates that certificates for integration
        /// endpoints are issued by a <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-supported-certificate-authorities-for-http-endpoints.html">supported
        /// Certificate Authority</a>. If enabled, API Gateway skips trust chain validation of
        /// the server certificate. This is not recommended, but it enables you to use certificates
        /// that are signed by private Certificate Authorities, or certificates that are self-signed.
        /// </para>
        /// </summary>
        public bool InsecureSkipVerification
        {
            get { return this._insecureSkipVerification.GetValueOrDefault(); }
            set { this._insecureSkipVerification = value; }
        }

        // Check to see if InsecureSkipVerification property is set
        internal bool IsSetInsecureSkipVerification()
        {
            return this._insecureSkipVerification.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSampleFindings operation.
    /// Creates sample findings.
    /// </summary>
    public partial class CreateSampleFindingsRequest : AmazonMacie2Request
    {
        private List<string> _findingTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property FindingTypes. 
        /// <para>
        /// An array that lists one or more types of findings to include in the set of sample
        /// findings. Currently, the only supported value is Policy:IAMUser/S3BucketEncryptionDisabled.
        /// </para>
        /// </summary>
        public List<string> FindingTypes
        {
            get { return this._findingTypes; }
            set { this._findingTypes = value; }
        }

        // Check to see if FindingTypes property is set
        internal bool IsSetFindingTypes()
        {
            return this._findingTypes != null && this._findingTypes.Count > 0; 
        }

    }
}
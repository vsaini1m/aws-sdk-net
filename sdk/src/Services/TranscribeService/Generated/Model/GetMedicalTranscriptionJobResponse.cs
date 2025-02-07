/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the GetMedicalTranscriptionJob operation.
    /// </summary>
    public partial class GetMedicalTranscriptionJobResponse : AmazonWebServiceResponse
    {
        private MedicalTranscriptionJob _medicalTranscriptionJob;

        /// <summary>
        /// Gets and sets the property MedicalTranscriptionJob. 
        /// <para>
        /// An object that contains detailed information about your medical transcription job.
        /// Returned fields include: <code>CompletionTime</code>, <code>ContentIdentificationType</code>,
        /// <code>CreationTime</code>, <code>FailureReason</code>, <code>LanguageCode</code>,
        /// <code>Media</code>, <code>MediaFormat</code>, <code>MediaSampleRateHertz</code>, <code>MedicalTranscriptionJobName</code>,
        /// <code>Settings</code>, <code>Specialty</code>, <code>StartTime</code>, <code>Tags</code>,
        /// <code>Transcript</code>, <code>TranscriptionJobStatus</code>, and <code>Type</code>.
        /// </para>
        /// </summary>
        public MedicalTranscriptionJob MedicalTranscriptionJob
        {
            get { return this._medicalTranscriptionJob; }
            set { this._medicalTranscriptionJob = value; }
        }

        // Check to see if MedicalTranscriptionJob property is set
        internal bool IsSetMedicalTranscriptionJob()
        {
            return this._medicalTranscriptionJob != null;
        }

    }
}
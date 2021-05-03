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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountBalance operation.
    /// The <code>GetAccountBalance</code> operation retrieves the Prepaid HITs balance in
    /// your Amazon Mechanical Turk account if you are a Prepaid Requester. Alternatively,
    /// this operation will retrieve the remaining available AWS Billing usage if you have
    /// enabled AWS Billing. Note: If you have enabled AWS Billing and still have a remaining
    /// Prepaid HITs balance, this balance can be viewed on the My Account page in the Requester
    /// console.
    /// </summary>
    public partial class GetAccountBalanceRequest : AmazonMTurkRequest
    {

    }
}
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the ResumeGameServerGroup operation.
    /// </summary>
    public partial class ResumeGameServerGroupResponse : AmazonWebServiceResponse
    {
        private GameServerGroup _gameServerGroup;

        /// <summary>
        /// Gets and sets the property GameServerGroup. 
        /// <para>
        /// An object that describes the game server group resource, with the <i>SuspendedActions</i>
        /// property updated to reflect the resumed activity.
        /// </para>
        /// </summary>
        public GameServerGroup GameServerGroup
        {
            get { return this._gameServerGroup; }
            set { this._gameServerGroup = value; }
        }

        // Check to see if GameServerGroup property is set
        internal bool IsSetGameServerGroup()
        {
            return this._gameServerGroup != null;
        }

    }
}
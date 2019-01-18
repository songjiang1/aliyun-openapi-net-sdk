/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitSubtitleJobResponseUnmarshaller
    {
        public static SubmitSubtitleJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitSubtitleJobResponse submitSubtitleJobResponse = new SubmitSubtitleJobResponse();

			submitSubtitleJobResponse.HttpResponse = context.HttpResponse;
			submitSubtitleJobResponse.RequestId = context.StringValue("SubmitSubtitleJob.RequestId");

			SubmitSubtitleJobResponse.SubmitSubtitleJob_SubtitleJob subtitleJob = new SubmitSubtitleJobResponse.SubmitSubtitleJob_SubtitleJob();
			subtitleJob.JobId = context.StringValue("SubmitSubtitleJob.SubtitleJob.JobId");
			subtitleJob.InputConfig = context.StringValue("SubmitSubtitleJob.SubtitleJob.InputConfig");
			subtitleJob.InputConfig1 = context.StringValue("SubmitSubtitleJob.SubtitleJob.InputConfig");
			subtitleJob.UserData = context.StringValue("SubmitSubtitleJob.SubtitleJob.UserData");
			subtitleJob.State = context.StringValue("SubmitSubtitleJob.SubtitleJob.State");
			submitSubtitleJobResponse.SubtitleJob = subtitleJob;
        
			return submitSubtitleJobResponse;
        }
    }
}
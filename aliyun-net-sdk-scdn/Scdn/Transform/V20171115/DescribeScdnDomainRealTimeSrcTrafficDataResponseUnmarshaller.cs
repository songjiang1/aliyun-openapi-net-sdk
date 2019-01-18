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
using Aliyun.Acs.scdn.Model.V20171115;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainRealTimeSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeSrcTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRealTimeSrcTrafficDataResponse describeScdnDomainRealTimeSrcTrafficDataResponse = new DescribeScdnDomainRealTimeSrcTrafficDataResponse();

			describeScdnDomainRealTimeSrcTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRealTimeSrcTrafficDataResponse.RequestId = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.RequestId");
			describeScdnDomainRealTimeSrcTrafficDataResponse.DomainName = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.DomainName");
			describeScdnDomainRealTimeSrcTrafficDataResponse.StartTime = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.StartTime");
			describeScdnDomainRealTimeSrcTrafficDataResponse.EndTime = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.EndTime");
			describeScdnDomainRealTimeSrcTrafficDataResponse.DataInterval = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.DataInterval");

			List<DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule> describeScdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval = new List<DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval.Length"); i++) {
				DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule dataModule = new DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].Value");

				describeScdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval.Add(dataModule);
			}
			describeScdnDomainRealTimeSrcTrafficDataResponse.RealTimeSrcTrafficDataPerInterval = describeScdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval;
        
			return describeScdnDomainRealTimeSrcTrafficDataResponse;
        }
    }
}
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
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeDrdsDBIpWhiteListResponseUnmarshaller
    {
        public static DescribeDrdsDBIpWhiteListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDrdsDBIpWhiteListResponse describeDrdsDBIpWhiteListResponse = new DescribeDrdsDBIpWhiteListResponse();

			describeDrdsDBIpWhiteListResponse.HttpResponse = context.HttpResponse;
			describeDrdsDBIpWhiteListResponse.RequestId = context.StringValue("DescribeDrdsDBIpWhiteList.RequestId");
			describeDrdsDBIpWhiteListResponse.Success = context.BooleanValue("DescribeDrdsDBIpWhiteList.Success");

			DescribeDrdsDBIpWhiteListResponse.DescribeDrdsDBIpWhiteList_Data data = new DescribeDrdsDBIpWhiteListResponse.DescribeDrdsDBIpWhiteList_Data();

			List<string> data_ipWhiteList = new List<string>();
			for (int i = 0; i < context.Length("DescribeDrdsDBIpWhiteList.Data.IpWhiteList.Length"); i++) {
				data_ipWhiteList.Add(context.StringValue("DescribeDrdsDBIpWhiteList.Data.IpWhiteList["+ i +"]"));
			}
			data.IpWhiteList = data_ipWhiteList;
			describeDrdsDBIpWhiteListResponse.Data = data;
        
			return describeDrdsDBIpWhiteListResponse;
        }
    }
}
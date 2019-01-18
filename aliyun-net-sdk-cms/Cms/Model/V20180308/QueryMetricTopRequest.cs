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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class QueryMetricTopRequest : RpcAcsRequest<QueryMetricTopResponse>
    {
        public QueryMetricTopRequest()
            : base("Cms", "2018-03-08", "QueryMetricTop", "cms", "openAPI")
        {
        }

		private string period;

		private long? resourceOwnerId;

		private string metric;

		private string length;

		private string project;

		private string endTime;

		private string orderby;

		private string express;

		private string startTime;

		private string dimensions;

		private string orderDesc;

		private string accessKeyId;

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string Metric
		{
			get
			{
				return metric;
			}
			set	
			{
				metric = value;
				DictionaryUtil.Add(QueryParameters, "Metric", value);
			}
		}

		public string Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string Orderby
		{
			get
			{
				return orderby;
			}
			set	
			{
				orderby = value;
				DictionaryUtil.Add(QueryParameters, "Orderby", value);
			}
		}

		public string Express
		{
			get
			{
				return express;
			}
			set	
			{
				express = value;
				DictionaryUtil.Add(QueryParameters, "Express", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string Dimensions
		{
			get
			{
				return dimensions;
			}
			set	
			{
				dimensions = value;
				DictionaryUtil.Add(QueryParameters, "Dimensions", value);
			}
		}

		public string OrderDesc
		{
			get
			{
				return orderDesc;
			}
			set	
			{
				orderDesc = value;
				DictionaryUtil.Add(QueryParameters, "OrderDesc", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override QueryMetricTopResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryMetricTopResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
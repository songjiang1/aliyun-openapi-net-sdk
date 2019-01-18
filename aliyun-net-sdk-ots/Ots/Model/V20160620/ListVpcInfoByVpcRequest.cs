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
using Aliyun.Acs.Ots.Transform;
using Aliyun.Acs.Ots.Transform.V20160620;
using System.Collections.Generic;

namespace Aliyun.Acs.Ots.Model.V20160620
{
    public class ListVpcInfoByVpcRequest : RpcAcsRequest<ListVpcInfoByVpcResponse>
    {
        public ListVpcInfoByVpcRequest()
            : base("Ots", "2016-06-20", "ListVpcInfoByVpc", "ots", "openAPI")
        {
        }

		private string access_key_id;

		private long? resourceOwnerId;

		private string vpcId;

		private long? pageSize;

		private string action;

		private long? pageNum;

		private List<TagInfo> tagInfos;

		public string Access_key_id
		{
			get
			{
				return access_key_id;
			}
			set	
			{
				access_key_id = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
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

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public List<TagInfo> TagInfos
		{
			get
			{
				return tagInfos;
			}

			set
			{
				tagInfos = value;
				for (int i = 0; i < tagInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TagInfo." + (i + 1) + ".TagKey", tagInfos[i].TagKey);
					DictionaryUtil.Add(QueryParameters,"TagInfo." + (i + 1) + ".TagValue", tagInfos[i].TagValue);
				}
			}
		}

		public class TagInfo
		{

			private string tagKey;

			private string tagValue;

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}
		}

        public override ListVpcInfoByVpcResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListVpcInfoByVpcResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
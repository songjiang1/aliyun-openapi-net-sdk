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
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class SetIpBlackListConfigRequest : RpcAcsRequest<SetIpBlackListConfigResponse>
    {
        public SetIpBlackListConfigRequest()
            : base("Cdn", "2018-05-10", "SetIpBlackListConfig")
        {
        }

		private string action;

		private string blockIps;

		private string domainName;

		private long? ownerId;

		private long? configId;

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

		public string BlockIps
		{
			get
			{
				return blockIps;
			}
			set	
			{
				blockIps = value;
				DictionaryUtil.Add(QueryParameters, "BlockIps", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public long? ConfigId
		{
			get
			{
				return configId;
			}
			set	
			{
				configId = value;
				DictionaryUtil.Add(QueryParameters, "ConfigId", value.ToString());
			}
		}

        public override SetIpBlackListConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetIpBlackListConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
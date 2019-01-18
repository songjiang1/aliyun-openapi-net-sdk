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
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceIPArrayListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstanceIPArrayList_DBInstanceIPArray> items;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeDBInstanceIPArrayList_DBInstanceIPArray> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDBInstanceIPArrayList_DBInstanceIPArray
		{

			private string dBInstanceIPArrayName;

			private string dBInstanceIPArrayAttribute;

			private string securityIPType;

			private string securityIPList;

			private string whitelistNetworkType;

			public string DBInstanceIPArrayName
			{
				get
				{
					return dBInstanceIPArrayName;
				}
				set	
				{
					dBInstanceIPArrayName = value;
				}
			}

			public string DBInstanceIPArrayAttribute
			{
				get
				{
					return dBInstanceIPArrayAttribute;
				}
				set	
				{
					dBInstanceIPArrayAttribute = value;
				}
			}

			public string SecurityIPType
			{
				get
				{
					return securityIPType;
				}
				set	
				{
					securityIPType = value;
				}
			}

			public string SecurityIPList
			{
				get
				{
					return securityIPList;
				}
				set	
				{
					securityIPList = value;
				}
			}

			public string WhitelistNetworkType
			{
				get
				{
					return whitelistNetworkType;
				}
				set	
				{
					whitelistNetworkType = value;
				}
			}
		}
	}
}
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollarLib
{
	[Serializable]
	public struct Response
	{
		public ResponseCode code;
		public ResponseType type;
		public Guid requestId; // Will be id of request if message is a response
		public String payload;

		public String Serialize()
		{
			return JsonConvert.SerializeObject(this);
		}
		public static Response Deserialize(String str)
		{
			return JsonConvert.DeserializeObject<Response>(str);
		}
	}
}

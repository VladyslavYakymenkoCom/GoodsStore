﻿using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace GoodsStore
{
	public class CustomDirectRouteProvider : DefaultDirectRouteProvider
	{
		protected override IReadOnlyList<IDirectRouteFactory>
		GetActionRouteFactories(HttpActionDescriptor actionDescriptor)
		{ 
			return actionDescriptor.GetCustomAttributes<IDirectRouteFactory>
			(inherit: true);

		}
	
	}
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern {
	public  class WebsiteFactory {

		private  Hashtable flyweights= new Hashtable();

		public Website GetWebSiteCategory(string key)
		{
			if (!flyweights.Contains(key))
			{
				flyweights.Add(key,new ConcreteWebsite(key));
			}

			return (Website) flyweights[key];
		}
	}
}

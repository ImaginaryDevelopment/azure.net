using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebRole1.Models
{
	using System.Web.Mvc;

	public class LinkModel
	{
		public string Text { get; set; }

		public ActionResult Link { get; set; }

		public static IEnumerable<LinkModel> GetLinks()
		{
			return new[]
				            {
					            new LinkModel { Text = "jquery", Link = MVC.Calc.JQuery() },
					            new LinkModel { Text = "knockout", Link = MVC.Calc.Knockout() },
					            new LinkModel { Text = "angular", Link = MVC.Calc.Angular() },
					            new LinkModel { Text = "rivets", Link = MVC.Calc.Rivets() },
											new LinkModel { Text = "knockout with preparser", Link = MVC.Calc.Knockout2() },
											new LinkModel { Text = "angular with jquery keybindings", Link = MVC.Calc.Angular2() },
				            };
		} 
	}
}
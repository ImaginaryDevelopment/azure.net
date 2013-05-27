using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole1.Controllers
{
	using MvcWebRole1.Models;

	public partial class CalcController : Controller
	{
		public virtual ActionResult Index()
		{
			
			var model = LinkModel.GetLinks();
			var child = this.ControllerContext.IsChildAction;
			ViewBag.IsChildAction = child;
			if (child) return this.PartialView(model);
			return View(model);
		}

		public virtual ActionResult JQuery()
		{
			return View();
		}

		public virtual ActionResult Knockout()
		{
			return View();
		}

		public virtual ActionResult Knockout2()
		{
			return View();
		}

		public virtual ActionResult Angular()
		{
			return View();
		}

		public virtual ActionResult Angular2()
		{
			return View();
		}

		public virtual ActionResult Ember()
		{
			return View();
		}

		public virtual ActionResult Rivets()
		{
			return View();
		}
		
	}
}

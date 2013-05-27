// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace MvcWebRole1.Controllers
{
    public partial class CalcController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CalcController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CalcController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CalcController Actions { get { return MVC.Calc; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Calc";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Calc";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string JQuery = "JQuery";
            public readonly string Knockout = "Knockout";
            public readonly string Knockout2 = "Knockout2";
            public readonly string Angular = "Angular";
            public readonly string Angular2 = "Angular2";
            public readonly string Ember = "Ember";
            public readonly string Rivets = "Rivets";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string JQuery = "JQuery";
            public const string Knockout = "Knockout";
            public const string Knockout2 = "Knockout2";
            public const string Angular = "Angular";
            public const string Angular2 = "Angular2";
            public const string Ember = "Ember";
            public const string Rivets = "Rivets";
        }


        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Angular = "Angular";
                public readonly string Angular2 = "Angular2";
                public readonly string Ember = "Ember";
                public readonly string Index = "Index";
                public readonly string JQuery = "JQuery";
                public readonly string Knockout = "Knockout";
                public readonly string Knockout2 = "Knockout2";
                public readonly string Rivets = "Rivets";
            }
            public readonly string Angular = "~/Views/Calc/Angular.cshtml";
            public readonly string Angular2 = "~/Views/Calc/Angular2.cshtml";
            public readonly string Ember = "~/Views/Calc/Ember.cshtml";
            public readonly string Index = "~/Views/Calc/Index.cshtml";
            public readonly string JQuery = "~/Views/Calc/JQuery.cshtml";
            public readonly string Knockout = "~/Views/Calc/Knockout.cshtml";
            public readonly string Knockout2 = "~/Views/Calc/Knockout2.cshtml";
            public readonly string Rivets = "~/Views/Calc/Rivets.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CalcController : MvcWebRole1.Controllers.CalcController
    {
        public T4MVC_CalcController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        partial void JQueryOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult JQuery()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.JQuery);
            JQueryOverride(callInfo);
            return callInfo;
        }

        partial void KnockoutOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Knockout()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Knockout);
            KnockoutOverride(callInfo);
            return callInfo;
        }

        partial void Knockout2Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Knockout2()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Knockout2);
            Knockout2Override(callInfo);
            return callInfo;
        }

        partial void AngularOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Angular()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Angular);
            AngularOverride(callInfo);
            return callInfo;
        }

        partial void Angular2Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Angular2()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Angular2);
            Angular2Override(callInfo);
            return callInfo;
        }

        partial void EmberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Ember()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Ember);
            EmberOverride(callInfo);
            return callInfo;
        }

        partial void RivetsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Rivets()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Rivets);
            RivetsOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
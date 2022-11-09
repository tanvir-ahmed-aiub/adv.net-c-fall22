using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.AuthFilter
{
    public class Logged : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["logged"] != null) {
                return true; 
            }
            return false;
            //return base.AuthorizeCore(httpContext);
        }
    }
}
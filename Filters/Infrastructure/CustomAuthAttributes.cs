using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class CustomAuth : AuthorizeAttribute
    {
        private bool localAllowed;

        public CustomAuth(bool allowedParam)
        {
            localAllowed = allowedParam;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return localAllowed;
            }
            else
            {
                return true;
            }
        }
    }
}
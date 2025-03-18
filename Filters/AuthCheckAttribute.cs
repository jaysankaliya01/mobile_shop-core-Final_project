﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace mobile_shop_core_.Filters
{
    public class AuthCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userId = context.HttpContext.Session.GetString("UserId");

            if (userId == null)
            {
                var controller = (Controller)context.Controller;
                controller.TempData["ErrorMessage"] = "You must be logged in to access this page!";
                context.Result = new RedirectToActionResult("Login", "User", null);
            }

            base.OnActionExecuting(context);
        }
    }

}

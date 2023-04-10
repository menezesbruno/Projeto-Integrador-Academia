using Microsoft.AspNetCore.Mvc.Rendering;

namespace Academia.Helpers
{
    public static class HtmlExtension
    {
        public static string IsActive(this IHtmlHelper html, string controller = null, string action = null, string cssClass = null)
        {

            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            return controller.ToLower().Split(',').Contains(currentController.ToLower()) && action.ToLower().Split(',').Contains(currentAction.ToLower()) ?
                cssClass : String.Empty;
        }
    }
}

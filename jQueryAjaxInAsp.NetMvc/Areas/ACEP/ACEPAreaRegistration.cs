using System.Web.Mvc;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP
{
    public class ACEPAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ACEP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ACEP_default",
                "ACEP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
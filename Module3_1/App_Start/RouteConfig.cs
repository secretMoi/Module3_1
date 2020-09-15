using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Module3_1
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // ignore ces routes


			// crée la route avec 2 valeurs vallant 0 si non définie
			// http://localhost/Soustraire/2/3
            routes.MapRoute(
                name: "Soustraire",
                url: "Soustraire/{valeur1}/{valeur2}",
                defaults: new { controller = "Calculateur", action = "Soustraire", valeur1 = 0, valeur2 = 0 }
            );

            // http://localhost/Ajouter/2/3
			routes.MapRoute(
				name: "Ajouter",
				url: "Ajouter/{valeur1}/{valeur2}",
				defaults: new { controller = "Calculateur", action = "Ajouter", valeur1 = 0, valeur2 = 0 }
			);


			// finir par la route la plus générale
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Utils
{
    public class PageUtil
    {
        public static void exibirAlert(System.Web.UI.Page page, String msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "myalert", "alert('" + msg + "');", true);
        }

        public static float formatParse(String value)
        {
            return float.Parse(value.Replace(".", "").Replace(",", "."));
        }
    }
}
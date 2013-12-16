using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuhasebeWEB
{
    public partial class Muhasebe : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetCurrentPage();
        }

        private void SetCurrentPage()
        {
            string pageName = GetPageName().ToString();

            switch (pageName)
            {
                case "Default.aspx":
                    default1.Attributes["class"] = "current";
                    break;
                case "sektorler.aspx":
                    sektor.Attributes["class"] = "current";
                    break;
                case "mevzuat.aspx":
                    mevzuat.Attributes["class"] = "current";
                    break;
                case "iletisim.aspx":
                    iletisim.Attributes["class"] = "current";
                    break;
            }
        }

        private object GetPageName()
        {
            return Request.Url.ToString().Split('/').Last();
        }
    }
}
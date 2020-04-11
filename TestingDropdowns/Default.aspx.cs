using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace TestingDropdowns
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GuestResponse guestResponse = new GuestResponse();

                guestResponse.Name = Name.Value.ToString();
                guestResponse.Phone = Phone.Value.ToString();
                guestResponse.WillAttend = Convert.ToBoolean(WillAttend.Value.ToString());
                ResponseRepository.GetRepository().AddResponse(guestResponse);

                if (guestResponse.WillAttend != null && guestResponse.WillAttend.ToString() == "True")
                {

                    Response.Redirect("seeyouthere.html");
                }
                else
                {
                    Response.Redirect("sorryyoucantcome.html");
                }
            }
        }
    }
}
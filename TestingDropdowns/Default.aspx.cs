using System;
using System.Web;
using System.Web.UI;
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

                if (TryUpdateModel(guestResponse, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponseRepository.GetRepository().AddResponse(guestResponse);

                    if (guestResponse.WillAttend.HasValue && guestResponse.WillAttend == true)
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
}
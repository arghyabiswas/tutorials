using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESSPLControls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:SampleControl runat=server></{0}:SampleControl>")]
    public class SampleControl : CompositeControl
    {
        Label text;

        protected override void CreateChildControls()
        {
            text = new Label();
            text.ID = "Text";
            text.Text = "Welcome to Esspl";
            //text.Width = Unit.Pixel(90);

            this.Controls.Add(text);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            text.RenderControl(writer);
        }
    }
}

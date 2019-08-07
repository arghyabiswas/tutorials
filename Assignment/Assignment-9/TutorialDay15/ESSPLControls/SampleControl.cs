﻿using System;
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
    public class SampleControl : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Control
        {
            get
            {
                String s = (String)ViewState["Control"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Control"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(Control);
        }
    }
}

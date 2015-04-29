﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WinkAtHome
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Common.prepareDatabase();

                string startpage = SettingMgmt.getSetting("StartPage");
                if (string.IsNullOrWhiteSpace(startpage))
                    startpage = "Control.aspx";

                Response.Redirect("~/" + startpage);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("WinkAtHome.Default.Page_Load", ex.Message, EventLogEntryType.Error);
            }
        }
    }
}
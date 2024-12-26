﻿using System;
using System.Collections.Generic;
using System.Text;
using SDUI;

namespace ControlGallery.Panels
{
    public class StatusBarPanel : Panel
    {
        public StatusBarPanel ()
        {
            var statusbar = new StatusBar {
                Text = "Test Text!"
            };

            Controls.Add (statusbar);
        }
    }
}

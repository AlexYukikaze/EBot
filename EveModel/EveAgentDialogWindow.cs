using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveModel
{
    public class EveAgentDialogWindow : EveWindow
    {
        public string Briefing
        {
            get { return this["sr"]["briefingBrowser"]["sr"]["currentTXT"].GetValueAs<String>(); }
        }
        public string Objective
        {
            get { return this["sr"]["objectiveBrowser"]["sr"]["currentTXT"].GetValueAs<String>(); }
        }
        public int AgentId
        {
            get { return this["sr"]["agentID"].GetValueAs<int>(); }
        }
    }
}

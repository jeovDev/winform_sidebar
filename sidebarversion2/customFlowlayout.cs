using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebarversion2
{
    public class customFlowlayout : FlowLayoutPanel
    {
        public customFlowlayout()
      : base()
        {
            this.DoubleBuffered = true;
        }

        public bool DoubleBuffered
        {
            get { return base.DoubleBuffered; }
            set { base.DoubleBuffered = value; }
        }
    }
}

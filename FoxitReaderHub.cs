using AxFOXITREADERLib;
using Ghost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxitReader
{
    public class FoxitReaderHub : HubBase
    {
        public AxFoxitCtl FoxitCtl { get; private set; }

        public FoxitReaderHub()
        {
            this.FoxitCtl = new AxFoxitCtl();
            this.FoxitCtl.Dock = DockStyle.Fill;
        }

        public void OpenFile(string filePath)
        {
            this.FoxitCtl.OpenFile(filePath);
        }
    }
}

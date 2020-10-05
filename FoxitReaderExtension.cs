using Ghost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxitReader
{
    public class FoxitReaderExtension : IEmbeddedControlExtension
    {
        private FoxitReaderHub foxitReaderHub;

        public bool IsClickThrough => false;

        public HubBase Hub => foxitReaderHub;

        public Control GetControl()
        {
            return foxitReaderHub.FoxitCtl;
        }

        public void Initialize(IExtensionConfig config)
        {
            this.foxitReaderHub = new FoxitReaderHub();
        }

        public void OnConnected()
        {

        }

        public void OnDisconnect()
        {

        }

        public void Dispose()
        {

        }
    }
}

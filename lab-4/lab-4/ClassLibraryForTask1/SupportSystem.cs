using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class SupportSystem
    {
        private SupportHandler _handler;

        public SupportSystem()
        {
            _handler = new BasicSupportHandler();
            var intermediateHandler = new IntermediateSupportHandler();
            var advancedHandler = new AdvancedSupportHandler();

            _handler.SetNextHandler(intermediateHandler);
            intermediateHandler.SetNextHandler(advancedHandler);
        }

        public void ProcessRequest(SupportRequest request)
        {
            _handler.HandleRequest(request);
        }
    }
}

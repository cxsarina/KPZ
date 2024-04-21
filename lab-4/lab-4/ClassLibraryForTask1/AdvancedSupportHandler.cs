using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class AdvancedSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.RequestedLevel == SupportLevel.Advanced)
            {
                Console.WriteLine("Запит на високому рівні підтримки оброблено.");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Не знайдено відповідного рівня підтримки.");
            }
        }
    }
}

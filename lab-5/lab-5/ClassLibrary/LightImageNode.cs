using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask3_4
{
    public class LightImageNode : LightNode
    {
        public string Href { get; }
        private readonly IImageLoadingStrategy _loadingStrategy;

        public LightImageNode(string href, IImageLoadingStrategy loadingStrategy)
        {
            Href = href;
            _loadingStrategy = loadingStrategy;
        }

        public override string OuterHtml => $"<img src=\"{_loadingStrategy.LoadImage(Href)}\">";
        public override string InnerHtml => OuterHtml;
    }
}

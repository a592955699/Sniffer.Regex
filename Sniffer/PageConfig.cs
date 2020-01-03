using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sniffer
{
    public class PageConfig
    {
        public PageConfig()
        {
        }
        public PageType PageType { get; set; }       
        public string Title { get; set; }
        public string Url { get; set; }
        private Encoding _Encoding = Encoding.GetEncoding("GB2312");
        public Encoding Encoding { get { return _Encoding; } set { _Encoding = value; } }
        public bool Pager { get; set; }
        public bool PagerRegex { get; set; }
        public bool PagerFomart { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sniffer
{
    public abstract class ItemBase
    {
        public string Name { get; set; }
        public string EmptyValue { get; set; }
        public string PadLeft { get; set; }
        public string PadRight { get; set; }
        public object Value { get; set; }
        public string Start { get; set; }
        public bool ConcatStart { get; set; }
        public string End { get; set; }
        public bool ConcatEnd { get; set; }
        public abstract ItemOperateType OperateType { get; set; }
        public string Replace { get; set; }
        public abstract void Convert(string html);
    }
}

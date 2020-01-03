using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Data;


namespace Sniffer
{
    public class ItemRegex:ItemBase
    {
        private RegexOptions _RegexOptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
        private ItemOperateType _OperateType = ItemOperateType.Content;
        public string MultilinePattern { get; set; }
        public RegexOptions RegexOptions { get { return _RegexOptions; } set { _RegexOptions = value; } }
        public override ItemOperateType OperateType { get { return _OperateType; } set { _OperateType = value; } }

        public override void Convert(string html)
        {
            try
            {
                if (string.IsNullOrEmpty(MultilinePattern))
                {
                    string content = string.Empty;
                    string patten = this.GetPattern();
                    Regex reg = new Regex(patten, this.RegexOptions);
                    if (this.OperateType == ItemOperateType.Content)
                    {
                        Match match = reg.Match(html);
                        if (match.Success)
                        {
                            content = match.Value;
                        }
                    }
                    else
                    {
                        content = reg.Replace(html, this.Replace);
                    }
                    this.Value = content;
                }
                else
                {
                    Regex reg = new Regex(MultilinePattern, this.RegexOptions);
                    MatchCollection matchs = reg.Matches(html);
                    DataTable dt = new DataTable();
                    string[] groupNames = reg.GetGroupNames();
                    if (reg.GetGroupNames().Length > 1)
                    {
                        for (int i = 1; i < groupNames.Length; i++)
                        {
                            dt.Columns.Add(groupNames[i]);
                        }
                    }
                    else
                    {
                        dt.Columns.Add("匹配内容");
                    }
                    foreach (Match item in matchs)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            dr[i] = item.Groups[i].Value;
                        }
                        dt.Rows.Add(dr);
                    }
                    this.Value = dt;
                }
            }
            catch
            {
                if (string.IsNullOrEmpty(MultilinePattern))
                {
                    this.Value = string.Empty;
                }
                else
                {
                    this.Value = null;
                }
            }
        }
       
        public override string ToString()
        {
            if (string.IsNullOrEmpty(MultilinePattern))
                return this.Value.ToString();
            else
            {
                if (this.Value == null)
                    return string.Empty;
                else
                    return JsonConvert.SerializeObject(this.Value);
            }
        }

        private string GetPattern()
        {
            string patten = string.Empty;
            if (this.ConcatStart)
                patten = string.Format("(?<={0})", Start);
            else
                patten = Start;
            patten = patten + ".*?";
            if (this.ConcatEnd)
                patten = patten + string.Format("(?={0})", End);
            else
                patten = patten + End;
            return patten;
        }
    }
}

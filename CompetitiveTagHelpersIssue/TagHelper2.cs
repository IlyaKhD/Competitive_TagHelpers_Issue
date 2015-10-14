using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitiveTagHelpersIssue {

    [HtmlTargetElement("competitive-tag")]
    public class TagHelper2 : TagHelper {

        [HtmlAttributeName("prop")]
        public int Prop2 { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output) {
            output.Content.Append("TagHelper2");
        }
    }

}

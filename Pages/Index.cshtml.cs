using ASP.NETCore_RazorPages.Pages.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NETCore_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Brands =
            [
            "images/brands/brand_1.svg",
            "images/brands/brand_2.svg",
            "images/brands/brand_3.svg",
            "images/brands/brand_4.svg"
            ];


        public List<FeatureBoxViewModel> Features { get; set; } =
          [
            new FeatureBoxViewModel{Icon="images/icons/chat.svg", Title="Comments on Tasks", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new FeatureBoxViewModel{Icon="images/icons/presentation.svg", Title="Tasks Analytics", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new FeatureBoxViewModel{Icon="images/icons/add-group.svg", Title="Multiple Assignees", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new FeatureBoxViewModel{Icon="images/icons/notification.svg", Title="Notifications", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new FeatureBoxViewModel{Icon="images/icons/subtask.svg", Title="Sections & Subtasks", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new FeatureBoxViewModel{Icon="images/icons/security.svg", Title="Data Security", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo." }
          ];

        public List<ToolsBoxViewModel> Tools { get; set; } =
            [
             new ToolsBoxViewModel{Icon="images/icons/google.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div1 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/camera.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div2 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/color.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div3 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/gmail.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div4 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/blue_icon.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div5 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/monkey.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div6 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/blue_i.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div7 div-box"},
             new ToolsBoxViewModel{Icon="images/icons/green.svg", Text="Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.", ClassName="div8 div-box"},
            ];
        public void OnGet()
        {
        }

        public void onPost()
        {
            var emailAddress = Request.Form["emailaddress"];
        }
    }
}

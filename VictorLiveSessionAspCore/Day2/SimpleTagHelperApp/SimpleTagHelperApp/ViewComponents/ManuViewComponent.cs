using Microsoft.AspNetCore.Mvc;

namespace SimpleTagHelperApp.ViewComponents
{
    public class Menu
    {
        public string Text { get; set; }
        public bool IsSelected { get; set; }
        public string Url { get; set; }
    }
    public class ManuViewComponent : ViewComponent
    {
        public ManuViewComponent()
        {
            //DBContextCan be inejcted here
        }

        public async  Task<IViewComponentResult> InvokeAsync(int selcectIndexNo)
        {
            //should come via dbcontext
            var menuItems = new List<Menu>() {
                new Menu() { Text="Home",Url="/",IsSelected=(0==selcectIndexNo) },
                   new Menu() { Text="About",Url="/about",IsSelected=(1==selcectIndexNo) },
                      new Menu() { Text="Contact",Url="/contact",IsSelected=(2==selcectIndexNo) }
           };

            return View(menuItems);
        }
    }
}

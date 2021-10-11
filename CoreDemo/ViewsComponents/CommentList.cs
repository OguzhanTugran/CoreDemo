using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewsComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    id=1,
                    Username="Oguzhan",

                },
                new UserComment
                {
                    id=2,
                    Username="Yacuzhan",
                },
                new UserComment
                {
                    id=3,
                    Username="Gizem",
                }
            };
            return View(commentvalues);
        }
    }
}

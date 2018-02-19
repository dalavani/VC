using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VideoCommercial.Pages
{
    public class IndexModel : PageModel
    { 
        private string folderLocation = "~\\..\\down\\commercial";
        public void OnGet()
        {
            string[] filePaths = Directory.GetFiles(@folderLocation);
            ViewData["Vids"] = filePaths;
            ViewData["location"] = "..\\down\\commercial";
        }
    }
}

using FantaxyApp.Models.DB;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace FantaxyApp
{
    public partial class GlobalFunctons : Controller
    {
        public ActionResult ReplaceImageTags(string input)
        {
            using(FantaxyDBContext db = new FantaxyDBContext())
            {
                string pattern = @"\[IMG=.*?\]";
                string result = input;
                foreach (var image in db.Images)
                {
                    TagBuilder tagBuilder = new TagBuilder("img");
                    tagBuilder.MergeAttribute("src", $"data:image/jpeg;base64,{Convert.ToBase64String(Encoding.UTF8.GetBytes(image.Images.ToString()))}");

                    result = Regex.Replace(result, pattern, match =>
                    {
                        return tagBuilder.ToString(TagRenderMode.SelfClosing);
                    });
                }
                return Content(result);
            }
        }

    }
}

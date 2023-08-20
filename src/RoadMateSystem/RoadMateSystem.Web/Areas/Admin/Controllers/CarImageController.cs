namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;

    public class CarImageController : BaseAdminController
    {
        public async Task<IActionResult> Add()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Add(List<IFormFile> photos)
        {
            if (photos != null && photos.Count > 0)
            {
                foreach (var photoFile in photos)
                {
                    if (photoFile != null && photoFile.Length > 0)
                    {
                        var fileName = Path.GetFileName(photoFile.FileName);
                        var filePath = Path.Combine("CarImages", fileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await photoFile.CopyToAsync(fileStream);
                        }
                    }
                }

                return RedirectToAction(nameof(Index)); 
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

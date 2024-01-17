using CustomerUserModel.Data;
using CustomerUserModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CustomerUserModel.Controllers
{
    public class ImageController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ApplicationDbContext _context;
        public ImageController(IWebHostEnvironment hostEnvironment, ApplicationDbContext context)
        {
            _hostEnvironment = hostEnvironment;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(_hostEnvironment.WebRootPath, "Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var imageModel = new UploadImage { FileName = fileName, ImageData = GetFileBytes(filePath) };
                _context.UploadImages.Add(imageModel);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View("Index");
        }

        private byte[] GetFileBytes(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    return reader.ReadBytes((int)stream.Length);
                }
            }
        }

    }
}

using CustomerUserModel.Data;
using CustomerUserModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace CustomerUserModel.Controllers
{
	public class GymTraineeController : Controller
	{
		//private readonly ApplicationDbContext _context;
		//private readonly IWebHostEnvironment _webHostEnvironment;
		//public GymTraineeController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
		//{
		//	_context = context;
		//	_webHostEnvironment = webHostEnvironment;
		//}
		//public IActionResult Index()
		//{
		//	return View();
		//}
		//[HttpGet]
		//public IActionResult SaveTraineeInfo(int Id)
		//{
		//	#region  Blood Group
		//	TrainingLevel training = new TrainingLevel();
		//	List<SelectListItem> DJTList = new List<SelectListItem>();


		//	//GymTrainee gymTrainee = new GymTrainee();
		//	var OJList = new List<SelectListItem>();
		//	var BGL = _context.bloodGroup.ToList();

		//	foreach (var item in BGL)
		//	{
		//		OJList.Add(new SelectListItem() { Text = item.BloodGroupName, Value = item.BloodGroupID.ToString() });
		//	}

		//	ViewBag.BGL = OJList;
		//	#endregion;
		//	#region Traning Level
		//	var TLL = _context.trainingLevel.ToList();

		//	foreach (var item in TLL)
		//	{
		//		DJTList.Add(new SelectListItem() { Text = item.TrainingLevelName, Value = item.TrainingLevelId.ToString() });
		//	}

		//	ViewBag.DJTList = DJTList;
		//	#endregion;
		//	#region Height Input
		//	List<SelectListItem> heightList = new List<SelectListItem>();

		//	heightList.Add(new SelectListItem() { Text = "4", Value = "4" });
		//	heightList.Add(new SelectListItem() { Text = "4.1", Value = "4.1" });
		//	heightList.Add(new SelectListItem() { Text = "4.2", Value = "4.2" });
		//	heightList.Add(new SelectListItem() { Text = "4.3", Value = "4.3" });
		//	heightList.Add(new SelectListItem() { Text = "4.4", Value = "4.4" });
		//	heightList.Add(new SelectListItem() { Text = "4.5", Value = "4.5" });
		//	heightList.Add(new SelectListItem() { Text = "4.6", Value = "4.6" });
		//	heightList.Add(new SelectListItem() { Text = "4.7", Value = "4.7" });
		//	heightList.Add(new SelectListItem() { Text = "4.8", Value = "4.8" });
		//	heightList.Add(new SelectListItem() { Text = "4.9", Value = "4.9" });

		//	heightList.Add(new SelectListItem() { Text = "5.0", Value = "5.0" });
		//	heightList.Add(new SelectListItem() { Text = "5.1", Value = "5.1" });
		//	heightList.Add(new SelectListItem() { Text = "5.2", Value = "5.2" });
		//	heightList.Add(new SelectListItem() { Text = "5.3", Value = "5.3" });
		//	heightList.Add(new SelectListItem() { Text = "5.4", Value = "5.4" });
		//	heightList.Add(new SelectListItem() { Text = "5.5", Value = "5.5" });
		//	heightList.Add(new SelectListItem() { Text = "5.6", Value = "5.6" });
		//	heightList.Add(new SelectListItem() { Text = "5.7", Value = "5.7" });
		//	heightList.Add(new SelectListItem() { Text = "5.8", Value = "5.8" });
		//	heightList.Add(new SelectListItem() { Text = "5.9", Value = "5.9" });

		//	heightList.Add(new SelectListItem() { Text = "6.0", Value = "6.0" });
		//	heightList.Add(new SelectListItem() { Text = "6.1", Value = "6.1" });
		//	heightList.Add(new SelectListItem() { Text = "6.2", Value = "6.2" });
		//	heightList.Add(new SelectListItem() { Text = "6.3", Value = "6.3" });
		//	heightList.Add(new SelectListItem() { Text = "6.4", Value = "6.4" });
		//	heightList.Add(new SelectListItem() { Text = "6.5", Value = "6.5" });
		//	heightList.Add(new SelectListItem() { Text = "6.6", Value = "6.6" });
		//	heightList.Add(new SelectListItem() { Text = "6.7", Value = "6.7" });
		//	heightList.Add(new SelectListItem() { Text = "6.8", Value = "6.8" });
		//	heightList.Add(new SelectListItem() { Text = "6.9", Value = "6.9" });

		//	#endregion
		//	ViewBag.Height_TL = heightList;
		//	return View();
		//}
		//[HttpPost]
		//public async Task<IActionResult> SaveTraineeInfo([Bind("TraineeId, FirstName,LastName, ContactNo,Gender,Age,Height,weight,Address,ImageName,CreateDate,ImageFile,BloodGroupId,MonthlyFee")] GymTrainee trainee)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		// This code for Image
		//		string wwwRootPath = _webHostEnvironment.WebRootPath;
		//		string firstName = Path.GetFileNameWithoutExtension(trainee.ImageFile.FileName);
		//		string extension = Path.GetExtension(trainee.ImageFile.FileName);
		//		trainee.ImageName = firstName = firstName + DateTime.Now.ToString("G") + extension;
		//		string path = Path.Combine(wwwRootPath + "/Images", firstName);

		//		using (var fileStream = new FileStream(path, FileMode.Create))
		//		{
		//			await trainee.ImageFile.CopyToAsync(fileStream);
		//		}
		//		trainee.CreationDate = System.DateTime.Now;
		//		_context.Add(trainee);
		//		await _context.SaveChangesAsync();
		//		RedirectToAction("Index");
		//	}
		//	return View();
		}



	}


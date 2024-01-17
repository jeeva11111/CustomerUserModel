using CustomerUserModel.Data;
using CustomerUserModel.Models.DisplayModel;
using CustomerUserModel.Views.Cascade;
using Microsoft.AspNetCore.Mvc;

namespace CustomerUserModel.Controllers.Cascade
{
	public class CascadeController : Controller
	{
		private readonly ApplicationDbContext _context;
		public CascadeController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetUserList()
		{
			var data = (from user in _context.Users
						join country in _context.Countries on user.CountryId equals country.CId
						join state in _context.States on country.CId equals state.CountryId
						join city in _context.Cities on state.SId equals city.StateId
						select new UserCountryModelView
						{
							UserId = user.UserId,
							Name = user.Name,
							StateName = state.StateName,
							CountryName = country.CountryName,
							CityName = city.CityName
						}).ToList();

			return Json(data);
		}

		public IActionResult GetCountries()
		{
			var data = _context.Countries.ToList();
			return Json(data);
		}

		public IActionResult GetState(int countryId)
		{
			//var data = from state in _context.States where s select state;
			var data = _context.States.Where(x => x.Country.CId == countryId).ToList();
			return Json(data);
		}
		public IActionResult GetCity(int stateId)
		{
			var data = _context.Cities.Where(x => x.State.SId == stateId).ToList();
			return Json(data);
		}
		[HttpPost]
		public IActionResult AddUser(User user)
		{
			try
			{
				if (user == null)
				{
					return Json(new { success = false, message = "Invalid user data." });
				}

				_context.Users.Add(user);
				_context.SaveChanges();

				return Json(new { success = true, message = "User added successfully." });
			}
			catch (Exception ex)
			{
				return Json(new { success = false, message = ex.Message });
			}
		}

		[HttpPost]
		public IActionResult UpdateUser(User updatedUser)
		{
			try
			{
				// Check if the updatedUser object received is valid
				if (updatedUser == null)
				{
					return Json(new { success = false, message = "Invalid user data." });
				}

				var existingUser = _context.Users.Find(updatedUser.UserId);

				if (existingUser == null)
				{
					return Json(new { success = false, message = "User not found." });
				}

				existingUser.Name = updatedUser.Name;
				existingUser.CountryId = updatedUser.CountryId;
				existingUser.StateId = updatedUser.StateId;
				existingUser.CityId = updatedUser.CityId;


				_context.SaveChanges();

				return Json(new { success = true, message = "User updated successfully." });
			}
			catch (Exception ex)
			{
				// Log the exception or handle it appropriately
				return Json(new { success = false, message = "An error occurred while updating the user." });
			}
		}

		[HttpPost]
		public IActionResult DeleteUser(int userId)

		{
			try
			{
				var user = _context.Users.Find(userId);

				if (user == null)
				{
					return Json(new { success = false, message = "User not found." });
				}

				_context.Users.Remove(user);
				_context.SaveChanges();

				return Json(new { success = true, message = "User deleted successfully." });
			}
			catch (Exception ex)
			{
				return Json(new { success = false, message = "An error occurred while deleting the user." });
			}
		}

		[HttpGet]
		public IActionResult GetUserById(int userId)
		{
			var user = _context.Users.Find(userId);

			if (user == null)
			{
				return Json(null);
			}

			return Json(new
			{
				userId = user.UserId,
				name = user.Name,
				countryId = user.CountryId,
				stateId = user.StateId,
				cityId = user.CityId
			});
		}


	}
}

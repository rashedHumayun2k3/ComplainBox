using CB.Api.Exceptions;
using CB.Api.Models;
using CB.Business.Dto.Response;
using CB.Business.Managers;
using CB.Business.Managers.Implementations;
using CB.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Net;

namespace CB.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		readonly IProductManager _productManager;
		readonly ILogger<ProductController> _logger;
	
		public ProductController (IProductManager productManager, ILogger<ProductController> logger)
		{
			_productManager = productManager;
			_logger = logger;

		}

		//[HttpGet("{id}")]
		//[ProducesResponseType(typeof(Business.Dto.Response.ProductDto), 200)]
		//[ProducesResponseType(404)]
		//public async Task<ApiResponse<ProductDto>> Get(int id)
		//{


		//	_logger.LogDebug("LogError LogDebug.");
		//	_logger.LogInformation("Information loggin.");
		//	_logger.LogWarning("LogWarning");
		//	_logger.LogError("LogError loggin.");
		//	var response = new ApiResponse<ProductDto>();

		//	//try
		//	//{
		//	//	var data = await _productManager.GetProductById(id);
		//	//	response.Success = true;
		//	//	response.Result = data;
		//	//}
		//	//catch (Exception ex)
		//	//{
		//	//	response.Success = false;
		//	//	response.Message = ex.Message;
		//	//	//Logger.Instance.Error("Exception:", ex);
		//	//}
		//	var data = await _productManager.GetProductById(id);
		//	response.Success = true;
		//	response.Result = data;
		//	return response;
		//}
		//Rashed Maruf Maruf
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(ProductDto), 200)]
		[ProducesResponseType(404)]
		public async Task<IActionResult> Get(int id)
		{
			//BackgroundJob.Enqueue(() => _notificationJob.SendWelcomeEmail("ahammedmaroof@gmail.com"));
			//throw new HttpResponseException("Customer Name cannot be empty");
			//if (id <= 0)
			//	//return NotFound("Id not found");
			//	return Problem("Id not found.", statusCode: StatusCodes.Status404NotFound);

			return Ok(await _productManager.GetProductById(id));
		}

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get()
		{
			//
			string dynamicSearchingQuery = string.Empty;
            return Ok(await _productManager.GetProduct(dynamicSearchingQuery));
        }
		
		


	}
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poseidon.API.ActionFilters;
using Poseidon.API.Models;
using Poseidon.API.Services.Interfaces;
using Poseidon.Shared.InputModels;

namespace Poseidon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BidListController : ControllerBase
    {
        private readonly IBidListService _bidListService;

        public BidListController(IBidListService bidListService)
        {
            _bidListService = bidListService;
        }

        // GET: api/BidLists
        /// <summary>
        /// Gets a list of all BidList entities.
        /// </summary>
        /// <returns>A list of all BidList entities.</returns>
        /// <response code="200">Returns the list of all BidList entities.</response>
        /// <response code="401">The user is not authorized to access this resource.</response>
        /// <response code="404">No BidList entities were found.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<BidListInputModel>>> Get()
        {
            var results =
                await _bidListService.GetAllBidListsAsInputModelsAsync();

            var entityList =
                results as BidListInputModel[] ?? results.ToArray();

            if (!entityList.Any())
            {
                return NotFound();
            }

            return Ok(results);
        }

        // GET: api/BidLists/5
        /// <summary>
        /// Gets a single BidList entity.
        /// </summary>
        /// <param name="id">The Id of the BidList entity to get.</param>
        /// <returns>The specified BidList entity.</returns>
        /// <response code="200">Returns the BidList entity.</response>
        /// <response code="400">Bad Id.</response>
        /// <response code="404">The specified entity was not found.</response>
        /// <response code="401">The user is not authorized to access this resource.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BidListInputModel>> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            if (!_bidListService.BidListExists(id))
            {
                return NotFound();
            }

            var result = await _bidListService.GetBidListByIdAsInputModelASync(id);

            return Ok(result);
        }

        // POST: api/BidLists
        /// <summary>
        /// Creates a new BidList entity. 
        /// </summary>
        /// <param name="inputModel">Data for the new entity.</param>
        /// <returns>The created entity.</returns>
        /// <response code="201">The entity was successfully created.</response>
        /// <response code="400">Bad request.</response>
        /// <response code="401">The user is not authorized to access this resource.</response>
        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<BidListInputModel>> Post(BidListInputModel inputModel)
        {
            if (inputModel == null)
            {
                return BadRequest();
            }

            var resultId = await _bidListService.CreateBidList(inputModel);

            return CreatedAtAction("Get", new { id = resultId }, inputModel);
        }

        // PUT: api/BidLists/5
        /// <summary>
        /// Updates a BidList entity.
        /// </summary>
        /// <param name="id">The Id of the BidList entity to update.</param>
        /// <param name="inputModel">Updated data.</param>
        /// <returns>Null.</returns>
        /// <response code="204">The resource was successfully updated.</response>
        /// <response code="401">The user is not authorized to access this resource.</response>
        /// <response code="404">The specified entity was not found.</response>
        [HttpPut("{id}")]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Put(int id, BidListInputModel inputModel)
        {
            if (!_bidListService.BidListExists(id))
            {
                return NotFound($"No BidList entity matching the id [{id}] was found.");
            }

            await _bidListService.UpdateBidList(id, inputModel);

            return NoContent();
        }

        // DELETE: api/BidLists/5
        /// <summary>
        /// Deletes a specified BidList entity.
        /// </summary>
        /// <param name="id">The Id the BidList entity to delete.</param>
        /// <returns>Null.</returns>
        /// <response code="204">The entity was successfully created.</response>
        /// <response code="401">The user is not authorized to access this resource.</response>
        /// <response code="403">The user lacks privileges to access resource.</response>
        /// <response code="404">The specified entity was not found.</response>
        [Authorize(Policy = "Admin")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BidList>> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest(
                    $"The '{nameof(id)}' argument must a non-zero, positive integer value. The passed-in value was {id}");
            }

            if (!_bidListService.BidListExists(id))
            {
                return NotFound($"No {typeof(BidList)} entity matching the id [{id}] was found.");
            }

            await _bidListService.DeleteBidList(id);

            return NoContent();
        }
    }
}
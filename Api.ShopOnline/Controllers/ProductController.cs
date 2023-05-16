using Api.ShopOnline.Extension;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopOnline.Api.Models;
using shopOnline.Api.Repositories.Contracts;
using ShopOnline.Modes.DTOs;
using System.Collections.Generic;

namespace Api.ShopOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Getcategories()
        {
            return Ok(await _productRepository.GetCategories());
            //try
            //{
            //    var Product = await _productRepository.GetItems();
            //    var productCategories = await _productRepository.GetCategories();
            //    var productsDTO = _mapper.Map<ProductDTO>(Product);
            //    return Ok(productsDTO);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}


        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductCategory>> GetCategorie(int id)
        {
            try
            {
                return Ok(await _productRepository.GetCategory(id));
            }
            catch
            {
                return BadRequest();
            }
            
        }
        [HttpGet("api/[controller]/Item/{id}")]
        public async Task<ActionResult<ProductDTO>> GetItem(int id)
        {
            try
            {
                Product Productreturned = await _productRepository.GetItem(id);
                ProductDTO productDTO = _mapper.Map<ProductDTO>(Productreturned);


                return Ok(productDTO);
            }catch
            {
                return BadRequest("not found");
            }

            
        }
        [HttpGet("api/[controller]/Items")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItems()
        {
            try
            { 
                 //-------------------------------------------- when  I use Automapper to maapinga data with other types i can't because  the type how I hope to map is list ---------------------------
                //return Ok( await _productRepository.GetItems());
                ////IReadOnlyList<Product> ListOfProduct = await _productRepository.GetItems();
                ////IReadOnlyList<ProductDTO> listofpdtDto = _mapper.Map<IReadOnlyList<ProductDTO>>(ListOfProduct);
                ////return Ok(listofpdtDto);
                ///
                var products = await _productRepository.GetItems(); 
                var  productCategories = await _productRepository.GetCategories();
                if(products == null || productCategories == null)
                {
                    return NotFound();
                }
                var prodctDto = products.ConvertToDto(productCategories); 
                return Ok(prodctDto);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}

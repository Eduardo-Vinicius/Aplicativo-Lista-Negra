using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ListaNegraController :ControllerBase
    {

        Business.ListaNegraBusiness buss = new Business.ListaNegraBusiness();
        Utils.ListaNegraConversor util = new Utils.ListaNegraConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.ListaNegraResponse> Inserir(Models.Request.ListaNegraRequest request)
        {
            try
            {
                Models.TbListaNegra ln = util.ParaTabela(request);
                buss.Salvar(ln);

                Models.Response.ListaNegraResponse resp = util.ParaResponse(ln);
                return resp;
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }

        [HttpGet]
        public ActionResult<List<Models.Response.ListaNegraResponse>> Listar()
        {
            try
            {
                List<Models.TbListaNegra> lns = buss.Listar();
                if (lns.Count == 0)
                    return NotFound();

                List<Models.Response.ListaNegraResponse> resp = util.ParaResponse(lns);
                return resp;

                
    
            }
            catch (System.Exception ex)
            {

                return BadRequest(
                    new Models.Response.ErroResponse(500, ex.Message)
                );
            }
        }




    }
}

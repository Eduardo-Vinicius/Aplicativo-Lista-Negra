using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Database
{
    public class ListaNegraDatabase
    {

        Models.lndbContext db = new Models.lndbContext();

        public Models.TbListaNegra Salvar (Models.TbListaNegra ln)
        {
            db.Add(ln);
            db.SaveChanges();

            return ln;
        }

        public List<Models.TbListaNegra> Listar()
        {
            List<Models.TbListaNegra> lns = db.TbListaNegra.ToList();
            return lns;
        }
    }
}
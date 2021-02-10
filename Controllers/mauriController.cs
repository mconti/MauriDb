using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MauriDb.Models;

namespace MauriDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MauriPetraController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Prenotazione> Get()
        {
            MauriDbContext db = new MauriDbContext();

            // Se non ci sono record, ne aggiunge uno...
            if( db.Prenotazioni.Count()==0 ) {
                db.Prenotazioni.Add(
                    new Prenotazione{ Nome="Maurizio Conti", Email="maurizio.conti@fablabromagna.org" }
                );
                db.SaveChanges();
            }

            // Ritorna la tabella completa
            return db.Prenotazioni;
        }
    }
}

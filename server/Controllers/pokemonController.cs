using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;
using server.DataAccess;
using server.Domain;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [ApiController]
    [Route("api")]
    public class pokemonController : ControllerBase
    {
        private readonly IMapper map;
        private readonly pokemonDataContext db;

        public pokemonController(pokemonDataContext _db, IMapper _map)
        {
            db = _db;
            map = _map;
        }

        [HttpGet]
        public ActionResult<IEnumerable<pokemon>> getAllPokemon()
        {
            //var pokemonResult = db.pokemon.Include(x => x.type).ToList();
            return Ok(map.ProjectTo<pokemon>(db.pokemon));
        }
    }
}
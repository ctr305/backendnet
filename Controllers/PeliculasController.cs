using backendnet.Data;
using backendnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendnet.Controllers;

[Route("api/[controller]")]
[ApiController]

public class PeliculasController(DataContext context) : Controller
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pelicula>>> GetPeliculas(string? s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return await context.Peliculas.ToListAsync();
        }

        return await context.Peliculas.Where(p => p.Titulo.Contains(s)).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pelicula>> GetPelicula(int id)
    {
        var pelicula = await context.Peliculas.FindAsync(id);

        if (pelicula == null)
        {
            return NotFound();
        }

        return pelicula;
    }

    [HttpPost]
    public async Task<ActionResult<Pelicula>> PostPelicula(PeliculaDTO peliculaDTO)
    {
        var pelicula = new Pelicula
        {
            Titulo = peliculaDTO.Titulo,
            Sinopsis = peliculaDTO.Sinopsis,
            Anio = peliculaDTO.Anio,
            Poster = peliculaDTO.Poster,
            Categorias = []
        };

        context.Peliculas.Add(pelicula);
        await context.SaveChangesAsync();

        return CreatedAtAction("GetPelicula", new { id = pelicula.PeliculaId }, pelicula);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPelicula(int id, PeliculaDTO peliculaDTO)
    {
        if (id != peliculaDTO.PeliculaId)
        {
            return BadRequest();
        }

        var pelicula = await context.Peliculas.FirstOrDefaultAsync(p => p.PeliculaId == id);
        if (pelicula == null)
        {
            return NotFound();
        }

        pelicula.Titulo = peliculaDTO.Titulo;
        pelicula.Sinopsis = peliculaDTO.Sinopsis;
        pelicula.Anio = peliculaDTO.Anio;
        pelicula.Poster = peliculaDTO.Poster;

        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePelicula(int id)
    {
        var pelicula = await context.Peliculas.FindAsync(id);
        if (pelicula == null)
        {
            return NotFound();
        }

        context.Peliculas.Remove(pelicula);
        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("{id}/categoria")]
    public async Task<IActionResult> PostCategoria(int id, AsignaCategoriaDTO itemToAdd)
    {
        Categoria? categoria = await context.Categorias.FindAsync(itemToAdd.CategoriaId);
        if (categoria == null)
        {
            return NotFound();
        }

        var pelicula = await context.Peliculas.Include(p => p.Categorias).FirstOrDefaultAsync(p => p.PeliculaId == id);
        if (pelicula == null)
        {
            return NotFound();
        }

        if (pelicula?.Categorias?.FirstOrDefault(categoria) != null)
        {
            pelicula.Categorias.Add(categoria);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }

    [HttpDelete("{id}/categoria/{categoriaId}")]
    public async Task<IActionResult> DeleteCategoria(int id, int categoriaId)
    {
        var pelicula = await context.Peliculas.FindAsync(id);
        var categoria = await context.Categorias.FindAsync(categoriaId);

        if (pelicula == null || categoria == null)
        {
            return NotFound();
        }

        pelicula.Categorias.Remove(categoria);
        await context.SaveChangesAsync();

        return NoContent();
    }
}
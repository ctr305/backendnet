using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedPelicula : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        builder.HasData(
            new Pelicula { PeliculaId = 1, Titulo = "The Shawshank Redemption", Sinopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Anio = 1994, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9O7gLzmreU0nGkIB6K3BsJbzvNv.jpg"},
            new Pelicula { PeliculaId = 2, Titulo = "The Godfather", Sinopsis = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", Anio = 1972, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3bhkrj58Vtu7enYsRolD1fZdja1.jpg"},
            new Pelicula { PeliculaId = 3, Titulo = "The Dark Knight", Sinopsis = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", Anio = 2008, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/qJ2tW6WMUDux911r6m7haRef0WH.jpg"},
            new Pelicula { PeliculaId = 4, Titulo = "12 Angry Men", Sinopsis = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", Anio = 1957, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3W0v956XxSG5xgm7LB6qu8ExYJ2.jpg"},
            new Pelicula { PeliculaId = 5, Titulo = "Schindler's List", Sinopsis = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution.", Anio = 1993, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/sF1U4EUQS8YHUYjNl3pMGNIQyr0.jpg"},
            new Pelicula { PeliculaId = 6, Titulo = "12 Monkeys", Sinopsis = "In a future world devastated by disease, a convict is sent back in time to gather information, but makes a shocking discovery about the true nature of the scheme.", Anio = 1995, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/6Sj9wDu3YugthXsU0Vry5XFAZGg.jpg"},
            new Pelicula { PeliculaId = 7, Titulo = "Rashōmon", Sinopsis = "After a heinous crime transpires in a forest, conflicting accounts arise and multiple perspectives are presented to the court.", Anio = 1950, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8f1l2alXHqO1e8WZlJv4m6l4D5l.jpg"},
            new Pelicula { PeliculaId = 8, Titulo = "Fight Club", Sinopsis = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.", Anio = 1999, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4yJyaw7JGzF5g8itkZ5jX3GQ1j3.jpg"},
            new Pelicula { PeliculaId = 9, Titulo = "The Lighthouse", Sinopsis = "Two lighthouse keepers try to maintain their sanity while living on a remote and mysterious New England island in the 1890s.", Anio = 2019, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/5Eiqj4p0o7j5hHv8Fp8tv0j1H9R.jpg"},
            new Pelicula { PeliculaId = 10, Titulo = "The Matrix", Sinopsis = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", Anio = 1999, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/hEpWvX6Bp79eLxY1kX5ZZJcme5U.jpg"},
            new Pelicula { PeliculaId = 11, Titulo = "The Shining", Sinopsis = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", Anio = 1980, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9fgh3Ns1iRzlQNYuJyK0ARQZU7w.jpg"},
            new Pelicula { PeliculaId = 12, Titulo = "Jacob's Ladder", Sinopsis = "Mourning his dead child, a haunted Vietnam War veteran attempts to uncover his past while suffering from a severe case of dissociation. To do so, he must decipher reality and life from his own dreams, delusions, and perceptions of death.", Anio = 1990, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7y3eYvTsGjxPYDtSnumCLIMDkrV.jpg"},
            new Pelicula { PeliculaId = 13, Titulo = "The Thing", Sinopsis = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.", Anio = 1982, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg"},
            new Pelicula { PeliculaId = 14, Titulo = "Memento", Sinopsis = "An amnesiac man is determined to track down the man who raped and murdered his wife.", Anio = 2000, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/fQMSaP88cf1nz4qwuNEEFtazuDM.jpg"},
            new Pelicula { PeliculaId = 15, Titulo = "The Silence of the Lambs", Sinopsis = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", Anio = 1991, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7s7f7c0mQwv2F5qex3Oe7K5VFj.jpg"},
            new Pelicula { PeliculaId = 16, Titulo = "Oldboy", Sinopsis = "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.", Anio = 2003, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8YyJWVrjZzY3fZ1RlZJbC8GKbBD.jpg"},
            new Pelicula { PeliculaId = 17, Titulo = "The Prestige", Sinopsis = "After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.", Anio = 2006, Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7SGGUiTE6oc2fh9MjIk5M00dsQd.jpg"}
        );
    }
}

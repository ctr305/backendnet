using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class CreacionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriaPelicula",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    PeliculasPeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPelicula", x => new { x.CategoriasCategoriaId, x.PeliculasPeliculaId });
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Categorias_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Peliculas_PeliculasPeliculaId",
                        column: x => x.PeliculasPeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre", "Protegida" },
                values: new object[,]
                {
                    { 1, "Acción", true },
                    { 2, "Aventura", true },
                    { 3, "Animación", true },
                    { 4, "Ciencia Ficción", true },
                    { 5, "Comedia", true },
                    { 6, "Crimen", true },
                    { 7, "Documental", true },
                    { 8, "Drama", true },
                    { 9, "Familiar", true },
                    { 10, "Fantasía", true },
                    { 11, "Historia", true },
                    { 12, "Horror", true },
                    { 13, "Música", true },
                    { 14, "Misterio", true },
                    { 15, "Romance", true }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Anio", "Poster", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 1994, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9O7gLzmreU0nGkIB6K3BsJbzvNv.jpg", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "The Shawshank Redemption" },
                    { 2, 1972, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "The Godfather" },
                    { 3, 2008, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/qJ2tW6WMUDux911r6m7haRef0WH.jpg", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "The Dark Knight" },
                    { 4, 1957, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3W0v956XxSG5xgm7LB6qu8ExYJ2.jpg", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "12 Angry Men" },
                    { 5, 1993, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/sF1U4EUQS8YHUYjNl3pMGNIQyr0.jpg", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution.", "Schindler's List" },
                    { 6, 1995, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/6Sj9wDu3YugthXsU0Vry5XFAZGg.jpg", "In a future world devastated by disease, a convict is sent back in time to gather information, but makes a shocking discovery about the true nature of the scheme.", "12 Monkeys" },
                    { 7, 1950, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8f1l2alXHqO1e8WZlJv4m6l4D5l.jpg", "After a heinous crime transpires in a forest, conflicting accounts arise and multiple perspectives are presented to the court.", "Rashōmon" },
                    { 8, 1999, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4yJyaw7JGzF5g8itkZ5jX3GQ1j3.jpg", "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.", "Fight Club" },
                    { 9, 2019, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/5Eiqj4p0o7j5hHv8Fp8tv0j1H9R.jpg", "Two lighthouse keepers try to maintain their sanity while living on a remote and mysterious New England island in the 1890s.", "The Lighthouse" },
                    { 10, 1999, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/hEpWvX6Bp79eLxY1kX5ZZJcme5U.jpg", "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", "The Matrix" },
                    { 11, 1980, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9fgh3Ns1iRzlQNYuJyK0ARQZU7w.jpg", "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", "The Shining" },
                    { 12, 1990, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7y3eYvTsGjxPYDtSnumCLIMDkrV.jpg", "Mourning his dead child, a haunted Vietnam War veteran attempts to uncover his past while suffering from a severe case of dissociation. To do so, he must decipher reality and life from his own dreams, delusions, and perceptions of death.", "Jacob's Ladder" },
                    { 13, 1982, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.", "The Thing" },
                    { 14, 2000, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/fQMSaP88cf1nz4qwuNEEFtazuDM.jpg", "An amnesiac man is determined to track down the man who raped and murdered his wife.", "Memento" },
                    { 15, 1991, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7s7f7c0mQwv2F5qex3Oe7K5VFj.jpg", "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", "The Silence of the Lambs" },
                    { 16, 2003, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8YyJWVrjZzY3fZ1RlZJbC8GKbBD.jpg", "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.", "Oldboy" },
                    { 17, 2006, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7SGGUiTE6oc2fh9MjIk5M00dsQd.jpg", "After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.", "The Prestige" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPelicula_PeliculasPeliculaId",
                table: "CategoriaPelicula",
                column: "PeliculasPeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaPelicula");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}

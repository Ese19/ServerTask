// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ServerTask.Data;

#nullable disable

namespace ServerTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221028224716_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ServerTask.Entities.Info", b =>
                {
                    b.Property<string>("slackUsername")
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<bool>("backend")
                        .HasColumnType("boolean");

                    b.Property<string>("bio")
                        .HasColumnType("text");

                    b.HasKey("slackUsername");

                    b.ToTable("Infos");

                    b.HasData(
                        new
                        {
                            slackUsername = "Ese_O",
                            age = 28,
                            backend = true,
                            bio = "Hereos never die!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

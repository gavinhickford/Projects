using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SIGN.Data.EFCore;
using SIGN.Domain.Classes;

namespace SIGN.Data.EFCore.Migrations
{
    [DbContext(typeof(SIGNContext))]
    [Migration("20170107184309_Update4")]
    partial class Update4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SIGN.Domain.Classes.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("GuidelineId");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("GuidelineId");

                    b.ToTable("Assessment");
                });

            modelBuilder.Entity("SIGN.Domain.Classes.Guideline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<DateTime>("DatePublished");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Guidelines");
                });

            modelBuilder.Entity("SIGN.Domain.Classes.Assessment", b =>
                {
                    b.HasOne("SIGN.Domain.Classes.Guideline", "Guideline")
                        .WithMany("Assessments")
                        .HasForeignKey("GuidelineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

﻿// <auto-generated />
using BookStoreRepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreRepositoryLayer.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20210226110810_UpdateModels")]
    partial class UpdateModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreModelLayer.BooksModels.BookModel", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .IsRequired();

                    b.Property<int>("BookCount");

                    b.Property<string>("BookDescription")
                        .IsRequired();

                    b.Property<string>("BookImage")
                        .IsRequired();

                    b.Property<string>("BookName")
                        .IsRequired();

                    b.Property<int>("BookPrice");

                    b.HasKey("BookId");

                    b.ToTable("BookTable");
                });

            modelBuilder.Entity("BookStoreModelLayer.BooksModels.CartModel", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookCount");

                    b.Property<int>("BookId");

                    b.Property<int>("UserId");

                    b.HasKey("CartId");

                    b.ToTable("CartTable");
                });

            modelBuilder.Entity("BookStoreModelLayer.BooksModels.OrderModel", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderSummaryID");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

                    b.ToTable("OrderSummaryTable");
                });

            modelBuilder.Entity("BookStoreModelLayer.BooksModels.WishlistModel", b =>
                {
                    b.Property<int>("WishlistID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("UserId");

                    b.HasKey("WishlistID");

                    b.ToTable("WishlistTable");
                });

            modelBuilder.Entity("BookStoreModelLayer.CustomerModels.CustomerModel", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("AddressTypeId");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("Locality")
                        .IsRequired();

                    b.Property<long>("PhoneNumber");

                    b.Property<long>("PinCode");

                    b.Property<int>("UserId");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerTable");
                });

            modelBuilder.Entity("BookStoreModelLayer.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<long>("Mobile");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("UserTabel");
                });

            modelBuilder.Entity("BookStoreModelLayer.UserModels.AddressTypeModel", b =>
                {
                    b.Property<int>("AddressTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressType")
                        .IsRequired();

                    b.HasKey("AddressTypeId");

                    b.ToTable("AddressTypeTable");
                });
#pragma warning restore 612, 618
        }
    }
}

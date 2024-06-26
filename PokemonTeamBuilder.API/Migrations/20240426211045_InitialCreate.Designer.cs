﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonTeamBuilder.API.DB;

#nullable disable

namespace PokemonTeamBuilder.API.Migrations
{
    [DbContext(typeof(PokemonTrainerDbContext))]
    [Migration("20240426211045_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PkmapiAbilityJunc", b =>
                {
                    b.Property<int>("PkmApiId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_API_ID");

                    b.Property<int>("AbilityId")
                        .HasColumnType("int")
                        .HasColumnName("AbilityID");

                    b.HasKey("PkmApiId", "AbilityId")
                        .HasName("PokmeonToAbility");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("PkmApiId", "AbilityId"), false);

                    b.HasIndex("AbilityId");

                    b.ToTable("PKMAPI_Ability_Junc", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PkmapiMoveJunc", b =>
                {
                    b.Property<int>("MoveId")
                        .HasColumnType("int")
                        .HasColumnName("MoveID");

                    b.Property<int>("PkmApiId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_API_ID");

                    b.HasKey("MoveId", "PkmApiId")
                        .HasName("PokemonToMove");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("MoveId", "PkmApiId"), false);

                    b.HasIndex("PkmApiId");

                    b.ToTable("PKMAPI_Move_Junc", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PkmapiTypeJunc", b =>
                {
                    b.Property<int>("PkmApiId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_API_ID");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("TypeID");

                    b.HasKey("PkmApiId", "TypeId")
                        .HasName("PokemonToType");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("PkmApiId", "TypeId"), false);

                    b.HasIndex("TypeId");

                    b.ToTable("PKMAPI_Type_Junc", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.ItemPokeApi", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sprite")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"), false);

                    b.ToTable("Item_PokeAPI", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsHidden")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("URL");

                    b.HasKey("Id")
                        .HasName("PK__tmp_ms_x__3214EC273C1B459E");

                    b.ToTable("PokemonAbility", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonBaseStat", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("BaseStat")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PkmApiId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_API_ID");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("URL");

                    b.HasKey("Id");

                    b.HasIndex("PkmApiId");

                    b.ToTable("PokemonBaseStat", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonMove", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("URL");

                    b.HasKey("Id")
                        .HasName("PK__tmp_ms_x__3214EC273D048BD9");

                    b.ToTable("PokemonMove", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonMoveSet", b =>
                {
                    b.Property<int>("PkmTmId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_TM_ID");

                    b.Property<string>("Move1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("move_1");

                    b.Property<string>("Move2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("move_2");

                    b.Property<string>("Move3")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("move_3");

                    b.Property<string>("Move4")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("move_4");

                    b.HasKey("PkmTmId");

                    b.ToTable("PokemonMoveSet", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonPokeApi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id")
                        .HasName("PK__Pokemon___3214EC26604EAF0F");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"), false);

                    b.ToTable("Pokemon_PokeAPI", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonSprite", b =>
                {
                    b.Property<int>("PkmApiId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_API_ID");

                    b.Property<string>("FrontDefault")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FrontFemale")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FrontShiny")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FrontShinyFemale")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PkmApiId");

                    b.ToTable("PokemonSprite", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Effort")
                        .HasColumnType("int");

                    b.Property<int>("Individual")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PkmTmId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_TM_ID");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("URL");

                    b.HasKey("Id");

                    b.HasIndex("PkmTmId");

                    b.ToTable("PokemonStat", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int")
                        .HasColumnName("TrainerID");

                    b.HasKey("Id")
                        .HasName("PK__PokemonT__3214EC27AE892B21");

                    b.HasIndex("TrainerId");

                    b.ToTable("PokemonTeam", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonTeamMember", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("ChosenAbilityId")
                        .HasColumnType("int")
                        .HasColumnName("ChosenAbilityID");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<int>("HeldItemId")
                        .HasColumnType("int")
                        .HasColumnName("HeldItemID");

                    b.Property<bool>("IsShiny")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PkmApiId")
                        .HasColumnType("int")
                        .HasColumnName("PKM_API_ID");

                    b.Property<int>("PokemonTeamId")
                        .HasColumnType("int")
                        .HasColumnName("PokemonTeamID");

                    b.Property<string>("TeraType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ChosenAbilityId");

                    b.HasIndex("HeldItemId");

                    b.HasIndex("PkmApiId");

                    b.HasIndex("PokemonTeamId");

                    b.ToTable("Pokemon_TeamMember", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__tmp_ms_x__3214EC27C57EA4A8");

                    b.ToTable("PokemonType", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(26)
                        .HasColumnType("nvarchar(26)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__tmp_ms_x__3214EC27D0BCCEE9");

                    b.ToTable("Trainer", "PokemonTeamBuilder");
                });

            modelBuilder.Entity("PkmapiAbilityJunc", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonAbility", null)
                        .WithMany()
                        .HasForeignKey("AbilityId")
                        .IsRequired()
                        .HasConstraintName("FK_PKMAPI_Ability_Junc_PokemonAbility");

                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonPokeApi", null)
                        .WithMany()
                        .HasForeignKey("PkmApiId")
                        .IsRequired()
                        .HasConstraintName("FK_PKMAPI_Ability_Junc_Pokemon_PokeAP");
                });

            modelBuilder.Entity("PkmapiMoveJunc", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonMove", null)
                        .WithMany()
                        .HasForeignKey("MoveId")
                        .IsRequired()
                        .HasConstraintName("FK_PKMAPI_Move_Junc_PokemonMove");

                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonPokeApi", null)
                        .WithMany()
                        .HasForeignKey("PkmApiId")
                        .IsRequired()
                        .HasConstraintName("FK_PKMAPI_Move_Junc_Pokemon_PokeAPI");
                });

            modelBuilder.Entity("PkmapiTypeJunc", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonPokeApi", null)
                        .WithMany()
                        .HasForeignKey("PkmApiId")
                        .IsRequired()
                        .HasConstraintName("FK_PKMAPI_Type_Junc_Pokemon_PokeAPI");

                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonType", null)
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .IsRequired()
                        .HasConstraintName("FK_PKMAPI_Type_Junc_PokemonType");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonBaseStat", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonPokeApi", "PkmApi")
                        .WithMany("PokemonBaseStats")
                        .HasForeignKey("PkmApiId")
                        .IsRequired()
                        .HasConstraintName("FK_PokemonBaseStat_Pokemon_PokeAPI");

                    b.Navigation("PkmApi");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonMoveSet", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonTeamMember", "PkmTm")
                        .WithOne("PokemonMoveSet")
                        .HasForeignKey("PokemonTeamBuilder.API.Model.PokemonMoveSet", "PkmTmId")
                        .IsRequired()
                        .HasConstraintName("FK_PokemonMoveSet_Pokemon_TeamMember");

                    b.Navigation("PkmTm");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonSprite", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonPokeApi", "PkmApi")
                        .WithOne("PokemonSprite")
                        .HasForeignKey("PokemonTeamBuilder.API.Model.PokemonSprite", "PkmApiId")
                        .IsRequired()
                        .HasConstraintName("FK_PokemonID_Sprite");

                    b.Navigation("PkmApi");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonStat", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonTeamMember", "PkmTm")
                        .WithMany("PokemonStats")
                        .HasForeignKey("PkmTmId")
                        .IsRequired()
                        .HasConstraintName("FK_PokemonStat_Pokemon_TeamMember");

                    b.Navigation("PkmTm");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonTeam", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.Trainer", "Trainer")
                        .WithMany("PokemonTeams")
                        .HasForeignKey("TrainerId")
                        .IsRequired()
                        .HasConstraintName("FK_TrainerID_Team");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonTeamMember", b =>
                {
                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonAbility", "ChosenAbility")
                        .WithMany("PokemonTeamMembers")
                        .HasForeignKey("ChosenAbilityId")
                        .IsRequired()
                        .HasConstraintName("FK_Pokemon_TeamMember_PokemonAbility");

                    b.HasOne("PokemonTeamBuilder.API.Model.ItemPokeApi", "HeldItem")
                        .WithMany("PokemonTeamMembers")
                        .HasForeignKey("HeldItemId")
                        .IsRequired()
                        .HasConstraintName("FK_Pokemon_TeamMember_Item_PokeAPI");

                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonPokeApi", "PkmApi")
                        .WithMany("PokemonTeamMembers")
                        .HasForeignKey("PkmApiId")
                        .IsRequired()
                        .HasConstraintName("FK_Pokemon_TeamMember_Pokemon_PokeAPI");

                    b.HasOne("PokemonTeamBuilder.API.Model.PokemonTeam", "PokemonTeam")
                        .WithMany("PokemonTeamMembers")
                        .HasForeignKey("PokemonTeamId")
                        .IsRequired()
                        .HasConstraintName("FK_Pokemon_TeamMember_PokemonTeam");

                    b.Navigation("ChosenAbility");

                    b.Navigation("HeldItem");

                    b.Navigation("PkmApi");

                    b.Navigation("PokemonTeam");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.ItemPokeApi", b =>
                {
                    b.Navigation("PokemonTeamMembers");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonAbility", b =>
                {
                    b.Navigation("PokemonTeamMembers");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonPokeApi", b =>
                {
                    b.Navigation("PokemonBaseStats");

                    b.Navigation("PokemonSprite");

                    b.Navigation("PokemonTeamMembers");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonTeam", b =>
                {
                    b.Navigation("PokemonTeamMembers");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.PokemonTeamMember", b =>
                {
                    b.Navigation("PokemonMoveSet");

                    b.Navigation("PokemonStats");
                });

            modelBuilder.Entity("PokemonTeamBuilder.API.Model.Trainer", b =>
                {
                    b.Navigation("PokemonTeams");
                });
#pragma warning restore 612, 618
        }
    }
}

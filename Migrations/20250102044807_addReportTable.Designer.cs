﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain;

#nullable disable

namespace SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Migrations
{
    [DbContext(typeof(Stackoverflow1511Context))]
    [Migration("20250102044807_addReportTable")]
    partial class addReportTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("body");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<int>("Downvote")
                        .HasColumnType("int")
                        .HasColumnName("downvote");

                    b.Property<Guid?>("PostId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("post_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<int>("Upvote")
                        .HasColumnType("int")
                        .HasColumnName("upvote");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PK__answers");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("answers", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnswerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("PK__comments");

                    b.HasIndex("AnswerId");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "PostId" }, "IX_comments_PostId");

                    b.ToTable("comments", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.IgnoredTag", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "TagId");

                    b.HasIndex("TagId")
                        .HasDatabaseName("IX_ignoredtags_TagId");

                    b.ToTable("ignoredtags", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fileExtension");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("filePath");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint")
                        .HasColumnName("fileSizeInBytes");

                    b.Property<Guid?>("PostId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("postId");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("userId");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PostId" }, "IX_Images_postId");

                    b.HasIndex(new[] { "UserId" }, "IX_Images_userId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Detailproblem")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("")
                        .HasColumnName("detailproblem");

                    b.Property<int>("Downvote")
                        .HasColumnType("int")
                        .HasColumnName("downvote");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("title");

                    b.Property<string>("Tryandexpecting")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tryandexpecting");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<int>("Upvote")
                        .HasColumnType("int")
                        .HasColumnName("upvote");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<int>("Views")
                        .HasColumnType("int")
                        .HasColumnName("views");

                    b.HasKey("Id")
                        .HasName("PK__posts");

                    b.HasIndex("UserId");

                    b.ToTable("posts", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Posttag", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("post_id");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("tag_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.HasKey("PostId", "TagId")
                        .HasName("PK__posttag");

                    b.HasIndex("TagId");

                    b.ToTable("posttag", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("role_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("PK__roles");

                    b.HasIndex(new[] { "RoleName" }, "UQ__roles")
                        .IsUnique();

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Tagname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("tagname");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("PK__tags");

                    b.HasIndex(new[] { "Tagname" }, "UQ__tags")
                        .IsUnique();

                    b.ToTable("tags", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gravatar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("gravatar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("password");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("username");

                    b.Property<int>("Views")
                        .HasColumnType("int")
                        .HasColumnName("views");

                    b.HasKey("Id")
                        .HasName("PK__users");

                    b.HasIndex(new[] { "Username" }, "UQ__users")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("role_id");

                    b.Property<DateTime>("AssignedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("assigned_at");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PK__user_role");

                    b.HasIndex("RoleId");

                    b.ToTable("user_roles", (string)null);
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Vote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VoteType")
                        .HasColumnType("int");

                    b.Property<DateTime>("VotedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId", "PostId")
                        .IsUnique();

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.WatchedTag", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "TagId");

                    b.HasIndex("TagId")
                        .HasDatabaseName("IX_watchedtags_TagId");

                    b.ToTable("watchedtags", (string)null);
                });

            modelBuilder.Entity("TagUser", b =>
                {
                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TagsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("TagUser");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Answer", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", "Post")
                        .WithMany("Answers")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK__answers__post_id");

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("Answers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__answers__user_id");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Comment", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Answer", "Answer")
                        .WithMany("Comments")
                        .HasForeignKey("AnswerId")
                        .HasConstraintName("FK_comments_answers");

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_comments_Post");

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_comments_User");

                    b.Navigation("Answer");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.IgnoredTag", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Tag", "Tag")
                        .WithMany("IgnoredTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("IgnoredTags")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Image", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PostId");

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("Images")
                        .HasForeignKey("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__posts__user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Posttag", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", "Post")
                        .WithMany("Posttags")
                        .HasForeignKey("PostId")
                        .IsRequired()
                        .HasConstraintName("FK__posttag__post_id");

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Tag", "Tag")
                        .WithMany("Posttags")
                        .HasForeignKey("TagId")
                        .IsRequired()
                        .HasConstraintName("FK__posttag__tag_id");

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Report", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", "Post")
                        .WithMany("Reports")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("Reports")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.UserRole", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__user_role__role");

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__user_role__user");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Vote", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", "Post")
                        .WithMany("Votes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("Votes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.WatchedTag", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Tag", "Tag")
                        .WithMany("WatchedTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", "User")
                        .WithMany("WatchedTags")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TagUser", b =>
                {
                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Answer", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Post", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("Posttags");

                    b.Navigation("Reports");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.Tag", b =>
                {
                    b.Navigation("IgnoredTags");

                    b.Navigation("Posttags");

                    b.Navigation("WatchedTags");
                });

            modelBuilder.Entity("SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain.User", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Comments");

                    b.Navigation("IgnoredTags");

                    b.Navigation("Images");

                    b.Navigation("Posts");

                    b.Navigation("Reports");

                    b.Navigation("UserRoles");

                    b.Navigation("Votes");

                    b.Navigation("WatchedTags");
                });
#pragma warning restore 612, 618
        }
    }
}

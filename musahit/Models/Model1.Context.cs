﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace musahit.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tkh2022Entities : DbContext
    {
        public tkh2022Entities()
            : base("name=tkh2022Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<Companys> Companys { get; set; }
        public virtual DbSet<ContactForm> ContactForm { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<Hashtags> Hashtags { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MenuCat> MenuCat { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PageType> PageType { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PostsTags> PostsTags { get; set; }
        public virtual DbSet<PostsTMP> PostsTMP { get; set; }
        public virtual DbSet<PostsWP> PostsWP { get; set; }
        public virtual DbSet<PostType> PostType { get; set; }
        public virtual DbSet<PostType2> PostType2 { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductFeature> ProductFeature { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SiteMap> SiteMap { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Subes> Subes { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Translations> Translations { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

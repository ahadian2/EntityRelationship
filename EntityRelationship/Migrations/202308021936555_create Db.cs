namespace EntityRelationship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(nullable: false, maxLength: 100),
                        AuthorFamily = c.String(nullable: false, maxLength: 100),
                        AuthorEmail = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.T_BlogCategory",
                c => new
                    {
                        BlogCategoryId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        PostIs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogCategoryId)
                .ForeignKey("dbo.T_Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.T_Post", t => t.PostIs, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.PostIs);
            
            CreateTable(
                "dbo.T_Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        CategoryDescription = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.T_Post",
                c => new
                    {
                        PostIs = c.Int(nullable: false, identity: true),
                        PostTitel = c.String(nullable: false, maxLength: 200),
                        PostDescription = c.String(),
                        PostImage = c.String(maxLength: 100),
                        RegisterDate = c.DateTime(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostIs)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_BlogCategory", "PostIs", "dbo.T_Post");
            DropForeignKey("dbo.T_Post", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.T_BlogCategory", "CategoryId", "dbo.T_Category");
            DropIndex("dbo.T_Post", new[] { "AuthorId" });
            DropIndex("dbo.T_BlogCategory", new[] { "PostIs" });
            DropIndex("dbo.T_BlogCategory", new[] { "CategoryId" });
            DropTable("dbo.T_Post");
            DropTable("dbo.T_Category");
            DropTable("dbo.T_BlogCategory");
            DropTable("dbo.Authors");
        }
    }
}

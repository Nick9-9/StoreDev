namespace PC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PCMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        HashCode = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Laptops");
        }
    }
}

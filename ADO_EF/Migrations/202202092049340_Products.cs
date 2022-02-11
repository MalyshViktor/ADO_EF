﻿namespace ADO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Managers", "Id_main_dep", c => c.Guid());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Id_main_dep", c => c.Guid(nullable: false));
            DropTable("dbo.Products");
        }
    }
}
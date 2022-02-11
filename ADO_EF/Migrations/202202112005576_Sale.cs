namespace ADO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sale : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sales", "Id_manager", c => c.Guid(nullable: false));
            AlterColumn("dbo.Sales", "Id_product", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "Id_product", c => c.Guid());
            AlterColumn("dbo.Sales", "Id_manager", c => c.Guid());
        }
    }
}

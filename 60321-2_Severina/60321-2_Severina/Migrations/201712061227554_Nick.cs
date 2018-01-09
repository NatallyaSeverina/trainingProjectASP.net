namespace _60321_2_Severina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nick : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NickName");
        }
    }
}

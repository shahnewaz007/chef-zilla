﻿namespace Chef_Zilla.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Type");
        }
    }
}

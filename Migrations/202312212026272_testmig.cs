﻿namespace againcrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Gender");
        }
    }
}

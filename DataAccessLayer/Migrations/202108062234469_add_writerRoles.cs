﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_writerRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterRole", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterRole");
        }
    }
}

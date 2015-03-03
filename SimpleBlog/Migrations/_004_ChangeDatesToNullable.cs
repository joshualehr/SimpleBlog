using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Migrations
{
    [Migration(4)]
    public class _004_ChangeDatesToNullable : Migration
    {
        public override void Up()
        {
            Alter.Column("updated_at").OnTable("posts").AsDateTime().Nullable();
            Alter.Column("deleted_at").OnTable("posts").AsDateTime().Nullable();
        }

        public override void Down()
        {
            Alter.Column("updated_at").OnTable("posts").AsDateTime().NotNullable();
            Alter.Column("deleted_at").OnTable("posts").AsDateTime().NotNullable();
        }
    }
}
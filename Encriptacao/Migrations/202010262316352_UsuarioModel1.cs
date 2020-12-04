﻿namespace Encriptacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UsuarioModels", "ConfirmaSenha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UsuarioModels", "ConfirmaSenha");
        }
    }
}

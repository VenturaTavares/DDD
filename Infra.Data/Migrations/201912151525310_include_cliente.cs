namespace Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class include_cliente : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            AlterColumn("dbo.Cliente", "Nome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Cliente", "SobreNome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Cliente", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Email", c => c.String());
            AlterColumn("dbo.Cliente", "SobreNome", c => c.String());
            AlterColumn("dbo.Cliente", "Nome", c => c.String());
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
        }
    }
}

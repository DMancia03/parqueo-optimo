namespace Sistema_de_parqueo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        id_customer = c.Int(nullable: false, identity: true),
                        customer_name = c.String(maxLength: 50, unicode: false),
                        customer_lastname = c.String(maxLength: 50, unicode: false),
                        customer_DUI = c.String(maxLength: 50, unicode: false),
                        customer_password = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.id_customer);
            
            CreateTable(
                "dbo.parking_lot",
                c => new
                    {
                        id_parking_lot = c.Int(nullable: false, identity: true),
                        is_parking_lot_full = c.String(nullable: false, maxLength: 50, unicode: false),
                        numbers_of_slots = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_parking_lot);
            
            CreateTable(
                "dbo.parking_slot",
                c => new
                    {
                        id_parking_slot = c.Int(nullable: false, identity: true),
                        id_parking_lot = c.Int(nullable: false),
                        slot_number = c.Int(nullable: false),
                        is_parking_slot_free = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id_parking_slot)
                .ForeignKey("dbo.parking_lot", t => t.id_parking_lot)
                .Index(t => t.id_parking_lot);
            
            CreateTable(
                "dbo.parking_slot_reservation",
                c => new
                    {
                        id_reservation = c.Int(nullable: false, identity: true),
                        customer_DUI = c.String(nullable: false, maxLength: 50, unicode: false),
                        id_parking_slot = c.Int(nullable: false),
                        hora_reserva = c.DateTime(nullable: false),
                        duration_in_minutes = c.Int(nullable: false),
                        hora_finalizada = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id_reservation)
                .ForeignKey("dbo.parking_slot", t => t.id_parking_slot)
                .Index(t => t.id_parking_slot);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.parking_slot", "id_parking_lot", "dbo.parking_lot");
            DropForeignKey("dbo.parking_slot_reservation", "id_parking_slot", "dbo.parking_slot");
            DropIndex("dbo.parking_slot_reservation", new[] { "id_parking_slot" });
            DropIndex("dbo.parking_slot", new[] { "id_parking_lot" });
            DropTable("dbo.parking_slot_reservation");
            DropTable("dbo.parking_slot");
            DropTable("dbo.parking_lot");
            DropTable("dbo.customer");
        }
    }
}

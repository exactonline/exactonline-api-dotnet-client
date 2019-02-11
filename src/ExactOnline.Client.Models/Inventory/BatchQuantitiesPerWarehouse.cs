namespace ExactOnline.Client.Models.Inventory
{
    using System;

    [SupportedActionsSDK(false, false, false, false)]
    [DataServiceKey("BatchNumberId")]
    public class BatchQuantitiesPerWarehouse
    {
        public double AvailableQuantity { get; set; }
        public Guid BatchNumberId { get; set; }
        public Guid? Warehouse { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDescription { get; set; }
    }
}
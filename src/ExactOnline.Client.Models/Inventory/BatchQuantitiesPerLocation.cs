namespace ExactOnline.Client.Models.Inventory
{
    using System;

    [SupportedActionsSDK(false, false, false, false)]
    [DataServiceKey("BatchNumberId")]
    public class BatchQuantitiesPerLocation
    {
        public double AvailableQuantity { get; set; }
        public Guid BatchNumberId { get; set; }
        public Guid? StorageLocation { get; set; }
        public string StorageLocationCode { get; set; }
        public string StorageLocationDescription { get; set; }
        public Guid? Warehouse { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDescription { get; set; }
    }
}
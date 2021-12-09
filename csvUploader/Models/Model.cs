using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csvUploader.Models
{
    public class Model
    {
        public int RowNumber { get; set; }
        public string BookingNumber { get; set; }
        public DateTime ReceivingDate { get; set; }
        public string ReceivingTime { get; set; }
        public string PlaceofReceipt { get; set; }
        public string PartialReceivingFlag { get; set; }
        public string PoNumber { get; set; }
        public string ItemKey { get; set; }
        public int ReceivedQuantity { get; set; }
        public int ReceivedPackages { get; set; }
        public int ReceivedVolume { get; set; }
        public int ReceivedWeight { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Exception { get; set; }
        public string FollowUpParty { get; set; }
        public string Status { get; set; }
        public string Quantity { get; set; }
        public string Units { get; set; }
        public string ReasonForLateReceivingCreation { get; set; }
        public string PleaseSpecify { get; set; }
        public string ConsigneeBECode { get; set; }
    }

    //public class ModelClassMap : ClassMap<Model>
    //{
    //    public ModelClassMap()
    //    {
    //        Map(m => m.BookingNumber).Name("BookingNumber");
    //        Map(m => m.ReceivingDate).Name("ReceivingDate");
    //        Map(m => m.ReceivingTime).Name("ReceivingTime");
    //        Map(m => m.PlaceofReceipt).Name("PlaceofReceipt");
    //        Map(m => m.PartialReceivingFlag).Name("PartialReceivingFlag");
    //        Map(m => m.PoNumber).Name("PoNumber");
    //        Map(m => m.ItemKey).Name("ItemKey");
    //        Map(m => m.ReceivedQuantity).Name("ReceivedQuantity");
    //        Map(m => m.ReceivedPackages).Name("ReceivedPackages");
    //        Map(m => m.ReceivedVolume).Name("ReceivedVolume");
    //        Map(m => m.ReceivedWeight).Name("ReceivedWeight");
    //        Map(m => m.Length).Name("Length");
    //        Map(m => m.Width).Name("Width");
    //        Map(m => m.Height).Name("Height");
    //        Map(m => m.Exception).Name("Exception");
    //        Map(m => m.FollowUpParty).Name("FollowUpParty");
    //        Map(m => m.Status).Name("Status");
    //        Map(m => m.Quantity).Name("Quantity");
    //        Map(m => m.Units).Name("Units");
    //        Map(m => m.ReasonForLateReceivingCreation).Name("ReasonForLateReceivingCreation");
    //        Map(m => m.PleaseSpecify).Name("PleaseSpecify");
    //        Map(m => m.ConsigneeBECode).Name("ConsigneeBECode");
    //    }
    //}

}

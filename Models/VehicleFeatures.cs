using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("VehicleFeatures")]
    public class VehicleFeatures
    {
        public int VehicleId { get; set; }
        public int FeatureId { get; set; }
        public Vehicle Vihicle { get; set; }
        public Feature Feature { get; set; }
    }
}
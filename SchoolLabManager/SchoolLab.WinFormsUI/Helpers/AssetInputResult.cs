using SchoolLab.Core.Models;

namespace SchoolLab.WinFormsUI.Helpers
{
    public class AssetInputResult
    {
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string SerialNumber { get; init; } = string.Empty;
        public DateTime PurchaseDate { get; init; } = DateTime.Today;
        public Location Location { get; init; } = null;
        public Category Category { get; init; } = null;
    }
}

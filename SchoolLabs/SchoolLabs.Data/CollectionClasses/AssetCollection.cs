using SchoolLabs.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data.CollectionClasses
{
    internal class AssetCollection
    {
        public List<Asset> Assets { get; set; }
        public List<Asset> GetAssets()
        {
            return Assets;
        }
        public List<Asset> GetAssetCategory(AssetCategory category)
        {
            return Assets.Where(x => x.category == category).ToList<Asset>();
        }

        public Asset GetAssetName(string name)
        {
            return Assets.Where(x => x.Name == name).First();
        }
        public Asset GetCriticalCondition()
        {
            return Assets.Where(x => x.condition == AssetCondition.Scrapped).First();

        }
        public Asset GetRepairCondition()
        {
            return Assets.Where(x => x.condition == AssetCondition.In_Repair).First();

        }
        public Asset GetAvailableCondition()
        {
            return Assets.Where(x => x.condition == AssetCondition.Available).First();

        }











    }
}

using System.Collections.ObjectModel;
using Catel.Data;

namespace Catel.ModelNameProperty.Issue.Models
{
    public class DataModel : ModelBase
    {
        #region Items property

        /// <summary>
        /// Gets or sets the Items value.
        /// </summary>
        public ObservableCollection<ItemModel> Items
        {
            get { return GetValue<ObservableCollection<ItemModel>>(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        /// <summary>
        /// Items property data.
        /// </summary>
        public static readonly PropertyData ItemsProperty = RegisterProperty("Items", typeof (ObservableCollection<ItemModel>), () => new ObservableCollection<ItemModel>());

        #endregion
    }
}

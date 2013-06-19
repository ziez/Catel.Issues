using System.Collections.ObjectModel;
using Catel.Data;
using Catel.ModelNameProperty.Issue.Models;
using Catel.MVVM;

namespace Catel.ModelNameProperty.Issue.ViewModels
{
    public class ItemsListViewModel : ViewModelBase
    {
        public ItemsListViewModel(DataModel dataModel)
        {
            Data = dataModel;
        }

        #region Data model property

        /// <summary>
        /// Gets or sets the Data value.
        /// </summary>
        [Model]
        public DataModel Data
        {
            get { return GetValue<DataModel>(DataProperty); }
            private set { SetValue(DataProperty, value); }
        }

        /// <summary>
        /// Data property data.
        /// </summary>
        public static readonly PropertyData DataProperty = RegisterProperty("Data", typeof (DataModel));

        #endregion

        #region Items property

        /// <summary>
        /// Gets or sets the Items value.
        /// </summary>
        [ViewModelToModel("Data")]
        public ObservableCollection<ItemModel> Items
        {
            get { return GetValue<ObservableCollection<ItemModel>>(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        /// <summary>
        /// Items property data.
        /// </summary>
        public static readonly PropertyData ItemsProperty = RegisterProperty("Items", typeof (ObservableCollection<ItemModel>), null);

        #endregion

        #region Add command

        private Command _addCommand;

        /// <summary>
        /// Gets the Add command.
        /// </summary>
        public Command AddCommand
        {
            get { return _addCommand ?? (_addCommand = new Command(Add)); }
        }

        /// <summary>
        /// Method to invoke when the Add command is executed.
        /// </summary>
        private void Add()
        {
        }

        #endregion
    }
}

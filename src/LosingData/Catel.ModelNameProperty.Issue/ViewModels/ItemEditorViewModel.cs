using Catel.Data;
using Catel.ModelNameProperty.Issue.Models;
using Catel.MVVM;

namespace Catel.ModelNameProperty.Issue.ViewModels
{
    public class ItemEditorViewModel : ViewModelBase
    {
        public ItemEditorViewModel(ItemModel itemModel)
        {
            Item = itemModel;
        }

        #region Item model property

        /// <summary>
        /// Gets or sets the Item value.
        /// </summary>
        [Model]
        public ItemModel Item
        {
            get { return GetValue<ItemModel>(ItemProperty); }
            private set { SetValue(ItemProperty, value); }
        }

        /// <summary>
        /// Item property data.
        /// </summary>
        public static readonly PropertyData ItemProperty = RegisterProperty("Item", typeof (ItemModel));

        #endregion

        #region Apply command

        private Command _applyCommand;

        /// <summary>
        /// Gets the Apply command.
        /// </summary>
        public Command ApplyCommand
        {
            get { return _applyCommand ?? (_applyCommand = new Command(Apply)); }
        }

        /// <summary>
        /// Method to invoke when the Apply command is executed.
        /// </summary>
        private void Apply()
        {
        }

        #endregion
    }
}

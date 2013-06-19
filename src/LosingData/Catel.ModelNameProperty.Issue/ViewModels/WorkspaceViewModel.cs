using Catel.Data;
using Catel.ModelNameProperty.Issue.Models;
using Catel.MVVM;

namespace Catel.ModelNameProperty.Issue.ViewModels
{
    [InterestedIn(typeof(ItemEditorViewModel))]
    [InterestedIn(typeof(ItemsListViewModel))]
    public class WorkspaceViewModel : ViewModelBase
    {
        private readonly DataModel _dataModel;

        public WorkspaceViewModel()
        {
            _dataModel = new DataModel();

            ActiveModel = _dataModel;
        }

        #region ActiveModel model property

        /// <summary>
        /// Gets or sets the ActiveModel value.
        /// </summary>
        [Model]
        public ModelBase ActiveModel
        {
            get { return GetValue<ModelBase>(ActiveModelProperty); }
            private set { SetValue(ActiveModelProperty, value); }
        }

        /// <summary>
        /// ActiveModel property data.
        /// </summary>
        public static readonly PropertyData ActiveModelProperty = RegisterProperty("ActiveModel", typeof (ModelBase));

        #endregion

        protected override void OnViewModelCommandExecuted(IViewModel viewModel, ICatelCommand command, object commandParameter)
        {
            base.OnViewModelCommandExecuted(viewModel, command, commandParameter);

            var itemEditor = viewModel as ItemEditorViewModel;
            if (itemEditor != null)
            {
                if (itemEditor.ApplyCommand == command)
                {
                    _dataModel.Items.Add(itemEditor.Item);

                    ActiveModel = _dataModel;
                }
            }

            var itemsList = viewModel as ItemsListViewModel;
            if (itemsList != null)
            {
                if (itemsList.AddCommand == command)
                {
                    ActiveModel = new ItemModel();
                }
            }
        }
    }
}

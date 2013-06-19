using Catel.Data;

namespace Catel.ModelNameProperty.Issue.Models
{
    public class ItemModel : ModelBase
    {
        #region Name property

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name
        {
            get { return GetValue<string>(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        /// <summary>
        /// Name property data.
        /// </summary>
        public static readonly PropertyData NameProperty = RegisterProperty("Name", typeof (string));

        #endregion

        #region Number property

        /// <summary>
        /// Gets or sets the Number value.
        /// </summary>
        public int Number
        {
            get { return GetValue<int>(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        /// <summary>
        /// Number property data.
        /// </summary>
        public static readonly PropertyData NumberProperty = RegisterProperty("Number", typeof (int));

        #endregion
    }
}

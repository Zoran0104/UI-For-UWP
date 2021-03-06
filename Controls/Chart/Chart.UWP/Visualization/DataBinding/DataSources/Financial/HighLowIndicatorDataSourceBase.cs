﻿namespace Telerik.UI.Xaml.Controls.Chart
{
    internal abstract class HighLowIndicatorDataSourceBase : CategoricalSeriesDataSource
    {
        private DataPointBinding highBinding;
        private DataPointBinding lowBinding;

        public DataPointBinding HighBinding
        {
            get
            {
                return this.highBinding;
            }
            set
            {
                if (this.highBinding == value)
                {
                    return;
                }

                this.highBinding = value;

                if (this.ItemsSource != null)
                {
                    this.Rebind(false, null);
                }
            }
        }

        public DataPointBinding LowBinding
        {
            get
            {
                return this.lowBinding;
            }
            set
            {
                if (this.lowBinding == value)
                {
                    return;
                }

                this.lowBinding = value;

                if (this.ItemsSource != null)
                {
                    this.Rebind(false, null);
                }
            }
        }
    }
}

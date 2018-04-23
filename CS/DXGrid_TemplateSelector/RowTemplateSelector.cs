using DevExpress.Xpf.Grid;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DXGrid_TemplateSelector
{
    public class RowTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EvenRowTemplate { get; set; }
        public DataTemplate OddRowTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            RowData row = item as RowData;
            if (row != null)
                return row.EvenRow ? EvenRowTemplate : OddRowTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}

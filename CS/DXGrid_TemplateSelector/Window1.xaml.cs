using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;

namespace DXGrid_TemplateSelector {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = IssueList.GetData();
        }
    }

    public class RowTemplateSelector : DataTemplateSelector {
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            RowData row = item as RowData;
            FrameworkElement presenter = container as FrameworkElement;
            if (row != null && presenter != null) {
                return row.EvenRow ? (DataTemplate)presenter.FindResource("evenRowTemplate") :
                    (DataTemplate)presenter.FindResource("oddRowTemplate");
            }
            return base.SelectTemplate(item, container);
        }
    }

    public class IssueList {
        static public List<IssueDataObject> GetData() {
            List<IssueDataObject> data = new List<IssueDataObject>();
            data.Add(new IssueDataObject() { IssueName = "Transaction History"});
            data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency"});
            data.Add(new IssueDataObject() { IssueName = "Data Import"});
            data.Add(new IssueDataObject() { IssueName = "Data Archiving"});
            return data;
        }
    }

    public class IssueDataObject {
        public string IssueName { get; set; }
    }
}

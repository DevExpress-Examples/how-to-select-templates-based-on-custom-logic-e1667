using System.Collections.ObjectModel;
using System.Windows;

namespace DXGrid_TemplateSelector {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = IssueDataObject.GetData();
        }
    }
    public class IssueDataObject {
        public string IssueName { get; set; }
        public static ObservableCollection<IssueDataObject> GetData() {
            ObservableCollection<IssueDataObject> data = new ObservableCollection<IssueDataObject>();
            data.Add(new IssueDataObject() { IssueName = "Transaction History" });
            data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency" });
            data.Add(new IssueDataObject() { IssueName = "Data Import" });
            data.Add(new IssueDataObject() { IssueName = "Data Archiving" });
            return data;
        }
    }
}

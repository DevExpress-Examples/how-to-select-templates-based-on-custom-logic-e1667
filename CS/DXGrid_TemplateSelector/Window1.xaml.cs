using System;
using System.Collections.Generic;
using System.Linq;
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
        public static List<IssueDataObject> GetData() {
            List<IssueDataObject> data = new List<IssueDataObject>();
            data.Add(new IssueDataObject() { IssueName = "Transaction History" });
            data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency" });
            data.Add(new IssueDataObject() { IssueName = "Data Import" });
            data.Add(new IssueDataObject() { IssueName = "Data Archiving" });
            return data;
        }
    }
}

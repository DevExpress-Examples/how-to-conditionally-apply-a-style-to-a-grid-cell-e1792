using System;
using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Xpf.Editors;
using DevExpress.AgDataGrid;

namespace SilverlightApplication4
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            dataGrid.DataSource = Order.GetOrders();
            dataGrid.ApplyTemplate();
            dataGrid.Columns["Price"].PrepareCellDisplayElement += Page_PrepareCellDisplayElement;
        }

        void Page_PrepareCellDisplayElement(object sender, PrepareCellDisplayElementEventArgs e){

            Order order = (Order)e.DisplayElement.DataContext;
            TextEdit editor = (TextEdit)e.DisplayElement;
            if (order.Price > 200)
                editor.Foreground = new SolidColorBrush(Colors.Red);    
        }
    }
}
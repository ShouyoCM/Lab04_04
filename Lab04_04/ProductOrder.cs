using Lab04_04.ProductOrderDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_04
{
    public partial class ProductOrder : Form
    {
        public ProductOrder()
        {
            InitializeComponent();
        }

        Model2 context = new Model2();

        public void BindData (List<Invoice> invoices)
        {
            dgvTong.Rows.Clear();
            foreach (var item in invoices)
            {
                int index = dgvTong.Rows.Add();
                dgvTong.Rows[index].Cells[0].Value = dgvTong.RowCount;
                dgvTong.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgvTong.Rows[index].Cells[2].Value = item.OrderDate;
                dgvTong.Rows[index].Cells[3].Value = item.DeliveryDate;
                decimal sum = context.Order.Where(detail => detail.InvoiceNo ==item.InvoiceNo).Sum(detail => detail.Price * detail.Quantity);
                dgvTong.Rows[index].Cells[4].Value = sum;

                txbSum.Text = Total().ToString();
            }
        }

        private void ProductOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Model2 context = new Model2();

                List<Invoice> listInvoice = context.Invoice.ToList();
                
                BindData(listInvoice);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtpBegin.Value.Date;
            DateTime to = dtpEnd.Value.Date;

            if (from > to) 
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông Báo");
            }
            else
            {
                var order = context.Invoice.Where(x => x.DeliveryDate >= from && x.DeliveryDate <= to).ToList();

                BindData(order);
            }
        }

        public void settime()
        {
            DateTime db = dtpBegin.Value;
            DateTime kt = new DateTime(db.Year, db.Month, DateTime.DaysInMonth(db.Year, db.Month));
            dtpEnd.Value = kt;
        }
        
        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAll.Checked)
            {
                settime();
            }
            else
            {
                dtpEnd.Value = DateTime.Now;
            }
        }

        private decimal Total()
        {
            decimal s = 0;
            foreach(DataGridViewRow row in dgvTong.Rows)
            {
                if (row.Visible == true)
                {
                    s += Convert.ToDecimal(row.Cells["clmThanhTien"].Value);
                }
            }return s;
        }
    }
}

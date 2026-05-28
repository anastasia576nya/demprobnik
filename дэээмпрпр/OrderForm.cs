using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using дэээмпрпр.Models;

namespace дэээмпрпр
{
    public partial class OrderForm : Form
    {
        DefaultDbDemContext context;
        public OrderForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DefaultDbDemContext context = new();

            context.Orders.Include(x => x.StatusId).Include(x => x.AddresId).Load();
            context.Statuses.Load();
            context.Addres.Load();

            context.Database.EnsureCreated();

            orderbindingSource1.DataSource = context.Orders.OrderBy(x=>x.Idorder).ToList();
            adsresbindingSource1.DataSource = context.Addres.Local.ToBindingList();
            statusbindingSource1.DataSource = context.Statuses.Local.ToBindingList();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}

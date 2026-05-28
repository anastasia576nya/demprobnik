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
    public partial class AdminForm : Form
    {
        DefaultDbDemContext context;
        public AdminForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new DefaultDbDemContext();

            context.Products.Include(x => x.Manufacturer).Include(x => x.Unit).Include(x => x.Suppliers).Include(x => x.Category).Load();
            context.Manufacturers.Load();
            context.Units.Load();
            context.Suppliers.Load();
            context.Categoria.Load();

            context.Database.EnsureCreated();

            prodbindingSource1.DataSource = context.Products.OrderBy(x => x.Idproduct).ToList();
            manbindingSource1.DataSource = context.Manufacturers.Local.ToBindingList();
            supbindingSource1.DataSource = context.Suppliers.Local.ToBindingList();
            catbindingSource1.DataSource = context.Categoria.Local.ToBindingList();
            unitbindingSource1.DataSource = context.Units.Local.ToBindingList();

        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newProduct = new Product();
            newProduct.Article = "P-000";
            newProduct.Description = "-";
            newProduct.Discount = 0;
            newProduct.Photo = "vgh.jpg";
            newProduct.Price = 0;
            newProduct.Name = "введите имя";
            

            var form = new EditFormProduct();

            form.manbindingSource1.DataSource = manbindingSource1.DataSource;
            form.supbindingSource1.DataSource = supbindingSource1.DataSource;
            form.catbindingSource1.DataSource = catbindingSource1.DataSource;
            form.unitbindingSource1.DataSource = unitbindingSource1.DataSource;

            form.prodbindingSource1.DataSource = newProduct;

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.prodbindingSource1.EndEdit();
                context.Products.Add(newProduct);

                if (context.SaveChanges() > 0)
                    prodbindingSource1.DataSource = context.Products.ToList();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prodbindingSource1.RemoveCurrent();
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prodbindingSource1.Current == null) return;
            var form = new EditFormProduct();
            form.catbindingSource1.DataSource = catbindingSource1.DataSource;
            form.manbindingSource1.DataSource = manbindingSource1.DataSource;
            form.unitbindingSource1.DataSource = unitbindingSource1.DataSource;
            form.supbindingSource1.DataSource = supbindingSource1.DataSource;
            form.prodbindingSource1.DataSource = prodbindingSource1.Current;
            form.button1.Click += new EventHandler(button1_Click);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new OrderForm().Show();
            this.Hide();
        }
    }
}

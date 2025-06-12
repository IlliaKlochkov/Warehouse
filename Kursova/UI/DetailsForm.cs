using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DatabaseRepo;
using Warehouse.Models;

namespace Warehouse.UI
{
    public partial class DetailsForm : Form
    {
        Product product;
        public DetailsForm(DataGridViewRow detailedRow, Database _warehouseDatabase)
        {
            InitializeComponent();

            int ProductId = int.Parse(detailedRow.Cells["Id"].Value.ToString());

            product = _warehouseDatabase.GetProductById(ProductId);

            textBox_Id.Text = product.Id.ToString();
            textBox_Name.Text = product.Name;
            textBox_MeasureUnit.Text = product.MeasureUnit;
            textBox_PricePerUnit.Text = product.PricePerUnit.ToString();
            textBox_Quantity.Text = product.Quantity.ToString();
            textBox_FirstAddedDate.Text = product.FirstAddedDate.ToString();
            textBox_LastDeliveryDate.Text = product.LastDeliveryDate.ToString();
            textBox_TotalPrice.Text = product.TotalPrice.ToString();
            textBox_OperationQuantity.Text = product.Operations.Count.ToString();

            WarehouseUtils.GenerateOperationComboBox(product, comboBox_Operations);
        }

        private void comboBox_SelectOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Operations.SelectedIndex == -1)
                return;

            textBox_Operation.Clear();

            var selectedDate = (DateTime)comboBox_Operations.SelectedValue;

            if (product.Operations.TryGetValue(selectedDate, out var operationsList))
            {
                foreach (var operation in operationsList)
                {
                    textBox_Operation.AppendText(operation.DisplayName + Environment.NewLine);
                }
            }
            else
            {
                textBox_Operation.Text = "Операції на цю дату не знайдено.";
            }
        }
    }
}

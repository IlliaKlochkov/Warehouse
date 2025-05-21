using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kursova.DatabaseRepo;
using Kursova.Models;

namespace Kursova.UI;

public partial class AddProduct : Form
{
    private Database _database;
    public event EventHandler ProductAdded;

    public AddProduct(Database database)
    {
        InitializeComponent();
        _database = database;
    }

    private void buttonAddProduct_Click(object sender, EventArgs e)
    {
        string name = textBoxProductName.Text;
        string measureUnit = textBoxProductMeasureUnit.Text;
        int quantity = int.Parse(textBoxProductQuantity.Text);
        int pricePerUnit = int.Parse(textBoxPricePerUnit.Text);
        DateTime lastDeliveryDate = dateTimePickerProductTime.Value;

        Product product = new Product(name, measureUnit, pricePerUnit, quantity, lastDeliveryDate);

        _database.AddProduct(product);

        ProductAdded?.Invoke(this, EventArgs.Empty); 

        this.Close(); 
    }

}

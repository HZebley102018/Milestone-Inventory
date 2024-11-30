using System.Xml.Serialization;

namespace Milestone_Inventory
{
    public partial class FrmInventoryList : Form
    {
        //Declare variables that will be used across multiple methods and event handlers
        private int quantity2 = 0;
        private int quantity3 = 0;
        private int quantity4 = 0;
        private int quantity5 = 0;
        private int quantity6 = 0;
        public FrmInventoryList()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Initialize variables upon load and convert to String 
        private void Form1_Load(object sender, EventArgs e)
        {
            lblQuantity2.Text = quantity2.ToString();
            lblQuantity3.Text = quantity3.ToString();
            lblQuantity4.Text = quantity4.ToString();
            lblQuantity5.Text = quantity5.ToString();
            lblQuantity6.Text = quantity6.ToString();
        }
        //Create Event Handlers for increase and decrease buttons
        //Display new variable amounts
        //Create catch for negative inventory amounts (error)
        private void Quantity2IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity2++;
            lblQuantity2.Text = quantity2.ToString();
        }

        private void Quantity2DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity2 > 0)
            {
                quantity2--;
                lblQuantity2.Text = quantity2.ToString();
            }
        }

        private void Quantity3IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity3++;
            lblQuantity3.Text = quantity3.ToString();
        }

        private void Quantity3DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity3 > 0)
            {
                quantity3--;
                lblQuantity3.Text = quantity3.ToString();
            }
        }

        private void Quantity4IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity4++;
            lblQuantity4.Text = quantity4.ToString();
        }

        private void Quantity4DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity4 > 0)
            {
                quantity4--;
                lblQuantity4.Text = quantity4.ToString();
            }
        }

        private void Quantity5IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity5++;
            lblQuantity5.Text = quantity5.ToString();
        }

        private void Quantity5DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity5 > 0)
            {
                quantity5--;
                lblQuantity5.Text = quantity5.ToString();
            }
        }

        private void Quantity6IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity6++;
            lblQuantity6.Text = quantity6.ToString();
        }

        private void Quantity6DecreaseEventHandler(object sender, EventArgs e)
        {
            if(quantity6 > 0)
            {
                quantity6--;
                lblQuantity6.Text = quantity6.ToString();
            }
        }
    }
}

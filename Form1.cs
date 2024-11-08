/*
    SODV2101 Assignment 2
    Creating a Bar Chart
    Eilidh Macsymic, 459379
    November 1st 2024
 */

namespace eilidh_assign2
{
    public partial class Form1 : Form
    {
        private bool isClear = true;

        public Form1()
        {
            InitializeComponent();
            this.Width = 460;
            this.Height = 340;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            /*
                bottom: 210
                top: 10
                right: 140
                left: 320
             */

            Graphics g = e.Graphics;
            Font font = new Font("Ariel", 8);

            // Creating chart border
            Pen chartBorder = new Pen(Color.Black, 1);
            g.FillRectangle(Brushes.White, 130, 10, 200, 200);
            g.DrawRectangle(chartBorder, 130, 10, 200, 200);
            g.DrawLine(chartBorder, 130, 210, 115, 210);
            g.DrawString("0", font, Brushes.Black, new PointF(100, 205));
            g.DrawLine(chartBorder, 130, 110, 115, 110);
            g.DrawString("100", font, Brushes.Black, new PointF(90, 105));
            g.DrawLine(chartBorder, 130, 10, 115, 10);
            g.DrawString("200", font, Brushes.Black, new PointF(90, 5));

            // Creating line pens
            Pen line1 = new Pen(Color.Red, 20);
            Pen line2 = new Pen(Color.Orange, 20);
            Pen line3 = new Pen(Color.Green, 20);
            Pen line4 = new Pen(Color.Blue, 20);
            Pen line5 = new Pen(Color.Purple, 20);

            if (isClear)
            {
                g.DrawLine(line1, 150, 210, 150, 210);
                g.DrawLine(line2, 190, 210, 190, 210);
                g.DrawLine(line3, 230, 210, 230, 210);
                g.DrawLine(line4, 270, 210, 270, 210);
                g.DrawLine(line5, 310, 210, 310, 210);
            }
            else
            {
                int[] values = new int[5];
                TextBox[] textBoxes = { txtNumInput1, txtNumInput2, txtNumInput3, txtNumInput4, txtNumInput5 };

                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (int.TryParse(textBoxes[i].Text, out int result))
                    {
                        // Limit the max value to fit within chart area (e.g., 200 px height)
                        values[i] = Math.Max(10, Math.Min(200, result));
                    }
                    else
                    {
                        values[i] = 100; // Default height if input is invalid
                    }
                }

                // Draw lines with calculated heights
                g.DrawLine(line1, 150, 210, 150, 210 - values[0]);
                g.DrawLine(line2, 190, 210, 190, 210 - values[1]);
                g.DrawLine(line3, 230, 210, 230, 210 - values[2]);
                g.DrawLine(line4, 270, 210, 270, 210 - values[3]);
                g.DrawLine(line5, 310, 210, 310, 210 - values[4]);
            }

            base.OnPaint(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isClear = false;
            TextBox[] textBoxes = { txtNumInput1, txtNumInput2, txtNumInput3, txtNumInput4, txtNumInput5 };
            bool isEmpty = false;

            // Validate each TextBox for null or empty values
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    isEmpty = true;
                    break; // Exit the loop as soon as an empty field is found
                }
            }

            // Show message box if any TextBox is empty
            if (isEmpty)
            {
                MessageBox.Show("Please enter a value in all fields!");
            }
            else
            {
                this.Invalidate(); // Update the chart if all inputs are valid
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumInput1.Text = txtNumInput2.Text = txtNumInput3.Text = txtNumInput4.Text = txtNumInput5.Text = string.Empty;
            isClear = true;
            this.Invalidate();
        }
    }
}
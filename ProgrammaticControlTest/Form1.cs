using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammaticControlTest
{
    public partial class Form1 : Form
    {
        const int FORM_HEIGHT = 450;
        const int FORM_WIDTH = 450;


        private TextBox txtName;
        private CheckBox chkCool;
        private Label lblResult;
        private Button btnCalculate;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set up the form proper
            this.Text = "Programmatic Control Test";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(FORM_WIDTH,FORM_HEIGHT);

            //Create the controls
            txtName = new TextBox();
            chkCool = new CheckBox();
            lblResult = new Label();
            btnCalculate = new Button();


            //Set up each control
            txtName.Dock = DockStyle.Top;
            txtName.Text = "Fill me in!";

            chkCool.Dock = DockStyle.Top;
            chkCool.CheckState = CheckState.Unchecked;

            lblResult.Dock = DockStyle.Right;
            lblResult.Text = "Results...";

            btnCalculate.Dock = DockStyle.Bottom;
            btnCalculate.Text = "Calculate";
            btnCalculate.Click += new System.EventHandler(Clicky);

            //Add them to the form
            Controls.Add(txtName);
            Controls.Add(chkCool);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
        }
        private void Clicky(object sender, EventArgs e)
        {
            lblResult.Text = (Convert.ToInt32(txtName.Text) * (int)chkCool.CheckState).ToString();
        }
        
    }
}

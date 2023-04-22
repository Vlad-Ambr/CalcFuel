using System.Windows.Forms;

namespace CalcFuel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.Width = 300;
            this.Height = 275;



            //
            //
            //
            LabelDistance = new Label();
            LabelDistance.Text = "Distance(km):";
            LabelDistance.Location = new System.Drawing.Point(5, 23);
            this.Controls.Add(LabelDistance);



            //
            //
            //
            distance = new TextBox();
            distance.Width = 140;
            distance.Location = new System.Drawing.Point(120, 20);
            this.Controls.Add(distance);



            //
            //
            //
            LabelAverageConsumption = new Label();
            LabelAverageConsumption.Font = new System.Drawing.Font(LabelAverageConsumption.Font.FontFamily, 6);
            LabelAverageConsumption.Text = "Average Consumption(1l/100km):";
            LabelAverageConsumption.Location = new System.Drawing.Point(5, 53);
            this.Controls.Add(LabelAverageConsumption);



            //
            //
            //
            averageConsumption = new TextBox();
            averageConsumption.Width = 140;
            averageConsumption.Location = new System.Drawing.Point(120, 50);
            this.Controls.Add(averageConsumption);



            //
            //
            //
            LabelCostFuel = new Label();
            LabelCostFuel.Text = "Cost Fuel($/1l):";
            LabelCostFuel.Location = new System.Drawing.Point(5, 83);
            this.Controls.Add(LabelCostFuel);



            //
            //
            //
            costFuel = new TextBox();
            costFuel.Width = 140;
            costFuel.Location = new System.Drawing.Point(120, 80);
            this.Controls.Add(costFuel);



            //
            //
            //
            LabelCostTravel = new Label();
            LabelCostTravel.Text = "Cost Travel($):";
            LabelCostTravel.Location = new System.Drawing.Point(5, 153);
            this.Controls.Add(LabelCostTravel);



            //
            //
            //
            CostTravel = new TextBox();
            CostTravel.Width = 140;
            CostTravel.Location = new System.Drawing.Point(120, 150);
            this.Controls.Add(CostTravel);



            //
            //
            //
            LabelConsumptionFuel = new Label();
            LabelConsumptionFuel.Font = new System.Drawing.Font(LabelConsumptionFuel.Font.FontFamily, 6);
            LabelConsumptionFuel.Text = "Consumption Fuel(l):";
            LabelConsumptionFuel.Location = new System.Drawing.Point(5, 183);
            this.Controls.Add(LabelConsumptionFuel);



            //
            //
            //
            ConsumptionFuel = new TextBox();
            ConsumptionFuel.Width = 140;
            ConsumptionFuel.Location = new System.Drawing.Point(120, 180);
            this.Controls.Add(ConsumptionFuel);



            Calc = new Button();
            Calc.Width = 200;
            Calc.Height = 25;
            Calc.Text = "Calculate";
            Calc.Location = new System.Drawing.Point((this.Width / 2) - (Calc.Width / 2) - 10, 115);
            Calc.Click += (s, e) =>
            {
                CostTravel.Text = ((float.Parse(distance.Text) / 100) * float.Parse(averageConsumption.Text) * float.Parse(costFuel.Text)).ToString();
                ConsumptionFuel.Text = ((float.Parse(distance.Text) / 100) * float.Parse(averageConsumption.Text)).ToString();
            };
            this.Controls.Add(Calc);

        }
        TextBox distance;
        TextBox averageConsumption;
        TextBox costFuel;
        Label LabelDistance;
        Label LabelAverageConsumption;
        Label LabelCostFuel;

        Button Calc;

        Label LabelCostTravel;
        TextBox CostTravel;
        Label LabelConsumptionFuel;
        TextBox ConsumptionFuel;

        #endregion
    }
}


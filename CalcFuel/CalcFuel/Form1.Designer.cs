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
            this.Height = 350;



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
            LabelConsumptionFuel100km = new Label();
            LabelConsumptionFuel100km.Text = "Cost Fuel($/1l):";
            LabelConsumptionFuel100km.Location = new System.Drawing.Point(5, 83);
            this.Controls.Add(LabelConsumptionFuel100km);



            //
            //
            //
            consumptionFuel100km = new TextBox();
            consumptionFuel100km.Width = 140;
            consumptionFuel100km.Location = new System.Drawing.Point(120, 80);
            this.Controls.Add(consumptionFuel100km);



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



        }
        TextBox distance;
        TextBox averageConsumption;
        TextBox consumptionFuel100km;
        Label LabelDistance;
        Label LabelAverageConsumption;
        Label LabelConsumptionFuel100km;

        
        Label LabelCostTravel;
        TextBox CostTravel;
        Label LabelConsumptionFuel;
        TextBox ConsumptionFuel;

        #endregion
    }
}


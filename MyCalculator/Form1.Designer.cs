using System;

namespace MyCalculator
{
    partial class PinkCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinkCalculator));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.ButtonNumberSeven = new System.Windows.Forms.Button();
            this.ButtonNumberEight = new System.Windows.Forms.Button();
            this.ButtonNumberNine = new System.Windows.Forms.Button();
            this.ButtonSlash = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonNumberFour = new System.Windows.Forms.Button();
            this.ButtonNumberFive = new System.Windows.Forms.Button();
            this.ButtonNumberSix = new System.Windows.Forms.Button();
            this.ButtonMutiplicate = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonNumberOne = new System.Windows.Forms.Button();
            this.ButtonNumberTwo = new System.Windows.Forms.Button();
            this.ButtonNumberThree = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.buttonNumberZero = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Name = "textBox1";
            // 
            // labelCurrentOperation
            // 
            resources.ApplyResources(this.labelCurrentOperation, "labelCurrentOperation");
            this.labelCurrentOperation.BackColor = System.Drawing.Color.MistyRose;
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonNumberSeven
            // 
            resources.ApplyResources(this.ButtonNumberSeven, "ButtonNumberSeven");
            this.ButtonNumberSeven.Name = "ButtonNumberSeven";
            this.ButtonNumberSeven.UseVisualStyleBackColor = true;
            this.ButtonNumberSeven.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonNumberEight
            // 
            resources.ApplyResources(this.ButtonNumberEight, "ButtonNumberEight");
            this.ButtonNumberEight.Name = "ButtonNumberEight";
            this.ButtonNumberEight.UseVisualStyleBackColor = true;
            this.ButtonNumberEight.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonNumberNine
            // 
            resources.ApplyResources(this.ButtonNumberNine, "ButtonNumberNine");
            this.ButtonNumberNine.Name = "ButtonNumberNine";
            this.ButtonNumberNine.UseVisualStyleBackColor = true;
            this.ButtonNumberNine.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonSlash
            // 
            resources.ApplyResources(this.ButtonSlash, "ButtonSlash");
            this.ButtonSlash.Name = "ButtonSlash";
            this.ButtonSlash.UseVisualStyleBackColor = true;
            this.ButtonSlash.Click += new System.EventHandler(this.operator_click);
            // 
            // ButtonCE
            // 
            resources.ApplyResources(this.ButtonCE, "ButtonCE");
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.clear_click);
            // 
            // ButtonNumberFour
            // 
            resources.ApplyResources(this.ButtonNumberFour, "ButtonNumberFour");
            this.ButtonNumberFour.Name = "ButtonNumberFour";
            this.ButtonNumberFour.UseVisualStyleBackColor = true;
            this.ButtonNumberFour.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonNumberFive
            // 
            resources.ApplyResources(this.ButtonNumberFive, "ButtonNumberFive");
            this.ButtonNumberFive.Name = "ButtonNumberFive";
            this.ButtonNumberFive.UseVisualStyleBackColor = true;
            this.ButtonNumberFive.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonNumberSix
            // 
            resources.ApplyResources(this.ButtonNumberSix, "ButtonNumberSix");
            this.ButtonNumberSix.Name = "ButtonNumberSix";
            this.ButtonNumberSix.UseVisualStyleBackColor = true;
            this.ButtonNumberSix.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonMutiplicate
            // 
            resources.ApplyResources(this.ButtonMutiplicate, "ButtonMutiplicate");
            this.ButtonMutiplicate.Name = "ButtonMutiplicate";
            this.ButtonMutiplicate.UseVisualStyleBackColor = true;
            this.ButtonMutiplicate.Click += new System.EventHandler(this.operator_click);
            // 
            // ButtonC
            // 
            resources.ApplyResources(this.ButtonC, "ButtonC");
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.clear_click_simple);
            // 
            // ButtonNumberOne
            // 
            resources.ApplyResources(this.ButtonNumberOne, "ButtonNumberOne");
            this.ButtonNumberOne.Name = "ButtonNumberOne";
            this.ButtonNumberOne.UseVisualStyleBackColor = true;
            this.ButtonNumberOne.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonNumberTwo
            // 
            resources.ApplyResources(this.ButtonNumberTwo, "ButtonNumberTwo");
            this.ButtonNumberTwo.Name = "ButtonNumberTwo";
            this.ButtonNumberTwo.UseVisualStyleBackColor = true;
            this.ButtonNumberTwo.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonNumberThree
            // 
            resources.ApplyResources(this.ButtonNumberThree, "ButtonNumberThree");
            this.ButtonNumberThree.Name = "ButtonNumberThree";
            this.ButtonNumberThree.UseVisualStyleBackColor = true;
            this.ButtonNumberThree.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonDown
            // 
            resources.ApplyResources(this.ButtonDown, "ButtonDown");
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.operator_click);
            // 
            // ButtonEqual
            // 
            resources.ApplyResources(this.ButtonEqual, "ButtonEqual");
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.UseVisualStyleBackColor = true;
            this.ButtonEqual.Click += new System.EventHandler(this.equal_click);
            // 
            // buttonNumberZero
            // 
            resources.ApplyResources(this.buttonNumberZero, "buttonNumberZero");
            this.buttonNumberZero.Name = "buttonNumberZero";
            this.buttonNumberZero.UseVisualStyleBackColor = true;
            this.buttonNumberZero.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonPoint
            // 
            resources.ApplyResources(this.ButtonPoint, "ButtonPoint");
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonPlus
            // 
            resources.ApplyResources(this.ButtonPlus, "ButtonPlus");
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // PinkCalculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonPoint);
            this.Controls.Add(this.buttonNumberZero);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonNumberThree);
            this.Controls.Add(this.ButtonNumberTwo);
            this.Controls.Add(this.ButtonNumberOne);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonMutiplicate);
            this.Controls.Add(this.ButtonNumberSix);
            this.Controls.Add(this.ButtonNumberFive);
            this.Controls.Add(this.ButtonNumberFour);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonSlash);
            this.Controls.Add(this.ButtonNumberNine);
            this.Controls.Add(this.ButtonNumberEight);
            this.Controls.Add(this.ButtonNumberSeven);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PinkCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button ButtonNumberSeven;
        private System.Windows.Forms.Button ButtonNumberEight;
        private System.Windows.Forms.Button ButtonNumberNine;
        private System.Windows.Forms.Button ButtonSlash;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonNumberFour;
        private System.Windows.Forms.Button ButtonNumberFive;
        private System.Windows.Forms.Button ButtonNumberSix;
        private System.Windows.Forms.Button ButtonMutiplicate;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonNumberOne;
        private System.Windows.Forms.Button ButtonNumberTwo;
        private System.Windows.Forms.Button ButtonNumberThree;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button buttonNumberZero;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button ButtonPlus;
    }
}


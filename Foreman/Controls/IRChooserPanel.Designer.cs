﻿
namespace Foreman
{
    partial class IRChooserPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IRFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemIconPanel = new System.Windows.Forms.Panel();
            this.IgnoreAssemblerCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.AsProductCheckBox = new System.Windows.Forms.CheckBox();
            this.AsIngredientCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.IRPanelScrollBar = new System.Windows.Forms.VScrollBar();
            this.OtherNodeOptionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddSupplyButton = new System.Windows.Forms.Button();
            this.AddPassthroughButton = new System.Windows.Forms.Button();
            this.AddConsumerButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OtherNodeOptionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.GroupFlowPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IRFlowPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IRPanelScrollBar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OtherNodeOptionsTableLayoutPanel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GroupFlowPanel
            // 
            this.GroupFlowPanel.AutoSize = true;
            this.GroupFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupFlowPanel.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.SetColumnSpan(this.GroupFlowPanel, 2);
            this.GroupFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupFlowPanel.Location = new System.Drawing.Point(3, 99);
            this.GroupFlowPanel.Name = "GroupFlowPanel";
            this.GroupFlowPanel.Padding = new System.Windows.Forms.Padding(2);
            this.GroupFlowPanel.Size = new System.Drawing.Size(388, 4);
            this.GroupFlowPanel.TabIndex = 0;
            // 
            // IRFlowPanel
            // 
            this.IRFlowPanel.BackColor = System.Drawing.Color.DimGray;
            this.IRFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IRFlowPanel.Location = new System.Drawing.Point(3, 109);
            this.IRFlowPanel.Name = "IRFlowPanel";
            this.IRFlowPanel.Padding = new System.Windows.Forms.Padding(2);
            this.IRFlowPanel.Size = new System.Drawing.Size(364, 278);
            this.IRFlowPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.ItemIconPanel);
            this.panel1.Controls.Add(this.IgnoreAssemblerCheckBox);
            this.panel1.Controls.Add(this.FilterLabel);
            this.panel1.Controls.Add(this.AsProductCheckBox);
            this.panel1.Controls.Add(this.AsIngredientCheckBox);
            this.panel1.Controls.Add(this.ShowHiddenCheckBox);
            this.panel1.Controls.Add(this.FilterTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 90);
            this.panel1.TabIndex = 2;
            // 
            // ItemIconPanel
            // 
            this.ItemIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemIconPanel.Location = new System.Drawing.Point(7, 34);
            this.ItemIconPanel.Name = "ItemIconPanel";
            this.ItemIconPanel.Size = new System.Drawing.Size(48, 48);
            this.ItemIconPanel.TabIndex = 6;
            this.ItemIconPanel.Visible = false;
            // 
            // IgnoreAssemblerCheckBox
            // 
            this.IgnoreAssemblerCheckBox.AutoSize = true;
            this.IgnoreAssemblerCheckBox.Location = new System.Drawing.Point(61, 34);
            this.IgnoreAssemblerCheckBox.Name = "IgnoreAssemblerCheckBox";
            this.IgnoreAssemblerCheckBox.Size = new System.Drawing.Size(215, 24);
            this.IgnoreAssemblerCheckBox.TabIndex = 2;
            this.IgnoreAssemblerCheckBox.Text = "Ignore Assembler Status";
            this.IgnoreAssemblerCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(3, 5);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(52, 20);
            this.FilterLabel.TabIndex = 4;
            this.FilterLabel.Text = "Filter:";
            // 
            // AsProductCheckBox
            // 
            this.AsProductCheckBox.AutoSize = true;
            this.AsProductCheckBox.Checked = true;
            this.AsProductCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AsProductCheckBox.Location = new System.Drawing.Point(236, 63);
            this.AsProductCheckBox.Name = "AsProductCheckBox";
            this.AsProductCheckBox.Size = new System.Drawing.Size(126, 24);
            this.AsProductCheckBox.TabIndex = 4;
            this.AsProductCheckBox.Text = "As Product...";
            this.AsProductCheckBox.UseVisualStyleBackColor = true;
            this.AsProductCheckBox.Visible = false;
            // 
            // AsIngredientCheckBox
            // 
            this.AsIngredientCheckBox.AutoSize = true;
            this.AsIngredientCheckBox.Checked = true;
            this.AsIngredientCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AsIngredientCheckBox.Location = new System.Drawing.Point(61, 63);
            this.AsIngredientCheckBox.Name = "AsIngredientCheckBox";
            this.AsIngredientCheckBox.Size = new System.Drawing.Size(141, 24);
            this.AsIngredientCheckBox.TabIndex = 3;
            this.AsIngredientCheckBox.Text = "As Ingredient...";
            this.AsIngredientCheckBox.UseVisualStyleBackColor = true;
            this.AsIngredientCheckBox.Visible = false;
            // 
            // ShowHiddenCheckBox
            // 
            this.ShowHiddenCheckBox.AutoSize = true;
            this.ShowHiddenCheckBox.Location = new System.Drawing.Point(236, 3);
            this.ShowHiddenCheckBox.Name = "ShowHiddenCheckBox";
            this.ShowHiddenCheckBox.Size = new System.Drawing.Size(130, 24);
            this.ShowHiddenCheckBox.TabIndex = 1;
            this.ShowHiddenCheckBox.Text = "Show Hidden";
            this.ShowHiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.BackColor = System.Drawing.Color.LightGray;
            this.FilterTextBox.ForeColor = System.Drawing.Color.Black;
            this.FilterTextBox.Location = new System.Drawing.Point(61, 2);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(169, 26);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // IRPanelScrollBar
            // 
            this.IRPanelScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IRPanelScrollBar.Location = new System.Drawing.Point(370, 109);
            this.IRPanelScrollBar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.IRPanelScrollBar.Name = "IRPanelScrollBar";
            this.IRPanelScrollBar.Size = new System.Drawing.Size(21, 278);
            this.IRPanelScrollBar.TabIndex = 3;
            this.IRPanelScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IRPanelScrollBar_Scroll);
            // 
            // OtherNodeOptionsTableLayoutPanel
            // 
            this.OtherNodeOptionsTableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.OtherNodeOptionsTableLayoutPanel, 2);
            this.OtherNodeOptionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.OtherNodeOptionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.OtherNodeOptionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.OtherNodeOptionsTableLayoutPanel.Controls.Add(this.AddSupplyButton, 0, 0);
            this.OtherNodeOptionsTableLayoutPanel.Controls.Add(this.AddPassthroughButton, 1, 0);
            this.OtherNodeOptionsTableLayoutPanel.Controls.Add(this.AddConsumerButton, 2, 0);
            this.OtherNodeOptionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OtherNodeOptionsTableLayoutPanel.Location = new System.Drawing.Point(0, 390);
            this.OtherNodeOptionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OtherNodeOptionsTableLayoutPanel.Name = "OtherNodeOptionsTableLayoutPanel";
            this.OtherNodeOptionsTableLayoutPanel.RowCount = 1;
            this.OtherNodeOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OtherNodeOptionsTableLayoutPanel.Size = new System.Drawing.Size(394, 30);
            this.OtherNodeOptionsTableLayoutPanel.TabIndex = 4;
            this.OtherNodeOptionsTableLayoutPanel.Visible = false;
            // 
            // AddSupplyButton
            // 
            this.AddSupplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSupplyButton.Location = new System.Drawing.Point(3, 3);
            this.AddSupplyButton.Name = "AddSupplyButton";
            this.AddSupplyButton.Size = new System.Drawing.Size(112, 24);
            this.AddSupplyButton.TabIndex = 5;
            this.AddSupplyButton.Text = "As Source";
            this.AddSupplyButton.UseVisualStyleBackColor = true;
            // 
            // AddPassthroughButton
            // 
            this.AddPassthroughButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPassthroughButton.Location = new System.Drawing.Point(128, 3);
            this.AddPassthroughButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.AddPassthroughButton.Name = "AddPassthroughButton";
            this.AddPassthroughButton.Size = new System.Drawing.Size(137, 24);
            this.AddPassthroughButton.TabIndex = 6;
            this.AddPassthroughButton.Text = "As Pass-Through";
            this.AddPassthroughButton.UseVisualStyleBackColor = true;
            // 
            // AddConsumerButton
            // 
            this.AddConsumerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddConsumerButton.Location = new System.Drawing.Point(278, 3);
            this.AddConsumerButton.Name = "AddConsumerButton";
            this.AddConsumerButton.Size = new System.Drawing.Size(113, 24);
            this.AddConsumerButton.TabIndex = 7;
            this.AddConsumerButton.Text = "As Output";
            this.AddConsumerButton.UseVisualStyleBackColor = true;
            // 
            // IRChooserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "IRChooserPanel";
            this.Size = new System.Drawing.Size(394, 420);
            this.Leave += new System.EventHandler(this.IRChooserPanel_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OtherNodeOptionsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.FlowLayoutPanel IRFlowPanel;
        protected System.Windows.Forms.FlowLayoutPanel GroupFlowPanel;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.VScrollBar IRPanelScrollBar;
        protected System.Windows.Forms.CheckBox AsProductCheckBox;
        protected System.Windows.Forms.CheckBox AsIngredientCheckBox;
        protected System.Windows.Forms.CheckBox ShowHiddenCheckBox;
        protected System.Windows.Forms.TextBox FilterTextBox;
        protected System.Windows.Forms.Button AddSupplyButton;
        protected System.Windows.Forms.Button AddPassthroughButton;
        protected System.Windows.Forms.Button AddConsumerButton;
        protected System.Windows.Forms.CheckBox IgnoreAssemblerCheckBox;
        protected System.Windows.Forms.Panel ItemIconPanel;
        protected System.Windows.Forms.TableLayoutPanel OtherNodeOptionsTableLayoutPanel;
        protected System.Windows.Forms.Label FilterLabel;
    }
}
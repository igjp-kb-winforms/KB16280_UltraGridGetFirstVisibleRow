namespace KB16280_WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ultraGrid1).BeginInit();
            SuspendLayout();
            // 
            // ultraGrid1
            // 
            ultraGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appearance112.BackColor = SystemColors.Window;
            appearance112.BorderColor = SystemColors.InactiveCaption;
            ultraGrid1.DisplayLayout.Appearance = appearance112;
            ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance13.BackColor = SystemColors.ActiveBorder;
            appearance13.BackColor2 = SystemColors.ControlDark;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance13.BorderColor = SystemColors.Window;
            ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance13;
            appearance12.ForeColor = SystemColors.GrayText;
            ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance12;
            ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance11.BackColor = SystemColors.ControlLightLight;
            appearance11.BackColor2 = SystemColors.Control;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance11.ForeColor = SystemColors.GrayText;
            ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance11;
            ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance17.BackColor = SystemColors.Window;
            appearance17.ForeColor = SystemColors.ControlText;
            ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance111.BackColor = SystemColors.Highlight;
            appearance111.ForeColor = SystemColors.HighlightText;
            ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance111;
            ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance110.BackColor = SystemColors.Window;
            ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance110;
            appearance15.BorderColor = Color.Silver;
            appearance15.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            ultraGrid1.DisplayLayout.Override.CellAppearance = appearance15;
            ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance18.BackColor = SystemColors.Control;
            appearance18.BackColor2 = SystemColors.ControlDark;
            appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance18.BorderColor = SystemColors.Window;
            ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance18;
            appearance19.TextHAlignAsString = "Left";
            ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance19;
            ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance16.BackColor = SystemColors.Window;
            appearance16.BorderColor = Color.Silver;
            ultraGrid1.DisplayLayout.Override.RowAppearance = appearance16;
            ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = SystemColors.ControlLight;
            ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance14;
            ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ultraGrid1.Font = new Font("Yu Gothic UI", 9F);
            ultraGrid1.Location = new Point(12, 12);
            ultraGrid1.Name = "ultraGrid1";
            ultraGrid1.Size = new Size(776, 333);
            ultraGrid1.TabIndex = 0;
            ultraGrid1.Text = "ultraGrid1";
            ultraGrid1.InitializeLayout += ultraGrid1_InitializeLayout;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(207, 57);
            button1.TabIndex = 1;
            button1.Text = "先頭行を取得する";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 11F);
            label1.Location = new Point(252, 394);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ultraGrid1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ultraGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Button button1;
        private Label label1;
    }
}

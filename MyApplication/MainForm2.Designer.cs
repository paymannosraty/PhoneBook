namespace PhoneBook
{
	partial class MainForm2
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
		///
		private void InitializeComponent()
		{
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions31 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions32 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions33 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions34 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions35 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
			this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
			this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
			this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.AllowCustomization = false;
			this.layoutControl.Controls.Add(this.labelControl);
			this.layoutControl.Controls.Add(this.gridControl);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(836, 239, 650, 400);
			this.layoutControl.Root = this.layoutControlGroup;
			this.layoutControl.Size = new System.Drawing.Size(784, 501);
			this.layoutControl.TabIndex = 1;
			// 
			// labelControl
			// 
			this.labelControl.AllowHtmlString = true;
			this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.labelControl.Appearance.Options.UseFont = true;
			this.labelControl.Appearance.Options.UseForeColor = true;
			this.labelControl.Appearance.Options.UseTextOptions = true;
			this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.labelControl.Location = new System.Drawing.Point(40, 0);
			this.labelControl.Name = "labelControl";
			this.labelControl.Padding = new System.Windows.Forms.Padding(0, 3, 13, 6);
			this.labelControl.Size = new System.Drawing.Size(704, 59);
			this.labelControl.StyleController = this.layoutControl;
			this.labelControl.TabIndex = 4;
			this.labelControl.Text = "\rمخاطبین";
			// 
			// gridControl
			// 
			this.gridControl.Location = new System.Drawing.Point(40, 59);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(704, 442);
			this.gridControl.TabIndex = 2;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1,
            this.bandedGridView1,
            this.layoutView1,
            this.gridView2,
            this.gridView3});
			// 
			// gridView
			// 
			this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.Editable = false;
			this.gridView.OptionsCustomization.AllowColumnMoving = false;
			this.gridView.OptionsCustomization.AllowGroup = false;
			this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
			this.gridView.OptionsMenu.EnableColumnMenu = false;
			this.gridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
			this.gridView.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
			this.gridView.OptionsSelection.MultiSelect = true;
			this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			this.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
			this.gridView.OptionsView.ShowAutoFilterRow = true;
			this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.OptionsView.ShowIndicator = false;
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gridView1.ViewCaption = "k";
			// 
			// bandedGridView1
			// 
			this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
			this.bandedGridView1.GridControl = this.gridControl;
			this.bandedGridView1.Name = "bandedGridView1";
			this.bandedGridView1.OptionsBehavior.Editable = false;
			this.bandedGridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			// 
			// gridBand1
			// 
			this.gridBand1.Caption = "gridBand1";
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.VisibleIndex = 0;
			// 
			// layoutView1
			// 
			this.layoutView1.GridControl = this.gridControl;
			this.layoutView1.Name = "layoutView1";
			this.layoutView1.OptionsBehavior.Editable = false;
			this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.layoutView1.TemplateCard = this.layoutViewCard1;
			// 
			// layoutViewCard1
			// 
			this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutViewCard1.Name = "layoutViewTemplateCard";
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
			this.gridView2.GridControl = this.gridControl;
			this.gridView2.Name = "gridView2";
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "gridColumn4";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 0;
			// 
			// gridView3
			// 
			this.gridView3.GridControl = this.gridControl;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsBehavior.Editable = false;
			this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			// 
			// layoutControlGroup
			// 
			this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup.GroupBordersVisible = false;
			this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.itemGrid});
			this.layoutControlGroup.Name = "Root";
			this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
			this.layoutControlGroup.Size = new System.Drawing.Size(784, 501);
			this.layoutControlGroup.TextVisible = false;
			// 
			// itemLabel
			// 
			this.itemLabel.Control = this.labelControl;
			this.itemLabel.Location = new System.Drawing.Point(0, 0);
			this.itemLabel.Name = "itemLabel";
			this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.itemLabel.Size = new System.Drawing.Size(704, 59);
			this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
			this.itemLabel.TextVisible = false;
			// 
			// itemGrid
			// 
			this.itemGrid.Control = this.gridControl;
			this.itemGrid.Location = new System.Drawing.Point(0, 59);
			this.itemGrid.Name = "itemGrid";
			this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.itemGrid.Size = new System.Drawing.Size(704, 442);
			this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
			this.itemGrid.TextVisible = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			// 
			// windowsUIButtonPanel
			// 
			this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
			this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			windowsUIButtonImageOptions31.ImageUri.Uri = "New;Size32x32;GrayScaled";
			windowsUIButtonImageOptions32.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
			windowsUIButtonImageOptions33.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
			windowsUIButtonImageOptions34.ImageUri.Uri = "Refresh;Size32x32;GrayScaled";
			windowsUIButtonImageOptions35.ImageUri.Uri = "Preview;Size32x32;GrayScaled";
			this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("New", true, windowsUIButtonImageOptions31, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", true, windowsUIButtonImageOptions32, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", true, windowsUIButtonImageOptions33, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", true, windowsUIButtonImageOptions34, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", true, windowsUIButtonImageOptions35, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanel.EnableImageTransparency = true;
			this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 501);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 60);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(784, 60);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// MainForm2
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.layoutControl);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Name = "MainForm2";
			this.Load += new System.EventHandler(this.MainForm2_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
		private DevExpress.XtraLayout.LayoutControlItem itemLabel;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraLayout.LayoutControlItem itemGrid;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
		private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
	}
}
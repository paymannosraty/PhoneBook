using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using System.Data.Entity;

namespace PhoneBook
{
	public partial class MainForm2 : XtraForm
	{
		public MainForm2()
		{
			InitializeComponent();
		}

		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
		}
	
		public void SearchContact()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				System.Collections.Generic.List<Models.Contact> contacts;

				contacts = databaseContext.Contacts.ToList();

				gridControl.DataSource = contacts;

			}
			catch (System.Exception)
			{
				System.Windows.Forms.MessageBox.Show("Some Error Accured");
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void MainForm2_Load(object sender, EventArgs e)
		{
			SearchContact();
			gridView.Columns[0].Caption = "نام ";
			gridView.Columns[1].Caption = "نام خانوادگی";
			gridView.Columns[2].Caption = "شماره ثابت";
			gridView.Columns[3].Caption = "شماره موبایل ";
			gridView.Columns[4].Caption = "آدرس ";
			gridView.Columns[5].Visible = false;
			gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

		}
	}
}

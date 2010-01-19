
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Gui.Dialogs
{
	internal partial class SelectReferenceDialog
	{
		private global::Gtk.VBox vbox5;

		private global::Gtk.VPaned vpaned1;

		private global::Gtk.Notebook mainBook;

		private global::Gtk.Label label7;

		private global::Gtk.Label label6;

		private global::Gtk.VBox vbox76;

		private global::Gtk.Label label114;

		private global::Gtk.HBox hbox4;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.TreeView ReferencesTreeView;

		private global::Gtk.VBox vbox70;

		private global::Gtk.Button RemoveReferenceButton;

		private global::Gtk.Image but;

		private global::Gtk.Button cancelbutton;

		private global::Gtk.Button okbutton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog
			this.WidthRequest = 640;
			this.HeightRequest = 520;
			this.Name = "MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog";
			this.Title = "Edit References";
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.Modal = true;
			this.BorderWidth = ((uint)(6));
			this.DefaultWidth = 520;
			this.DefaultHeight = 570;
			this.DestroyWithParent = true;
			// Internal child MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog-vbox2";
			w1.Spacing = 6;
			// Container child dialog-vbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 12;
			this.vbox5.BorderWidth = ((uint)(6));
			// Container child vbox5.Gtk.Box+BoxChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 256;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.mainBook = new global::Gtk.Notebook ();
			this.mainBook.Name = "mainBook";
			this.mainBook.CurrentPage = 0;
			// Container child mainBook.Gtk.Notebook+NotebookChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.Yalign = 0f;
			this.label7.LabelProp = "label7";
			this.mainBook.Add (this.label7);
			// Notebook tab
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0f;
			this.label6.Yalign = 0f;
			this.label6.LabelProp = "label6";
			this.mainBook.SetTabLabel (this.label7, this.label6);
			this.label6.ShowAll ();
			this.vpaned1.Add (this.mainBook);
			global::Gtk.Paned.PanedChild w3 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.mainBook]));
			w3.Resize = false;
			w3.Shrink = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.vbox76 = new global::Gtk.VBox ();
			this.vbox76.Name = "vbox76";
			this.vbox76.Spacing = 6;
			// Container child vbox76.Gtk.Box+BoxChild
			this.label114 = new global::Gtk.Label ();
			this.label114.Name = "label114";
			this.label114.Xalign = 0f;
			this.label114.LabelProp = global::Mono.Unix.Catalog.GetString ("Selected references:");
			this.vbox76.Add (this.label114);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox76[this.label114]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox76.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.HeightRequest = 150;
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 12;
			// Container child hbox4.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.ReferencesTreeView = new global::Gtk.TreeView ();
			this.ReferencesTreeView.Name = "ReferencesTreeView";
			this.scrolledwindow2.Add (this.ReferencesTreeView);
			this.hbox4.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.scrolledwindow2]));
			w6.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox70 = new global::Gtk.VBox ();
			this.vbox70.Name = "vbox70";
			// Container child vbox70.Gtk.Box+BoxChild
			this.RemoveReferenceButton = new global::Gtk.Button ();
			this.RemoveReferenceButton.TooltipMarkup = "Remove";
			this.RemoveReferenceButton.Name = "RemoveReferenceButton";
			// Container child RemoveReferenceButton.Gtk.Container+ContainerChild
			this.but = new global::Gtk.Image ();
			this.but.Name = "but";
			this.but.Xalign = 0f;
			this.but.Yalign = 0f;
			this.but.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Button);
			this.RemoveReferenceButton.Add (this.but);
			this.RemoveReferenceButton.Label = null;
			this.vbox70.Add (this.RemoveReferenceButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox70[this.RemoveReferenceButton]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox4.Add (this.vbox70);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox70]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox76.Add (this.hbox4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox76[this.hbox4]));
			w10.Position = 1;
			this.vpaned1.Add (this.vbox76);
			global::Gtk.Paned.PanedChild w11 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.vbox76]));
			w11.Resize = false;
			this.vbox5.Add (this.vpaned1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vpaned1]));
			w12.Position = 0;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1[this.vbox5]));
			w13.Position = 0;
			// Internal child MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog.ActionArea
			global::Gtk.HButtonBox w14 = this.ActionArea;
			w14.Name = "dialog-action_area2";
			w14.Spacing = 10;
			w14.BorderWidth = ((uint)(5));
			w14.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
			this.cancelbutton = new global::Gtk.Button ();
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.UseStock = true;
			this.cancelbutton.UseUnderline = true;
			this.cancelbutton.Label = "gtk-cancel";
			this.AddActionWidget (this.cancelbutton, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14[this.cancelbutton]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
			this.okbutton = new global::Gtk.Button ();
			this.okbutton.Name = "okbutton";
			this.okbutton.UseStock = true;
			this.okbutton.UseUnderline = true;
			this.okbutton.Label = "gtk-ok";
			this.AddActionWidget (this.okbutton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14[this.okbutton]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.RemoveReferenceButton.Clicked += new global::System.EventHandler (this.RemoveReference);
		}
	}
}

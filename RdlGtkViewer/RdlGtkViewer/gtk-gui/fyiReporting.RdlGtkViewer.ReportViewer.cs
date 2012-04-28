
// This file has been generated by the GUI designer. Do not modify.
namespace fyiReporting.RdlGtkViewer
{
	public partial class ReportViewer
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action refreshAction;
		private global::Gtk.Action PdfAction;
		private global::Gtk.Action printAction;
		private global::Gtk.Action ZoomOutAction;
		private global::Gtk.Action ZoomInAction;
		private global::Gtk.ToggleAction errorsAction;
		private global::Gtk.VBox vbox;
		private global::Gtk.HBox hboxHeader;
		private global::Gtk.Toolbar toolbar;
		private global::Gtk.HBox hbox;
		private global::Gtk.VBox vboxParameters;
		private global::Gtk.HPaned hpanedReport;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::fyiReporting.RdlGtkViewer.ReportArea reportarea;
		private global::Gtk.ScrolledWindow scrolledwindowErrors;
		private global::Gtk.TextView textviewErrors;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget fyiReporting.RdlGtkViewer.ReportViewer
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.refreshAction = new global::Gtk.Action ("refreshAction", null, null, "gtk-refresh");
			this.refreshAction.IsImportant = true;
			w2.Add (this.refreshAction, null);
			this.PdfAction = new global::Gtk.Action ("PdfAction", global::Mono.Unix.Catalog.GetString ("_Pdf"), null, "PdfIcon");
			this.PdfAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Pdf");
			w2.Add (this.PdfAction, null);
			this.printAction = new global::Gtk.Action ("printAction", global::Mono.Unix.Catalog.GetString ("_Print"), null, "gtk-print");
			this.printAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Print");
			w2.Add (this.printAction, null);
			this.ZoomOutAction = new global::Gtk.Action ("ZoomOutAction", null, null, "gtk-zoom-out");
			this.ZoomOutAction.IsImportant = true;
			w2.Add (this.ZoomOutAction, null);
			this.ZoomInAction = new global::Gtk.Action ("ZoomInAction", null, null, "gtk-zoom-in");
			this.ZoomInAction.IsImportant = true;
			w2.Add (this.ZoomInAction, null);
			this.errorsAction = new global::Gtk.ToggleAction ("errorsAction", null, null, "gtk-dialog-warning");
			this.errorsAction.DrawAsRadio = true;
			this.errorsAction.IsImportant = true;
			this.errorsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Show _Errors");
			w2.Add (this.errorsAction, null);
			this.UIManager.InsertActionGroup (w2, 0);
			this.WidthRequest = 0;
			this.HeightRequest = 0;
			this.Name = "fyiReporting.RdlGtkViewer.ReportViewer";
			// Container child fyiReporting.RdlGtkViewer.ReportViewer.Gtk.Container+ContainerChild
			this.vbox = new global::Gtk.VBox ();
			this.vbox.Name = "vbox";
			this.vbox.Spacing = 6;
			// Container child vbox.Gtk.Box+BoxChild
			this.hboxHeader = new global::Gtk.HBox ();
			this.hboxHeader.Name = "hboxHeader";
			this.hboxHeader.Spacing = 6;
			// Container child hboxHeader.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar'><toolitem name='printAction' action='printAction'/><toolitem name='PdfAction' action='PdfAction'/><separator/><toolitem name='ZoomInAction' action='ZoomInAction'/><toolitem name='ZoomOutAction' action='ZoomOutAction'/><toolitem name='refreshAction' action='refreshAction'/><separator/><toolitem name='errorsAction' action='errorsAction'/></toolbar></ui>");
			this.toolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar")));
			this.toolbar.Name = "toolbar";
			this.toolbar.ShowArrow = false;
			this.toolbar.ToolbarStyle = ((global::Gtk.ToolbarStyle)(3));
			this.toolbar.IconSize = ((global::Gtk.IconSize)(2));
			this.hboxHeader.Add (this.toolbar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxHeader [this.toolbar]));
			w3.Position = 0;
			this.vbox.Add (this.hboxHeader);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hboxHeader]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox.Gtk.Box+BoxChild
			this.hbox = new global::Gtk.HBox ();
			this.hbox.Name = "hbox";
			this.hbox.Spacing = 6;
			// Container child hbox.Gtk.Box+BoxChild
			this.vboxParameters = new global::Gtk.VBox ();
			this.vboxParameters.Name = "vboxParameters";
			this.vboxParameters.Spacing = 6;
			this.hbox.Add (this.vboxParameters);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox [this.vboxParameters]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox.Gtk.Box+BoxChild
			this.hpanedReport = new global::Gtk.HPaned ();
			this.hpanedReport.CanFocus = true;
			this.hpanedReport.Name = "hpanedReport";
			this.hpanedReport.Position = 455;
			// Container child hpanedReport.Gtk.Paned+PanedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w6 = new global::Gtk.Viewport ();
			w6.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.reportarea = new global::fyiReporting.RdlGtkViewer.ReportArea ();
			this.reportarea.Name = "reportarea";
			this.reportarea.Scale = 0F;
			w6.Add (this.reportarea);
			this.GtkScrolledWindow.Add (w6);
			this.hpanedReport.Add (this.GtkScrolledWindow);
			global::Gtk.Paned.PanedChild w9 = ((global::Gtk.Paned.PanedChild)(this.hpanedReport [this.GtkScrolledWindow]));
			w9.Resize = false;
			// Container child hpanedReport.Gtk.Paned+PanedChild
			this.scrolledwindowErrors = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowErrors.CanFocus = true;
			this.scrolledwindowErrors.Name = "scrolledwindowErrors";
			this.scrolledwindowErrors.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowErrors.Gtk.Container+ContainerChild
			this.textviewErrors = new global::Gtk.TextView ();
			this.textviewErrors.WidthRequest = 200;
			this.textviewErrors.CanFocus = true;
			this.textviewErrors.Name = "textviewErrors";
			this.scrolledwindowErrors.Add (this.textviewErrors);
			this.hpanedReport.Add (this.scrolledwindowErrors);
			global::Gtk.Paned.PanedChild w11 = ((global::Gtk.Paned.PanedChild)(this.hpanedReport [this.scrolledwindowErrors]));
			w11.Resize = false;
			w11.Shrink = false;
			this.hbox.Add (this.hpanedReport);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox [this.hpanedReport]));
			w12.Position = 1;
			this.vbox.Add (this.hbox);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hbox]));
			w13.Position = 1;
			this.Add (this.vbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.vboxParameters.Hide ();
			this.textviewErrors.Hide ();
			this.Hide ();
			this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
			this.PdfAction.Activated += new global::System.EventHandler (this.OnPdfActionActivated);
			this.printAction.Activated += new global::System.EventHandler (this.OnPrintActionActivated);
			this.ZoomOutAction.Activated += new global::System.EventHandler (this.OnZoomOutActionActivated);
			this.ZoomInAction.Activated += new global::System.EventHandler (this.OnZoomInActionActivated);
			this.hpanedReport.SizeAllocated += new global::Gtk.SizeAllocatedHandler (this.OnHpanedReportSizeAllocated);
		}
	}
}

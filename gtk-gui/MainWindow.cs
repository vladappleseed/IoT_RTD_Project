
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action AboutOurAppAction;

	private global::Gtk.Action SettingsAction;

	private global::Gtk.Fixed mainWindow;

	private global::Gtk.Label helloLabel;

	private global::Gtk.Label currentLocationText;

	private global::Gtk.Label currentLocationAddress;

	private global::Gtk.Label dateText;

	private global::Gtk.Label currentTimeText;

	private global::Gtk.ComboBox startBox;

	private global::Gtk.ComboBox destinationBox;

	private global::Gtk.Label startAtText;

	private global::Gtk.Label destinationText;

	private global::Gtk.Label startAtTextNote;

	private global::Gtk.Button goButton;

	private global::Gtk.Label tripDistance;

	private global::Gtk.Calendar calendarWindow;

	private global::Gtk.Label nextBusDeparture;

	private global::Gtk.RadioButton milesRadioButton;

	private global::Gtk.RadioButton kilometersRadioButton;

	private global::Gtk.Label estimatedArrival;

	private global::Gtk.Label numberOfStops;

	private global::Gtk.ProgressBar progressbar1;

	private global::Gtk.Label tripStatus;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.AboutOurAppAction = new global::Gtk.Action("AboutOurAppAction", global::Mono.Unix.Catalog.GetString("About our App"), null, null);
		this.AboutOurAppAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About our App");
		w1.Add(this.AboutOurAppAction, null);
		this.SettingsAction = new global::Gtk.Action("SettingsAction", global::Mono.Unix.Catalog.GetString("Settings"), null, null);
		this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Settings");
		w1.Add(this.SettingsAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainWindow = new global::Gtk.Fixed();
		this.mainWindow.WidthRequest = 790;
		this.mainWindow.HeightRequest = 430;
		this.mainWindow.Name = "mainWindow";
		this.mainWindow.HasWindow = false;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.helloLabel = new global::Gtk.Label();
		this.helloLabel.Name = "helloLabel";
		this.helloLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Hello, User!");
		this.mainWindow.Add(this.helloLabel);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.helloLabel]));
		w2.X = 20;
		w2.Y = 20;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.currentLocationText = new global::Gtk.Label();
		this.currentLocationText.Name = "currentLocationText";
		this.currentLocationText.LabelProp = global::Mono.Unix.Catalog.GetString("Your address:");
		this.mainWindow.Add(this.currentLocationText);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.currentLocationText]));
		w3.X = 20;
		w3.Y = 50;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.currentLocationAddress = new global::Gtk.Label();
		this.currentLocationAddress.Name = "currentLocationAddress";
		this.currentLocationAddress.LabelProp = global::Mono.Unix.Catalog.GetString("Address here");
		this.mainWindow.Add(this.currentLocationAddress);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.currentLocationAddress]));
		w4.X = 20;
		w4.Y = 70;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.dateText = new global::Gtk.Label();
		this.dateText.Name = "dateText";
		this.dateText.Xpad = 55;
		this.dateText.LabelProp = global::Mono.Unix.Catalog.GetString("Date here");
		this.dateText.Justify = ((global::Gtk.Justification)(2));
		this.mainWindow.Add(this.dateText);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.dateText]));
		w5.X = 570;
		w5.Y = 20;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.currentTimeText = new global::Gtk.Label();
		this.currentTimeText.Name = "currentTimeText";
		this.currentTimeText.Xpad = 35;
		this.currentTimeText.LabelProp = global::Mono.Unix.Catalog.GetString("Time here");
		this.mainWindow.Add(this.currentTimeText);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.currentTimeText]));
		w6.X = 620;
		w6.Y = 45;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.startBox = global::Gtk.ComboBox.NewText();
		this.startBox.Name = "startBox";
		this.mainWindow.Add(this.startBox);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.startBox]));
		w7.X = 20;
		w7.Y = 155;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.destinationBox = global::Gtk.ComboBox.NewText();
		this.destinationBox.Name = "destinationBox";
		this.mainWindow.Add(this.destinationBox);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.destinationBox]));
		w8.X = 20;
		w8.Y = 235;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.startAtText = new global::Gtk.Label();
		this.startAtText.Name = "startAtText";
		this.startAtText.LabelProp = global::Mono.Unix.Catalog.GetString("Start at text");
		this.mainWindow.Add(this.startAtText);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.startAtText]));
		w9.X = 20;
		w9.Y = 135;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.destinationText = new global::Gtk.Label();
		this.destinationText.Name = "destinationText";
		this.destinationText.LabelProp = global::Mono.Unix.Catalog.GetString("Destination text");
		this.mainWindow.Add(this.destinationText);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.destinationText]));
		w10.X = 20;
		w10.Y = 215;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.startAtTextNote = new global::Gtk.Label();
		this.startAtTextNote.Name = "startAtTextNote";
		this.startAtTextNote.LabelProp = global::Mono.Unix.Catalog.GetString("note here");
		this.mainWindow.Add(this.startAtTextNote);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.startAtTextNote]));
		w11.X = 100;
		w11.Y = 132;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.goButton = new global::Gtk.Button();
		this.goButton.WidthRequest = 120;
		this.goButton.CanFocus = true;
		this.goButton.Name = "goButton";
		this.goButton.UseUnderline = true;
		this.goButton.BorderWidth = ((uint)(1));
		this.goButton.Label = global::Mono.Unix.Catalog.GetString("Go!");
		this.mainWindow.Add(this.goButton);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.goButton]));
		w12.X = 340;
		w12.Y = 300;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.tripDistance = new global::Gtk.Label();
		this.tripDistance.Name = "tripDistance";
		this.tripDistance.LabelProp = global::Mono.Unix.Catalog.GetString("Trip distance text here");
		this.mainWindow.Add(this.tripDistance);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.tripDistance]));
		w13.X = 270;
		w13.Y = 360;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.calendarWindow = new global::Gtk.Calendar();
		this.calendarWindow.WidthRequest = 170;
		this.calendarWindow.Sensitive = false;
		this.calendarWindow.Name = "calendarWindow";
		this.calendarWindow.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(37));
		this.calendarWindow.ShowDayNames = false;
		this.calendarWindow.NoMonthChange = true;
		this.mainWindow.Add(this.calendarWindow);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.calendarWindow]));
		w14.X = 615;
		w14.Y = 80;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.nextBusDeparture = new global::Gtk.Label();
		this.nextBusDeparture.Name = "nextBusDeparture";
		this.nextBusDeparture.LabelProp = global::Mono.Unix.Catalog.GetString("Next Bus Departure time text");
		this.mainWindow.Add(this.nextBusDeparture);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.nextBusDeparture]));
		w15.X = 270;
		w15.Y = 385;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.milesRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Miles"));
		this.milesRadioButton.CanFocus = true;
		this.milesRadioButton.Name = "milesRadioButton";
		this.milesRadioButton.DrawIndicator = true;
		this.milesRadioButton.UseUnderline = true;
		this.milesRadioButton.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.mainWindow.Add(this.milesRadioButton);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.milesRadioButton]));
		w16.X = 20;
		w16.Y = 95;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.kilometersRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Kilometers"));
		this.kilometersRadioButton.CanFocus = true;
		this.kilometersRadioButton.Name = "kilometersRadioButton";
		this.kilometersRadioButton.DrawIndicator = true;
		this.kilometersRadioButton.UseUnderline = true;
		this.kilometersRadioButton.Group = this.milesRadioButton.Group;
		this.mainWindow.Add(this.kilometersRadioButton);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.kilometersRadioButton]));
		w17.X = 90;
		w17.Y = 95;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.estimatedArrival = new global::Gtk.Label();
		this.estimatedArrival.Name = "estimatedArrival";
		this.estimatedArrival.LabelProp = global::Mono.Unix.Catalog.GetString("Estimated Arrival time text");
		this.mainWindow.Add(this.estimatedArrival);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.estimatedArrival]));
		w18.X = 270;
		w18.Y = 410;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.numberOfStops = new global::Gtk.Label();
		this.numberOfStops.Name = "numberOfStops";
		this.numberOfStops.LabelProp = global::Mono.Unix.Catalog.GetString("Number of Stops text");
		this.mainWindow.Add(this.numberOfStops);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.numberOfStops]));
		w19.X = 270;
		w19.Y = 435;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.progressbar1 = new global::Gtk.ProgressBar();
		this.progressbar1.Name = "progressbar1";
		this.mainWindow.Add(this.progressbar1);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.progressbar1]));
		w20.X = 324;
		w20.Y = 332;
		// Container child mainWindow.Gtk.Fixed+FixedChild
		this.tripStatus = new global::Gtk.Label();
		this.tripStatus.Name = "tripStatus";
		this.tripStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Trip status text here");
		this.mainWindow.Add(this.tripStatus);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.mainWindow[this.tripStatus]));
		w21.X = 20;
		w21.Y = 280;
		this.Add(this.mainWindow);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 806;
		this.DefaultHeight = 488;
		this.Show();
	}
}

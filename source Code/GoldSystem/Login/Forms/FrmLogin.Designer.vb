<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginCheck = New ns1.BunifuCheckbox()
    Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
    Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
    Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
    Me.TxtPass = New ns1.BunifuMaterialTextbox()
    Me.TxtUser = New ns1.BunifuMaterialTextbox()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    resources.ApplyResources(Me.Panel1, "Panel1")
    Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Name = "Panel1"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.ForeColor = System.Drawing.Color.DarkGray
    Me.Label3.Name = "Label3"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.ForeColor = System.Drawing.Color.DarkGray
    Me.Label2.Name = "Label2"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.ForeColor = System.Drawing.Color.DarkGray
    Me.Label1.Name = "Label1"
    '
    'Panel2
    '
    resources.ApplyResources(Me.Panel2, "Panel2")
    Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.LoginCheck)
    Me.Panel2.Controls.Add(Me.GunaLinkLabel2)
    Me.Panel2.Controls.Add(Me.GunaLinkLabel1)
    Me.Panel2.Controls.Add(Me.GunaButton1)
    Me.Panel2.Controls.Add(Me.TxtPass)
    Me.Panel2.Controls.Add(Me.TxtUser)
    Me.Panel2.Name = "Panel2"
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.ForeColor = System.Drawing.Color.DarkGray
    Me.Label4.Name = "Label4"
    '
    'LoginCheck
    '
    Me.LoginCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.LoginCheck.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.LoginCheck.Checked = False
    Me.LoginCheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
    Me.LoginCheck.ForeColor = System.Drawing.Color.White
    resources.ApplyResources(Me.LoginCheck, "LoginCheck")
    Me.LoginCheck.Name = "LoginCheck"
    '
    'GunaLinkLabel2
    '
    resources.ApplyResources(Me.GunaLinkLabel2, "GunaLinkLabel2")
    Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.Gray
    Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
    Me.GunaLinkLabel2.TabStop = True
    '
    'GunaLinkLabel1
    '
    resources.ApplyResources(Me.GunaLinkLabel1, "GunaLinkLabel1")
    Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.Gray
    Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
    Me.GunaLinkLabel1.TabStop = True
    '
    'GunaButton1
    '
    Me.GunaButton1.AnimationHoverSpeed = 0.07!
    Me.GunaButton1.AnimationSpeed = 0.03!
    Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.GunaButton1.BorderColor = System.Drawing.Color.Black
    Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
    Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
    resources.ApplyResources(Me.GunaButton1, "GunaButton1")
    Me.GunaButton1.ForeColor = System.Drawing.Color.White
    Me.GunaButton1.Image = Nothing
    Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
    Me.GunaButton1.Name = "GunaButton1"
    Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
    Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
    Me.GunaButton1.OnHoverImage = Nothing
    Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
    Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'TxtPass
    '
    Me.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam
    resources.ApplyResources(Me.TxtPass, "TxtPass")
    Me.TxtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.TxtPass.HintForeColor = System.Drawing.Color.Silver
    Me.TxtPass.HintText = "Password"
    Me.TxtPass.isPassword = True
    Me.TxtPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.TxtPass.LineIdleColor = System.Drawing.Color.Silver
    Me.TxtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.TxtPass.LineThickness = 3
    Me.TxtPass.Name = "TxtPass"
    Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
    '
    'TxtUser
    '
    Me.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam
    resources.ApplyResources(Me.TxtUser, "TxtUser")
    Me.TxtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.TxtUser.HintForeColor = System.Drawing.Color.Silver
    Me.TxtUser.HintText = "Username"
    Me.TxtUser.isPassword = False
    Me.TxtUser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.TxtUser.LineIdleColor = System.Drawing.Color.Silver
    Me.TxtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
    Me.TxtUser.LineThickness = 3
    Me.TxtUser.Name = "TxtUser"
    Me.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
    '
    'FrmLogin
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.DoubleBuffered = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmLogin"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents TxtPass As ns1.BunifuMaterialTextbox
    Friend WithEvents TxtUser As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents LoginCheck As ns1.BunifuCheckbox
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
End Class

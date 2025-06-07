<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpassreset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtperfume = New System.Windows.Forms.TextBox()
        Me.txtfacecream = New System.Windows.Forms.TextBox()
        Me.txthairstyle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.btnsubmit)
        Me.Panel1.Controls.Add(Me.txtperfume)
        Me.Panel1.Controls.Add(Me.txtfacecream)
        Me.Panel1.Controls.Add(Me.txthairstyle)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(22, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 585)
        Me.Panel1.TabIndex = 0
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.DimGray
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsubmit.Location = New System.Drawing.Point(87, 470)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(353, 77)
        Me.btnsubmit.TabIndex = 3
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'txtperfume
        '
        Me.txtperfume.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtperfume.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperfume.Location = New System.Drawing.Point(96, 385)
        Me.txtperfume.Name = "txtperfume"
        Me.txtperfume.Size = New System.Drawing.Size(321, 34)
        Me.txtperfume.TabIndex = 3
        '
        'txtfacecream
        '
        Me.txtfacecream.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtfacecream.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfacecream.Location = New System.Drawing.Point(96, 278)
        Me.txtfacecream.Name = "txtfacecream"
        Me.txtfacecream.Size = New System.Drawing.Size(321, 34)
        Me.txtfacecream.TabIndex = 2
        '
        'txthairstyle
        '
        Me.txthairstyle.BackColor = System.Drawing.SystemColors.Control
        Me.txthairstyle.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthairstyle.Location = New System.Drawing.Point(96, 185)
        Me.txthairstyle.Name = "txthairstyle"
        Me.txthairstyle.Size = New System.Drawing.Size(321, 34)
        Me.txthairstyle.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(349, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "02.what is your favorite face cream?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "03.what is your favorite perfume?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(331, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "01.What is your favorite hairstyle?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Let us help you"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forgot your password?"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmpassreset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(566, 608)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpassreset"
        Me.Text = "frmpassreset"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txthairstyle As TextBox
    Friend WithEvents txtfacecream As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents txtperfume As TextBox
End Class

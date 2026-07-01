<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(466, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "END"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(252, 214)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 3
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(358, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 4
        Label2.Text = "Label2"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(466, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 23)
        Label3.TabIndex = 5
        Label3.Text = "Label3"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(292, 415)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 6
        Button2.Text = "SPIN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 450)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "SPIN"
        TransparencyKey = Color.Transparent
        ResumeLayout(False)
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button

End Class

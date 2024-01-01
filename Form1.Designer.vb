<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        UrlTextBox = New TextBox()
        OutputTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(930, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Fetch"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' UrlTextBox
        ' 
        UrlTextBox.Location = New Point(12, 14)
        UrlTextBox.Name = "UrlTextBox"
        UrlTextBox.Size = New Size(912, 27)
        UrlTextBox.TabIndex = 1
        ' 
        ' OutputTextBox
        ' 
        OutputTextBox.Dock = DockStyle.Bottom
        OutputTextBox.Location = New Point(0, 118)
        OutputTextBox.Multiline = True
        OutputTextBox.Name = "OutputTextBox"
        OutputTextBox.Size = New Size(1036, 508)
        OutputTextBox.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1036, 626)
        Controls.Add(OutputTextBox)
        Controls.Add(UrlTextBox)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents UrlTextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
End Class

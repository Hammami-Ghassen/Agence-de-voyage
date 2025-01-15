<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumVolInput
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        btn_next = New Button()
        btn_cancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 32)
        Label1.TabIndex = 0
        Label1.Text = "Veuillez saisire le numéro du vol"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(384, 23)
        TextBox1.TabIndex = 1
        ' 
        ' btn_next
        ' 
        btn_next.Location = New Point(225, 125)
        btn_next.Name = "btn_next"
        btn_next.Size = New Size(171, 23)
        btn_next.TabIndex = 2
        btn_next.Text = "Suivant"
        btn_next.UseVisualStyleBackColor = True
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Location = New Point(12, 125)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(171, 23)
        btn_cancel.TabIndex = 3
        btn_cancel.Text = "Annuler"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' NumVolInput
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(417, 178)
        Controls.Add(btn_cancel)
        Controls.Add(btn_next)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "NumVolInput"
        Text = "NumVolInput"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_cancel As Button
End Class

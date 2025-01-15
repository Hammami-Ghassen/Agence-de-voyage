<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Réservation
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
        txt_prenom = New TextBox()
        Label4 = New Label()
        txt_tel = New TextBox()
        Label3 = New Label()
        txt_nom = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btn_annuler = New Button()
        btn_confirmer = New Button()
        SuspendLayout()
        ' 
        ' txt_prenom
        ' 
        txt_prenom.Location = New Point(155, 173)
        txt_prenom.Name = "txt_prenom"
        txt_prenom.Size = New Size(246, 23)
        txt_prenom.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(83, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 13
        Label4.Text = "Prénom"
        ' 
        ' txt_tel
        ' 
        txt_tel.Location = New Point(155, 228)
        txt_tel.Name = "txt_tel"
        txt_tel.Size = New Size(246, 23)
        txt_tel.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 15)
        Label3.TabIndex = 11
        Label3.Text = "Numéro de télephone"
        ' 
        ' txt_nom
        ' 
        txt_nom.Location = New Point(155, 117)
        txt_nom.Name = "txt_nom"
        txt_nom.Size = New Size(246, 23)
        txt_nom.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nom"
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(56, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 73)
        Label1.TabIndex = 27
        Label1.Text = "Veuillez saisire vos informations"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_annuler
        ' 
        btn_annuler.Location = New Point(137, 277)
        btn_annuler.Name = "btn_annuler"
        btn_annuler.Size = New Size(129, 34)
        btn_annuler.TabIndex = 29
        btn_annuler.Text = "Annuler"
        btn_annuler.UseVisualStyleBackColor = True
        ' 
        ' btn_confirmer
        ' 
        btn_confirmer.Location = New Point(272, 277)
        btn_confirmer.Name = "btn_confirmer"
        btn_confirmer.Size = New Size(129, 34)
        btn_confirmer.TabIndex = 28
        btn_confirmer.Text = "Confirmer"
        btn_confirmer.UseVisualStyleBackColor = True
        ' 
        ' Réservation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 335)
        Controls.Add(btn_annuler)
        Controls.Add(btn_confirmer)
        Controls.Add(Label1)
        Controls.Add(txt_prenom)
        Controls.Add(Label4)
        Controls.Add(txt_tel)
        Controls.Add(Label3)
        Controls.Add(txt_nom)
        Controls.Add(Label2)
        Name = "Réservation"
        Text = "Réservation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_confirmer As Button
End Class

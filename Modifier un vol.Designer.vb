<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modifier_un_vol
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
        btn_annuler = New Button()
        txt_nbPlace = New TextBox()
        Label6 = New Label()
        txt_prix = New TextBox()
        Label5 = New Label()
        txt_date = New TextBox()
        Label4 = New Label()
        txt_heure = New TextBox()
        Label3 = New Label()
        txt_dest = New TextBox()
        Label2 = New Label()
        btn_ajouter = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_annuler
        ' 
        btn_annuler.Location = New Point(100, 358)
        btn_annuler.Name = "btn_annuler"
        btn_annuler.Size = New Size(129, 34)
        btn_annuler.TabIndex = 25
        btn_annuler.Text = "Annuler"
        btn_annuler.UseVisualStyleBackColor = True
        ' 
        ' txt_nbPlace
        ' 
        txt_nbPlace.Location = New Point(118, 251)
        txt_nbPlace.Name = "txt_nbPlace"
        txt_nbPlace.Size = New Size(246, 23)
        txt_nbPlace.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 259)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 15)
        Label6.TabIndex = 23
        Label6.Text = "Nombre de places"
        ' 
        ' txt_prix
        ' 
        txt_prix.Location = New Point(118, 311)
        txt_prix.Name = "txt_prix"
        txt_prix.RightToLeft = RightToLeft.No
        txt_prix.Size = New Size(246, 23)
        txt_prix.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(69, 319)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(26, 15)
        Label5.TabIndex = 21
        Label5.Text = "Prix"
        ' 
        ' txt_date
        ' 
        txt_date.Location = New Point(118, 145)
        txt_date.Name = "txt_date"
        txt_date.Size = New Size(246, 23)
        txt_date.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 19
        Label4.Text = "Date"
        ' 
        ' txt_heure
        ' 
        txt_heure.Location = New Point(118, 200)
        txt_heure.Name = "txt_heure"
        txt_heure.Size = New Size(246, 23)
        txt_heure.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 17
        Label3.Text = "Heure"
        ' 
        ' txt_dest
        ' 
        txt_dest.Location = New Point(118, 89)
        txt_dest.Name = "txt_dest"
        txt_dest.Size = New Size(246, 23)
        txt_dest.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 15
        Label2.Text = "Destination"
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Location = New Point(235, 358)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(129, 34)
        btn_ajouter.TabIndex = 14
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 73)
        Label1.TabIndex = 26
        Label1.Text = "Veuillez saisire les informations à modifier"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Modifier_un_vol
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(461, 423)
        Controls.Add(Label1)
        Controls.Add(btn_annuler)
        Controls.Add(txt_nbPlace)
        Controls.Add(Label6)
        Controls.Add(txt_prix)
        Controls.Add(Label5)
        Controls.Add(txt_date)
        Controls.Add(Label4)
        Controls.Add(txt_heure)
        Controls.Add(Label3)
        Controls.Add(txt_dest)
        Controls.Add(Label2)
        Controls.Add(btn_ajouter)
        Name = "Modifier_un_vol"
        Text = "Modifier_un_vol"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_annuler As Button
    Friend WithEvents txt_nbPlace As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_prix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_heure As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_dest As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents Label1 As Label
End Class

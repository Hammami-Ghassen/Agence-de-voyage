<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_select
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
        btn_aff_vol = New Button()
        btn_ajouter_vol = New Button()
        bnt_modifier_vol = New Button()
        btn_supprimer_vol = New Button()
        SuspendLayout()
        ' 
        ' btn_aff_vol
        ' 
        btn_aff_vol.Location = New Point(47, 145)
        btn_aff_vol.Name = "btn_aff_vol"
        btn_aff_vol.Size = New Size(293, 36)
        btn_aff_vol.TabIndex = 0
        btn_aff_vol.Text = "Afficher la liste des vols"
        btn_aff_vol.UseVisualStyleBackColor = True
        ' 
        ' btn_ajouter_vol
        ' 
        btn_ajouter_vol.Location = New Point(47, 19)
        btn_ajouter_vol.Name = "btn_ajouter_vol"
        btn_ajouter_vol.Size = New Size(293, 36)
        btn_ajouter_vol.TabIndex = 1
        btn_ajouter_vol.Text = "Ajouter un vol"
        btn_ajouter_vol.UseVisualStyleBackColor = True
        ' 
        ' bnt_modifier_vol
        ' 
        bnt_modifier_vol.Location = New Point(47, 61)
        bnt_modifier_vol.Name = "bnt_modifier_vol"
        bnt_modifier_vol.Size = New Size(293, 36)
        bnt_modifier_vol.TabIndex = 2
        bnt_modifier_vol.Text = "Modifier les informations d'un vol"
        bnt_modifier_vol.UseVisualStyleBackColor = True
        ' 
        ' btn_supprimer_vol
        ' 
        btn_supprimer_vol.Location = New Point(47, 103)
        btn_supprimer_vol.Name = "btn_supprimer_vol"
        btn_supprimer_vol.Size = New Size(293, 36)
        btn_supprimer_vol.TabIndex = 3
        btn_supprimer_vol.Text = "Supprimer un vol"
        btn_supprimer_vol.UseVisualStyleBackColor = True
        ' 
        ' admin_select
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(405, 236)
        Controls.Add(btn_supprimer_vol)
        Controls.Add(bnt_modifier_vol)
        Controls.Add(btn_ajouter_vol)
        Controls.Add(btn_aff_vol)
        Name = "admin_select"
        Text = "admin_select"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_aff_vol As Button
    Friend WithEvents btn_ajouter_vol As Button
    Friend WithEvents bnt_modifier_vol As Button
    Friend WithEvents btn_supprimer_vol As Button
End Class

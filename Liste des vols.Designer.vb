<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_des_vols
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
        DataGridView1 = New DataGridView()
        num = New DataGridViewTextBoxColumn()
        dest = New DataGridViewTextBoxColumn()
        dateVol = New DataGridViewTextBoxColumn()
        heure = New DataGridViewTextBoxColumn()
        nbPlace = New DataGridViewTextBoxColumn()
        prix = New DataGridViewTextBoxColumn()
        btn_reserver = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {num, dest, dateVol, heure, nbPlace, prix})
        DataGridView1.Location = New Point(12, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(776, 343)
        DataGridView1.TabIndex = 0
        ' 
        ' num
        ' 
        num.HeaderText = "Numéro du vol"
        num.Name = "num"
        num.ReadOnly = True
        ' 
        ' dest
        ' 
        dest.HeaderText = "Dstination"
        dest.Name = "dest"
        dest.ReadOnly = True
        ' 
        ' dateVol
        ' 
        dateVol.HeaderText = "Date"
        dateVol.Name = "dateVol"
        dateVol.ReadOnly = True
        ' 
        ' heure
        ' 
        heure.HeaderText = "Heure"
        heure.Name = "heure"
        heure.ReadOnly = True
        ' 
        ' nbPlace
        ' 
        nbPlace.HeaderText = "Nombre de places"
        nbPlace.Name = "nbPlace"
        nbPlace.ReadOnly = True
        ' 
        ' prix
        ' 
        prix.HeaderText = "Prix"
        prix.Name = "prix"
        prix.ReadOnly = True
        ' 
        ' btn_reserver
        ' 
        btn_reserver.Location = New Point(648, 31)
        btn_reserver.Name = "btn_reserver"
        btn_reserver.Size = New Size(140, 49)
        btn_reserver.TabIndex = 1
        btn_reserver.Text = "Réserver une billet"
        btn_reserver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 83)
        Label1.TabIndex = 27
        Label1.Text = "Listes des Vols"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Liste_des_vols
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btn_reserver)
        Controls.Add(DataGridView1)
        Name = "Liste_des_vols"
        Text = "Liste_des_vols"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents dest As DataGridViewTextBoxColumn
    Friend WithEvents dateVol As DataGridViewTextBoxColumn
    Friend WithEvents heure As DataGridViewTextBoxColumn
    Friend WithEvents nbPlace As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
    Friend WithEvents btn_reserver As Button
    Friend WithEvents Label1 As Label
End Class

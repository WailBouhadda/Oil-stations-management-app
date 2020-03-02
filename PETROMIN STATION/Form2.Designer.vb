<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDeStationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDeStationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDeDebutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDeFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixStructSuperspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixPublicSuperspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixStructGasoil10PPMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixPublicGasoil10PPMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSuperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGasoilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIDEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PETROMINBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINDataSet3 = New PETROMIN_STATION.PETROMINDataSet3()
        Me.PETROMINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINDataSet2 = New PETROMIN_STATION.PETROMINDataSet2()
        Me.PETROMINTableAdapter = New PETROMIN_STATION.PETROMINDataSet2TableAdapters.PETROMINTableAdapter()
        Me.PETROMINDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINTableAdapter1 = New PETROMIN_STATION.PETROMINDataSet3TableAdapters.PETROMINTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1083, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(252, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 10)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(1106, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 352)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tableau des station"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(27, 428)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(285, 428)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Maroon
        Me.Button4.Location = New System.Drawing.Point(406, 428)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Extraire"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(154, 428)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Supprimer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(998, 428)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Quitter"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(26, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(145, 10)
        Me.Panel3.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CodeDeStationDataGridViewTextBoxColumn, Me.NomDeStationDataGridViewTextBoxColumn, Me.VilleDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.DateDeDebutDataGridViewTextBoxColumn, Me.DateDeFinDataGridViewTextBoxColumn, Me.DTDataGridViewTextBoxColumn, Me.PrixStructSuperspDataGridViewTextBoxColumn, Me.PrixPublicSuperspDataGridViewTextBoxColumn, Me.PrixStructGasoil10PPMDataGridViewTextBoxColumn, Me.PrixPublicGasoil10PPMDataGridViewTextBoxColumn, Me.IDSuperDataGridViewTextBoxColumn, Me.IDGasoilDataGridViewTextBoxColumn, Me.VIDEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PETROMINBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(27, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1046, 324)
        Me.DataGridView1.TabIndex = 11
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'CodeDeStationDataGridViewTextBoxColumn
        '
        Me.CodeDeStationDataGridViewTextBoxColumn.DataPropertyName = "Code de station"
        Me.CodeDeStationDataGridViewTextBoxColumn.HeaderText = "Code de station"
        Me.CodeDeStationDataGridViewTextBoxColumn.Name = "CodeDeStationDataGridViewTextBoxColumn"
        '
        'NomDeStationDataGridViewTextBoxColumn
        '
        Me.NomDeStationDataGridViewTextBoxColumn.DataPropertyName = "Nom de station"
        Me.NomDeStationDataGridViewTextBoxColumn.HeaderText = "Nom de station"
        Me.NomDeStationDataGridViewTextBoxColumn.Name = "NomDeStationDataGridViewTextBoxColumn"
        '
        'VilleDataGridViewTextBoxColumn
        '
        Me.VilleDataGridViewTextBoxColumn.DataPropertyName = "Ville"
        Me.VilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.VilleDataGridViewTextBoxColumn.Name = "VilleDataGridViewTextBoxColumn"
        '
        'LongitudeDataGridViewTextBoxColumn
        '
        Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
        '
        'LatitudeDataGridViewTextBoxColumn
        '
        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        '
        'DateDeDebutDataGridViewTextBoxColumn
        '
        Me.DateDeDebutDataGridViewTextBoxColumn.DataPropertyName = "Date de debut"
        Me.DateDeDebutDataGridViewTextBoxColumn.HeaderText = "Date de debut"
        Me.DateDeDebutDataGridViewTextBoxColumn.Name = "DateDeDebutDataGridViewTextBoxColumn"
        '
        'DateDeFinDataGridViewTextBoxColumn
        '
        Me.DateDeFinDataGridViewTextBoxColumn.DataPropertyName = "Date de fin"
        Me.DateDeFinDataGridViewTextBoxColumn.HeaderText = "Date de fin"
        Me.DateDeFinDataGridViewTextBoxColumn.Name = "DateDeFinDataGridViewTextBoxColumn"
        '
        'DTDataGridViewTextBoxColumn
        '
        Me.DTDataGridViewTextBoxColumn.DataPropertyName = "DT"
        Me.DTDataGridViewTextBoxColumn.HeaderText = "DT"
        Me.DTDataGridViewTextBoxColumn.Name = "DTDataGridViewTextBoxColumn"
        '
        'PrixStructSuperspDataGridViewTextBoxColumn
        '
        Me.PrixStructSuperspDataGridViewTextBoxColumn.DataPropertyName = "PrixStruct Supersp"
        Me.PrixStructSuperspDataGridViewTextBoxColumn.HeaderText = "PrixStruct Supersp"
        Me.PrixStructSuperspDataGridViewTextBoxColumn.Name = "PrixStructSuperspDataGridViewTextBoxColumn"
        '
        'PrixPublicSuperspDataGridViewTextBoxColumn
        '
        Me.PrixPublicSuperspDataGridViewTextBoxColumn.DataPropertyName = "PrixPublic Supersp"
        Me.PrixPublicSuperspDataGridViewTextBoxColumn.HeaderText = "PrixPublic Supersp"
        Me.PrixPublicSuperspDataGridViewTextBoxColumn.Name = "PrixPublicSuperspDataGridViewTextBoxColumn"
        '
        'PrixStructGasoil10PPMDataGridViewTextBoxColumn
        '
        Me.PrixStructGasoil10PPMDataGridViewTextBoxColumn.DataPropertyName = "PrixStruct Gasoil10PPM"
        Me.PrixStructGasoil10PPMDataGridViewTextBoxColumn.HeaderText = "PrixStruct Gasoil10PPM"
        Me.PrixStructGasoil10PPMDataGridViewTextBoxColumn.Name = "PrixStructGasoil10PPMDataGridViewTextBoxColumn"
        '
        'PrixPublicGasoil10PPMDataGridViewTextBoxColumn
        '
        Me.PrixPublicGasoil10PPMDataGridViewTextBoxColumn.DataPropertyName = "PrixPublic Gasoil10PPM"
        Me.PrixPublicGasoil10PPMDataGridViewTextBoxColumn.HeaderText = "PrixPublic Gasoil10PPM"
        Me.PrixPublicGasoil10PPMDataGridViewTextBoxColumn.Name = "PrixPublicGasoil10PPMDataGridViewTextBoxColumn"
        '
        'IDSuperDataGridViewTextBoxColumn
        '
        Me.IDSuperDataGridViewTextBoxColumn.DataPropertyName = "ID Super"
        Me.IDSuperDataGridViewTextBoxColumn.HeaderText = "ID Super"
        Me.IDSuperDataGridViewTextBoxColumn.Name = "IDSuperDataGridViewTextBoxColumn"
        '
        'IDGasoilDataGridViewTextBoxColumn
        '
        Me.IDGasoilDataGridViewTextBoxColumn.DataPropertyName = "ID Gasoil"
        Me.IDGasoilDataGridViewTextBoxColumn.HeaderText = "ID Gasoil"
        Me.IDGasoilDataGridViewTextBoxColumn.Name = "IDGasoilDataGridViewTextBoxColumn"
        '
        'VIDEDataGridViewTextBoxColumn
        '
        Me.VIDEDataGridViewTextBoxColumn.DataPropertyName = "VIDE"
        Me.VIDEDataGridViewTextBoxColumn.HeaderText = "VIDE"
        Me.VIDEDataGridViewTextBoxColumn.Name = "VIDEDataGridViewTextBoxColumn"
        Me.VIDEDataGridViewTextBoxColumn.Visible = False
        '
        'PETROMINBindingSource1
        '
        Me.PETROMINBindingSource1.DataMember = "PETROMIN"
        Me.PETROMINBindingSource1.DataSource = Me.PETROMINDataSet3
        '
        'PETROMINDataSet3
        '
        Me.PETROMINDataSet3.DataSetName = "PETROMINDataSet3"
        Me.PETROMINDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PETROMINBindingSource
        '
        Me.PETROMINBindingSource.DataMember = "PETROMIN"
        Me.PETROMINBindingSource.DataSource = Me.PETROMINDataSet2
        '
        'PETROMINDataSet2
        '
        Me.PETROMINDataSet2.DataSetName = "PETROMINDataSet2"
        Me.PETROMINDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PETROMINTableAdapter
        '
        Me.PETROMINTableAdapter.ClearBeforeFill = True
        '
        'PETROMINDataSet2BindingSource
        '
        Me.PETROMINDataSet2BindingSource.DataSource = Me.PETROMINDataSet2
        Me.PETROMINDataSet2BindingSource.Position = 0
        '
        'PETROMINTableAdapter1
        '
        Me.PETROMINTableAdapter1.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Maroon
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1050, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 26)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PETROMIN_STATION.My.Resources.Resources.website_background_Artisan_Iron_Works_LLC_wallpaper_wp80014003
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1116, 463)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PETROMINDataSet2 As PETROMINDataSet2
    Friend WithEvents PETROMINBindingSource As BindingSource
    Friend WithEvents PETROMINTableAdapter As PETROMINDataSet2TableAdapters.PETROMINTableAdapter
    Friend WithEvents PETROMINDataSet2BindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodeDeStationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomDeStationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LongitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDeDebutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDeFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixStructSuperspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixPublicSuperspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixStructGasoil10PPMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixPublicGasoil10PPMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSuperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGasoilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VIDEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PETROMINDataSet3 As PETROMINDataSet3
    Friend WithEvents PETROMINBindingSource1 As BindingSource
    Friend WithEvents PETROMINTableAdapter1 As PETROMINDataSet3TableAdapters.PETROMINTableAdapter
    Friend WithEvents Button7 As Button
End Class

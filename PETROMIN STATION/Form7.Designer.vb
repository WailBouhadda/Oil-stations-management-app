<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.PETROMINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINDataSet2 = New PETROMIN_STATION.PETROMINDataSet2()
        Me.PETROMINTableAdapter = New PETROMIN_STATION.PETROMINDataSet2TableAdapters.PETROMINTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prix Essence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix Diesel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date de debut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(460, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date de fin"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(217, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(217, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(558, 217)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(760, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(16, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Modification rapide"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(558, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Sauvgarder"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(674, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Quitter"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 237)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(612, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 10)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Location = New System.Drawing.Point(782, 239)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 100)
        Me.Panel3.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CodeDeStationDataGridViewTextBoxColumn, Me.NomDeStationDataGridViewTextBoxColumn, Me.VilleDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.DateDeDebutDataGridViewTextBoxColumn, Me.DateDeFinDataGridViewTextBoxColumn, Me.DTDataGridViewTextBoxColumn, Me.PrixStructSuperspDataGridViewTextBoxColumn, Me.PrixPublicSuperspDataGridViewTextBoxColumn, Me.PrixStructGasoil10PPMDataGridViewTextBoxColumn, Me.PrixPublicGasoil10PPMDataGridViewTextBoxColumn, Me.IDSuperDataGridViewTextBoxColumn, Me.IDGasoilDataGridViewTextBoxColumn, Me.VIDEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PETROMINBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(10, 15)
        Me.DataGridView1.TabIndex = 0
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
        '
        'PETROMINBindingSource
        '
        Me.PETROMINBindingSource.DataMember = "PETROMIN"
        Me.PETROMINBindingSource.DataSource = Me.PETROMINDataSet2BindingSource
        '
        'PETROMINDataSet2BindingSource
        '
        Me.PETROMINDataSet2BindingSource.DataSource = Me.PETROMINDataSet2
        Me.PETROMINDataSet2BindingSource.Position = 0
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
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Maroon
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(724, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 26)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PETROMIN_STATION.My.Resources.Resources.website_background_Artisan_Iron_Works_LLC_wallpaper_wp80014003
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 347)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PETROMINDataSet2BindingSource As BindingSource
    Friend WithEvents PETROMINDataSet2 As PETROMINDataSet2
    Friend WithEvents PETROMINBindingSource As BindingSource
    Friend WithEvents PETROMINTableAdapter As PETROMINDataSet2TableAdapters.PETROMINTableAdapter
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
    Friend WithEvents Button7 As Button
End Class

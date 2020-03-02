<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PETROMINBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINDataSet2 = New PETROMIN_STATION.PETROMINDataSet2()
        Me.PETROMINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINDataSet = New PETROMIN_STATION.PETROMINDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PETROMINTableAdapter = New PETROMIN_STATION.PETROMINDataSetTableAdapters.PETROMINTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PETROMIN1DataSet1 = New PETROMIN_STATION.PETROMIN1DataSet1()
        Me.PETROMINBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINTableAdapter1 = New PETROMIN_STATION.PETROMIN1DataSet1TableAdapters.PETROMINTableAdapter()
        Me.PETROMINDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PETROMINTableAdapter2 = New PETROMIN_STATION.PETROMINDataSet2TableAdapters.PETROMINTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PETROMINBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMIN1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETROMINDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(791, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(735, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Quitter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(617, 336)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Sauvgarder"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Supprimer station"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Station ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PETROMINBindingSource2
        Me.ComboBox1.DisplayMember = "ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(272, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'PETROMINBindingSource2
        '
        Me.PETROMINBindingSource2.DataMember = "PETROMIN"
        Me.PETROMINBindingSource2.DataSource = Me.PETROMINDataSet2
        '
        'PETROMINDataSet2
        '
        Me.PETROMINDataSet2.DataSetName = "PETROMINDataSet2"
        Me.PETROMINDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PETROMINBindingSource
        '
        Me.PETROMINBindingSource.DataMember = "PETROMIN"
        Me.PETROMINBindingSource.DataSource = Me.PETROMINDataSet
        '
        'PETROMINDataSet
        '
        Me.PETROMINDataSet.DataSetName = "PETROMINDataSet"
        Me.PETROMINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code station"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ville"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PETROMINBindingSource2, "Code de station", True))
        Me.TextBox1.Location = New System.Drawing.Point(272, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PETROMINBindingSource2, "Nom de station", True))
        Me.TextBox2.Location = New System.Drawing.Point(272, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PETROMINBindingSource2, "Ville", True))
        Me.TextBox3.Location = New System.Drawing.Point(272, 263)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 20)
        Me.TextBox3.TabIndex = 11
        '
        'PETROMINTableAdapter
        '
        Me.PETROMINTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 294)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(9, 361)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 10)
        Me.Panel2.TabIndex = 0
        '
        'PETROMIN1DataSet1
        '
        Me.PETROMIN1DataSet1.DataSetName = "PETROMIN1DataSet1"
        Me.PETROMIN1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PETROMINBindingSource1
        '
        Me.PETROMINBindingSource1.DataMember = "PETROMIN"
        Me.PETROMINBindingSource1.DataSource = Me.PETROMIN1DataSet1
        '
        'PETROMINTableAdapter1
        '
        Me.PETROMINTableAdapter1.ClearBeforeFill = True
        '
        'PETROMINDataSet2BindingSource
        '
        Me.PETROMINDataSet2BindingSource.DataSource = Me.PETROMINDataSet2
        Me.PETROMINDataSet2BindingSource.Position = 0
        '
        'PETROMINTableAdapter2
        '
        Me.PETROMINTableAdapter2.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Maroon
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(751, -1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(34, 29)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PETROMIN_STATION.My.Resources.Resources.website_background_Artisan_Iron_Works_LLC_wallpaper_wp80014003
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 371)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        CType(Me.PETROMINBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMIN1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETROMINDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PETROMINDataSet As PETROMINDataSet
    Friend WithEvents PETROMINBindingSource As BindingSource
    Friend WithEvents PETROMINTableAdapter As PETROMINDataSetTableAdapters.PETROMINTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PETROMIN1DataSet1 As PETROMIN1DataSet1
    Friend WithEvents PETROMINBindingSource1 As BindingSource
    Friend WithEvents PETROMINTableAdapter1 As PETROMIN1DataSet1TableAdapters.PETROMINTableAdapter
    Friend WithEvents PETROMINDataSet2 As PETROMINDataSet2
    Friend WithEvents PETROMINDataSet2BindingSource As BindingSource
    Friend WithEvents PETROMINBindingSource2 As BindingSource
    Friend WithEvents PETROMINTableAdapter2 As PETROMINDataSet2TableAdapters.PETROMINTableAdapter
    Friend WithEvents Button7 As Button
End Class

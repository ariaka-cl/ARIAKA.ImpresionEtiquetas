<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelImportControl
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox_etiquetas = New System.Windows.Forms.GroupBox()
        Me.RadioButton_bulk = New System.Windows.Forms.RadioButton()
        Me.RadioButton_estacion = New System.Windows.Forms.RadioButton()
        Me.RadioButton_laboratorio = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel_buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox_etiquetas.SuspendLayout()
        Me.TableLayoutPanel_buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox_etiquetas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel_buttons, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 190)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(150, 20)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 52)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Importar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(150, 112)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(119, 52)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Generar "
        '
        'GroupBox_etiquetas
        '
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_laboratorio)
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_estacion)
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_bulk)
        Me.GroupBox_etiquetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_etiquetas.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_etiquetas.Name = "GroupBox_etiquetas"
        Me.GroupBox_etiquetas.Size = New System.Drawing.Size(271, 184)
        Me.GroupBox_etiquetas.TabIndex = 2
        Me.GroupBox_etiquetas.TabStop = False
        Me.GroupBox_etiquetas.Text = "Etiquetas"
        '
        'RadioButton_bulk
        '
        Me.RadioButton_bulk.AutoSize = True
        Me.RadioButton_bulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_bulk.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_bulk.Name = "RadioButton_bulk"
        Me.RadioButton_bulk.Size = New System.Drawing.Size(57, 23)
        Me.RadioButton_bulk.TabIndex = 0
        Me.RadioButton_bulk.TabStop = True
        Me.RadioButton_bulk.Text = "Bulk"
        Me.RadioButton_bulk.UseVisualStyleBackColor = True
        '
        'RadioButton_estacion
        '
        Me.RadioButton_estacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_estacion.AutoSize = True
        Me.RadioButton_estacion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_estacion.Location = New System.Drawing.Point(167, 20)
        Me.RadioButton_estacion.Name = "RadioButton_estacion"
        Me.RadioButton_estacion.Size = New System.Drawing.Size(85, 23)
        Me.RadioButton_estacion.TabIndex = 1
        Me.RadioButton_estacion.TabStop = True
        Me.RadioButton_estacion.Text = "Estación"
        Me.RadioButton_estacion.UseVisualStyleBackColor = True
        '
        'RadioButton_laboratorio
        '
        Me.RadioButton_laboratorio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButton_laboratorio.AutoSize = True
        Me.RadioButton_laboratorio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_laboratorio.Location = New System.Drawing.Point(75, 20)
        Me.RadioButton_laboratorio.Name = "RadioButton_laboratorio"
        Me.RadioButton_laboratorio.Size = New System.Drawing.Size(108, 23)
        Me.RadioButton_laboratorio.TabIndex = 2
        Me.RadioButton_laboratorio.TabStop = True
        Me.RadioButton_laboratorio.Text = "Laboratorio"
        Me.RadioButton_laboratorio.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_buttons
        '
        Me.TableLayoutPanel_buttons.ColumnCount = 1
        Me.TableLayoutPanel_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_buttons.Controls.Add(Me.SimpleButton2, 0, 1)
        Me.TableLayoutPanel_buttons.Controls.Add(Me.SimpleButton1, 0, 0)
        Me.TableLayoutPanel_buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_buttons.Location = New System.Drawing.Point(280, 3)
        Me.TableLayoutPanel_buttons.Name = "TableLayoutPanel_buttons"
        Me.TableLayoutPanel_buttons.RowCount = 2
        Me.TableLayoutPanel_buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_buttons.Size = New System.Drawing.Size(272, 184)
        Me.TableLayoutPanel_buttons.TabIndex = 3
        '
        'PanelImportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PanelImportControl"
        Me.Size = New System.Drawing.Size(555, 190)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox_etiquetas.ResumeLayout(False)
        Me.GroupBox_etiquetas.PerformLayout()
        Me.TableLayoutPanel_buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox_etiquetas As Windows.Forms.GroupBox
    Friend WithEvents RadioButton_laboratorio As Windows.Forms.RadioButton
    Friend WithEvents RadioButton_estacion As Windows.Forms.RadioButton
    Friend WithEvents RadioButton_bulk As Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel_buttons As Windows.Forms.TableLayoutPanel
End Class

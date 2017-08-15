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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelImportControl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox_etiquetas = New System.Windows.Forms.GroupBox()
        Me.RadioButton_laboratorio = New System.Windows.Forms.RadioButton()
        Me.RadioButton_remanente = New System.Windows.Forms.RadioButton()
        Me.RadioButton_bulk = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel_buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl_fileName = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFileDialog_inputs = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_resporte = New System.Windows.Forms.SaveFileDialog()
        Me.RadioButton_D1 = New System.Windows.Forms.RadioButton()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(737, 190)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox_etiquetas
        '
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_D1)
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_laboratorio)
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_remanente)
        Me.GroupBox_etiquetas.Controls.Add(Me.RadioButton_bulk)
        Me.GroupBox_etiquetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_etiquetas.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_etiquetas.Name = "GroupBox_etiquetas"
        Me.GroupBox_etiquetas.Size = New System.Drawing.Size(362, 184)
        Me.GroupBox_etiquetas.TabIndex = 2
        Me.GroupBox_etiquetas.TabStop = False
        Me.GroupBox_etiquetas.Text = "Etiquetas"
        '
        'RadioButton_laboratorio
        '
        Me.RadioButton_laboratorio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButton_laboratorio.AutoSize = True
        Me.RadioButton_laboratorio.Checked = True
        Me.RadioButton_laboratorio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_laboratorio.Location = New System.Drawing.Point(82, 20)
        Me.RadioButton_laboratorio.Name = "RadioButton_laboratorio"
        Me.RadioButton_laboratorio.Size = New System.Drawing.Size(108, 23)
        Me.RadioButton_laboratorio.TabIndex = 2
        Me.RadioButton_laboratorio.TabStop = True
        Me.RadioButton_laboratorio.Text = "Laboratorio"
        Me.RadioButton_laboratorio.UseVisualStyleBackColor = True
        '
        'RadioButton_remanente
        '
        Me.RadioButton_remanente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_remanente.AutoSize = True
        Me.RadioButton_remanente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_remanente.Location = New System.Drawing.Point(196, 20)
        Me.RadioButton_remanente.Name = "RadioButton_remanente"
        Me.RadioButton_remanente.Size = New System.Drawing.Size(106, 23)
        Me.RadioButton_remanente.TabIndex = 1
        Me.RadioButton_remanente.TabStop = True
        Me.RadioButton_remanente.Text = "Remanente"
        Me.RadioButton_remanente.UseVisualStyleBackColor = True
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
        'TableLayoutPanel_buttons
        '
        Me.TableLayoutPanel_buttons.ColumnCount = 2
        Me.TableLayoutPanel_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel_buttons.Controls.Add(Me.SimpleButton2, 1, 1)
        Me.TableLayoutPanel_buttons.Controls.Add(Me.SimpleButton1, 1, 0)
        Me.TableLayoutPanel_buttons.Controls.Add(Me.LabelControl_fileName, 0, 0)
        Me.TableLayoutPanel_buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_buttons.Location = New System.Drawing.Point(371, 3)
        Me.TableLayoutPanel_buttons.Name = "TableLayoutPanel_buttons"
        Me.TableLayoutPanel_buttons.RowCount = 2
        Me.TableLayoutPanel_buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_buttons.Size = New System.Drawing.Size(363, 184)
        Me.TableLayoutPanel_buttons.TabIndex = 3
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(227, 112)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(133, 52)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Generar "
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(227, 20)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 52)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Importar"
        '
        'LabelControl_fileName
        '
        Me.LabelControl_fileName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelControl_fileName.Location = New System.Drawing.Point(3, 39)
        Me.LabelControl_fileName.Name = "LabelControl_fileName"
        Me.LabelControl_fileName.Size = New System.Drawing.Size(147, 13)
        Me.LabelControl_fileName.TabIndex = 2
        Me.LabelControl_fileName.Text = "Ningún archivo seleccionado..."
        '
        'OpenFileDialog_inputs
        '
        Me.OpenFileDialog_inputs.FileName = "OpenFileDialog_Imputs"
        '
        'RadioButton_D1
        '
        Me.RadioButton_D1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_D1.AutoSize = True
        Me.RadioButton_D1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_D1.Location = New System.Drawing.Point(308, 20)
        Me.RadioButton_D1.Name = "RadioButton_D1"
        Me.RadioButton_D1.Size = New System.Drawing.Size(47, 23)
        Me.RadioButton_D1.TabIndex = 3
        Me.RadioButton_D1.TabStop = True
        Me.RadioButton_D1.Text = "D1"
        Me.RadioButton_D1.UseVisualStyleBackColor = True
        '
        'PanelImportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PanelImportControl"
        Me.Size = New System.Drawing.Size(737, 190)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox_etiquetas.ResumeLayout(False)
        Me.GroupBox_etiquetas.PerformLayout()
        Me.TableLayoutPanel_buttons.ResumeLayout(False)
        Me.TableLayoutPanel_buttons.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox_etiquetas As Windows.Forms.GroupBox
    Friend WithEvents RadioButton_laboratorio As Windows.Forms.RadioButton
    Friend WithEvents RadioButton_remanente As Windows.Forms.RadioButton
    Friend WithEvents RadioButton_bulk As Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel_buttons As Windows.Forms.TableLayoutPanel
    Friend WithEvents OpenFileDialog_inputs As Windows.Forms.OpenFileDialog
    Friend WithEvents LabelControl_fileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SaveFileDialog_resporte As Windows.Forms.SaveFileDialog
    Friend WithEvents RadioButton_D1 As Windows.Forms.RadioButton
End Class

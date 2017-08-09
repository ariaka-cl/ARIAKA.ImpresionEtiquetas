<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MazorcaGridControl1 = New ARIAKA.ImpresionEtiquetas.Win.MazorcaGridControl()
        Me.PanelImportControl1 = New ARIAKA.ImpresionEtiquetas.Win.PanelImportControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MazorcaGridControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelImportControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(934, 451)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MazorcaGridControl1
        '
        Me.MazorcaGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MazorcaGridControl1.Location = New System.Drawing.Point(3, 93)
        Me.MazorcaGridControl1.Name = "MazorcaGridControl1"
        Me.MazorcaGridControl1.Size = New System.Drawing.Size(928, 355)
        Me.MazorcaGridControl1.TabIndex = 0
        '
        'PanelImportControl1
        '
        Me.PanelImportControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelImportControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelImportControl1.Name = "PanelImportControl1"
        Me.PanelImportControl1.Size = New System.Drawing.Size(928, 84)
        Me.PanelImportControl1.TabIndex = 1
        '
        'MainForm
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 451)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.Name = "MainForm"
        Me.Text = "TUNICHE- Impresión Etiquetas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents MazorcaGridControl1 As MazorcaGridControl
    Friend WithEvents PanelImportControl1 As PanelImportControl
End Class

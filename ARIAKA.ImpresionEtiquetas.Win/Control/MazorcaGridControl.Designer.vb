<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MazorcaGridControl
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel_grid = New System.Windows.Forms.TableLayoutPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.InbredCodesDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInbredCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPopulation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCorrelativo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel_grid.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InbredCodesDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel_grid
        '
        Me.TableLayoutPanel_grid.ColumnCount = 1
        Me.TableLayoutPanel_grid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_grid.Controls.Add(Me.GridControl1, 0, 0)
        Me.TableLayoutPanel_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_grid.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_grid.Name = "TableLayoutPanel_grid"
        Me.TableLayoutPanel_grid.RowCount = 1
        Me.TableLayoutPanel_grid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_grid.Size = New System.Drawing.Size(653, 409)
        Me.TableLayoutPanel_grid.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.InbredCodesDTOBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(647, 403)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'InbredCodesDTOBindingSource
        '
        Me.InbredCodesDTOBindingSource.DataSource = GetType(ARIAKA.ImpresionEtiquetas.Win.DTO.InbredCodesDTO)
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInbredCode, Me.colPopulation, Me.colSourceID, Me.colCorrelativo, Me.colGrupo, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colInbredCode
        '
        Me.colInbredCode.FieldName = "InbredCode"
        Me.colInbredCode.Name = "colInbredCode"
        Me.colInbredCode.Visible = True
        Me.colInbredCode.VisibleIndex = 0
        '
        'colPopulation
        '
        Me.colPopulation.FieldName = "Population"
        Me.colPopulation.Name = "colPopulation"
        Me.colPopulation.Visible = True
        Me.colPopulation.VisibleIndex = 1
        '
        'colSourceID
        '
        Me.colSourceID.FieldName = "SourceID"
        Me.colSourceID.Name = "colSourceID"
        Me.colSourceID.Visible = True
        Me.colSourceID.VisibleIndex = 2
        '
        'colCorrelativo
        '
        Me.colCorrelativo.FieldName = "Correlativo"
        Me.colCorrelativo.Name = "colCorrelativo"
        '
        'colGrupo
        '
        Me.colGrupo.Caption = "Grupo Zero"
        Me.colGrupo.FieldName = "Grupo.Zero"
        Me.colGrupo.Name = "colGrupo"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Grupo D"
        Me.GridColumn1.FieldName = "Grupo.GrupoD"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Grupo C"
        Me.GridColumn2.FieldName = "Grupo.GrupoC"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Grupo B"
        Me.GridColumn3.FieldName = "Grupo.GrupoB"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Grupo A "
        Me.GridColumn4.FieldName = "Grupo.GrupoA"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'MazorcaGridControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel_grid)
        Me.Name = "MazorcaGridControl"
        Me.Size = New System.Drawing.Size(653, 409)
        Me.TableLayoutPanel_grid.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InbredCodesDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel_grid As Windows.Forms.TableLayoutPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents InbredCodesDTOBindingSource As Windows.Forms.BindingSource
    Friend WithEvents colInbredCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPopulation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorrelativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlSystem
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ComponentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboComponentType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtScalingFactor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtInitialValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkComputeIntialConditions = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cboLimiterControl = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtMinValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMaxValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv2)
        Me.SplitContainer1.Size = New System.Drawing.Size(858, 278)
        Me.SplitContainer1.SplitterDistance = 183
        Me.SplitContainer1.TabIndex = 2
        '
        'dgv1
        '
        Me.dgv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComponentName, Me.cboComponentType, Me.txtScalingFactor, Me.txtInitialValue, Me.chkComputeIntialConditions, Me.cboLimiterControl, Me.txtMinValue, Me.txtMaxValue})
        Me.dgv1.Location = New System.Drawing.Point(0, 10)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(858, 170)
        Me.dgv1.TabIndex = 1
        '
        'ComponentName
        '
        Me.ComponentName.HeaderText = "Component Name"
        Me.ComponentName.Name = "ComponentName"
        '
        'cboComponentType
        '
        Me.cboComponentType.HeaderText = "Component Type"
        Me.cboComponentType.Items.AddRange(New Object() {"SUM", "MULT", "DIV", "DIFFREND ", "INTEGRAL", "DELAY", "TRIPUNIT", "TRIPDLAY", "POWERI ", "POWERR ", "POWERX", "PROP-INT", "LAG", "LEAD-LAG ", "CONSTANT ", "SHAFT", "PUMPCTL", "STEAMCTL ", "FEEDCTL", "DELETE"})
        Me.cboComponentType.Name = "cboComponentType"
        '
        'txtScalingFactor
        '
        Me.txtScalingFactor.HeaderText = "Scaling Factor"
        Me.txtScalingFactor.Name = "txtScalingFactor"
        '
        'txtInitialValue
        '
        Me.txtInitialValue.HeaderText = "Initial Value"
        Me.txtInitialValue.Name = "txtInitialValue"
        '
        'chkComputeIntialConditions
        '
        Me.chkComputeIntialConditions.HeaderText = "Compute Initial Conditions"
        Me.chkComputeIntialConditions.Name = "chkComputeIntialConditions"
        '
        'cboLimiterControl
        '
        Me.cboLimiterControl.HeaderText = "Limiter Control"
        Me.cboLimiterControl.Items.AddRange(New Object() {"Omit", "Minimum Value", "Maximum Value", "Both"})
        Me.cboLimiterControl.Name = "cboLimiterControl"
        '
        'txtMinValue
        '
        Me.txtMinValue.HeaderText = "Minimum Value"
        Me.txtMinValue.Name = "txtMinValue"
        '
        'txtMaxValue
        '
        Me.txtMaxValue.HeaderText = "Maximum Value"
        Me.txtMaxValue.Name = "txtMaxValue"
        '
        'dgv2
        '
        Me.dgv2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(0, 3)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(858, 88)
        Me.dgv2.TabIndex = 2
        '
        'frmControlSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 278)
        Me.CloseButton = False
        Me.CloseButtonVisible = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmControlSystem"
        Me.Text = "Control System Data Input"
        Me.TopMost = True
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents ComponentName As DataGridViewTextBoxColumn
    Friend WithEvents cboComponentType As DataGridViewComboBoxColumn
    Friend WithEvents txtScalingFactor As DataGridViewTextBoxColumn
    Friend WithEvents txtInitialValue As DataGridViewTextBoxColumn
    Friend WithEvents chkComputeIntialConditions As DataGridViewCheckBoxColumn
    Friend WithEvents cboLimiterControl As DataGridViewComboBoxColumn
    Friend WithEvents txtMinValue As DataGridViewTextBoxColumn
    Friend WithEvents txtMaxValue As DataGridViewTextBoxColumn
    Friend WithEvents dgv2 As DataGridView
End Class

Imports DevComponents.DotNetBar.Controls

Public Class frmMinorEditRequests
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent




    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 0 Then
            Dim str As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If str = "CNTRLVAR" Or str = "CPUTIME" Or str = "BGNHG" Or str = "BGMCT" Then
                DataGridView1.Columns(2).Visible = True
                DataGridView1.Columns(1).Visible = False
            Else
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(1).Visible = True
            End If
        End If
    End Sub

    Private Sub frmMinorEditRequests_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboParameter.DisplayMember = "Tag"
        Try
            cboParameter.DataSource = New BindingSource(My.Application.ActiveSimulation.FormSurface.FlowsheetDesignSurface.drawingObjects, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If Not My.Application.ActiveSimulation.Options.MinorEdit Is Nothing Then
            'surip    DataGridView1.Rows.Add(My.Application.ActiveSimulation.Options.MinorEdit.ProMinorEdit101.Count)
            Dim i = 0

            For Each row In My.Application.ActiveSimulation.Options.MinorEdit.ProMinorEdit101
                DataGridView1.Rows.Add()
            Next

            For Each row In My.Application.ActiveSimulation.Options.MinorEdit.ProMinorEdit101
                DataGridView1.Rows(i).Cells(0).Value = row.Value.cboVariableCode
                DataGridView1.Rows(i).Cells(1).Value = row.Value.cboParameter
                DataGridView1.Rows(i).Cells(3).Value = row.Value.cboVolumeNo
                'DataGridView1.Rows.Add()
                i += 1
            Next

            'DataGridView1.Rows(i).Cells(1).Value = ""
            'DataGridView1.Rows(i).Cells(0).Value = ""
            'DataGridView1.AllowUserToAddRows = True
            'DataGridView1.Rows.Insert(rowIndex:=DataGridView1.Rows.Count() - 1)

        End If
    End Sub


    Sub Save()
        Dim row As New DataGridViewRow()
        Dim cv As New RELAP.SistemasDeUnidades.Conversor()

        'Dim form As Global.RELAP.FormFlowsheet = My.Application.ActiveSimulation

        Dim v1, v2, v3, v4, v5 As Object
        'My.Forms.
        If My.Application.ActiveSimulation.Options.MinorEdit Is Nothing Then
            My.Application.ActiveSimulation.Options.MinorEdit = New MinorEdit
        End If
        My.Application.ActiveSimulation.Options.MinorEdit.ProMinorEdit101.Clear()
        For i = 0 To DataGridView1.Rows.Count - 1
            row = DataGridView1.Rows(i)
            v1 = row.Cells(0).Value
            v2 = row.Cells(1).Value
            v3 = row.Cells(3).Value
            If (Not v1 Is Nothing And Not v2 Is Nothing) Then
                My.Application.ActiveSimulation.Options.MinorEdit.ProMinorEdit101.Add(i + 1, New MinorEdit101(v1, v2, v3))
            End If
        Next
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_CellContentClick()

    End Sub
End Class
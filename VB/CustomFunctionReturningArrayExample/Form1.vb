Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomFunctionReturningArrayExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            ribbonControl1.SelectedPage = formulasRibbonPage1
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            spreadsheetControl1.CreateNewDocument()
            spreadsheetControl1.ActiveWorksheet.Range("$A$1:$E$2").FillColor = Color.Honeydew

'            #Region "#TestArrayCustomFunctionAdd"
            Dim customFunction As New TestArrayCustomFunction()
            If Not spreadsheetControl1.Document.CustomFunctions.Contains(customFunction.Name) Then
                spreadsheetControl1.Document.CustomFunctions.Add(customFunction)
            End If

            spreadsheetControl1.ActiveWorksheet.Range("$A$4:$E$5").ArrayFormulaInvariant = "TESTARRAY(A1:E2)"
            spreadsheetControl1.ActiveWorksheet.Range("E7").Formula = "SUM(TESTARRAY(A1:E2))"
'            #End Region ' #TestArrayCustomFunctionAdd
        End Sub
    End Class
End Namespace

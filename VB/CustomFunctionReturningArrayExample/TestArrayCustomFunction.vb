Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Functions
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomFunctionReturningArrayExample
    #Region "#TestArrayCustomFunctionImplement"
    Public Class TestArrayCustomFunction
        Implements ICustomFunction


        Private name_Renamed As String = "TESTARRAY"

        Private parameters_Renamed() As ParameterInfo = { New ParameterInfo(ParameterType.Array, ParameterAttributes.Required) }
        Private return_type As ParameterType = ParameterType.Array

        Public ReadOnly Property Name() As String Implements IFunction.Name
            Get
                Return Me.name_Renamed
            End Get
        End Property
        Public ReadOnly Property Parameters() As ParameterInfo() Implements IFunction.Parameters
            Get
                Return Me.parameters_Renamed
            End Get
        End Property
        Public ReadOnly Property ReturnType() As ParameterType Implements IFunction.ReturnType
            Get
                Return Me.return_type
            End Get
        End Property
        Public ReadOnly Property Volatile() As Boolean Implements IFunction.Volatile
            Get
                Return False
            End Get
        End Property
        Public Function GetName(ByVal culture As CultureInfo) As String Implements ICustomFunction.GetName
            Return Name
        End Function
        Public Function Evaluate(ByVal parameters As IList(Of ParameterValue), ByVal context As EvaluationContext) As ParameterValue Implements ICustomFunction.Evaluate
            Dim args(,) As CellValue = parameters(0).ArrayValue
            Dim xDim As Integer = args.GetLength(0)
            Dim yDim As Integer = args.GetLength(1)
            Dim result(xDim - 1, yDim - 1) As CellValue

            For n As Integer = 0 To args.GetLength(0) - 1
                For m As Integer = 0 To result.GetLength(1) - 1
                    Dim coeff As Double = If(args(n, m).NumericValue = 0, 1, args(n, m).NumericValue)
                    result(n, m) = (n+1)*(m+1)*coeff
                Next m
            Next n

            Return result
        End Function
    End Class
    #End Region ' #TestArrayCustomFunctionImplement
End Namespace

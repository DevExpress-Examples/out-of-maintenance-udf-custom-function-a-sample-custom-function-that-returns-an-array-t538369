<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128614091/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T538369)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomFunctionReturningArrayExample/Form1.cs) (VB: [Form1.vb](./VB/CustomFunctionReturningArrayExample/Form1.vb))
* [TestArrayCustomFunction.cs](./CS/CustomFunctionReturningArrayExample/TestArrayCustomFunction.cs) (VB: [TestArrayCustomFunction.vb](./VB/CustomFunctionReturningArrayExample/TestArrayCustomFunction.vb))
<!-- default file list end -->
# UDF (Custom Function) - A sample custom function that returns an array


This example implements a custom function (UDF) that returns an array. The <strong>TESTARRAY</strong> function gets a range of cells, multiplies relative indexes of a cell in the range by the cell value and returns the resulting array.<br>To display the result in cells, each cell should contain an array formula with that function. To insert an array formula, the example uses the cell's <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRange_ArrayFormulaInvarianttopic">ArrayFormulaInvariant</a> property.<br>You can insert array formulas using the SpreadsheetControl UI: select a range for the output array, enter a formula, and press <strong>Ctrl+Shift+Enter</strong>.<br><br><br>

<br/>



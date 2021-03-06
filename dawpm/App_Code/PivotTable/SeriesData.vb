Imports System.Web.UI.DataVisualization.Charting
Public Class SeriesData
    Inherits List(Of PointData)
    Property SeriesLabel As String
    Property SeriesName As String
    Property SeriesWeight As Double
    Public Function GetSeriesData() As Series
        Dim newSeries As New Series() With {.Name = SeriesName, .label = SeriesLabel, .IsValueShownAsLabel = False, .legendText = ShortenNameBy("-", SeriesName)}
        For Each DP In Me
            Dim myPoint As New DataPoint() With {.AxisLabel = DP.PointLabel, .YValues = {DP.PointValue}, .IsValueShownAsLabel = True, .Font = New System.Drawing.Font("Verdana", 9, Drawing.FontStyle.Bold), .LabelForeColor = Drawing.Color.Black, .LabelBackColor = Drawing.Color.Transparent}
            newSeries.Points.Add(myPoint)
        Next
        Return newSeries
    End Function
    Public Function ShortenNameBy(ByVal BreakString As String, ByVal myValue As String) As String
        Dim myTemp = myValue.Split(CChar(BreakString))
        Return myTemp(myTemp.Count - 1)
    End Function
End Class

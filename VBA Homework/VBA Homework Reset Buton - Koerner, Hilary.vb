Sub Button2_Click()
For Each ws In Worksheets
        'Input column names for Ticker, Yearly Change, Percent Change, Total Stock Volume
        ws.Range("I:I").Value = ""
        ws.Range("J:J").Value = ""
        ws.Range("K:K").Value = ""
        ws.Range("L:L").Value = ""
        ws.Range("L:L").Interior.ColorIndex = 0
        ws.Range("M:M").Value = ""
        ws.Range("N:N").Value = ""
        
    Next ws
End Sub

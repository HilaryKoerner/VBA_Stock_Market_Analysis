'Final Version

Sub StockData()
    
    For Each ws In Worksheets
        'Input column names for Ticker, Yearly Change, Percent Change, Total Stock Volume
        ws.Range("I1").Value = "Ticker"
        'I included opening to see progress/debug the change portion
        ws.Range("J1").Value = "Opening"
        'I included closing to see progress/debug the change portion
        ws.Range("K1").Value = "Closing"
        ws.Range("L1").Value = "Yearly Change"
        ws.Range("M1").Value = "Percent Change"
        ws.Range("N1").Value = "Total Stock Volume"
        
        'This will have the data flow into the second+ row when printed
        Dim SummaryRow As Integer
        SummaryRow = 2

        Dim LastRow As Long
        LastRow = Cells(Rows.Count, 1).End(xlUp).Row

        Dim Ticker As String
        Dim Day As Integer
        Dim Opening As Double
        Dim High As Double
        Dim low As Double
        Dim Closing As Double
        Dim Volume As LongLong
        Dim percent As Double
        Dim change As Double
        
        Volume = 0
        Opening = 0
        Closing = 0
        High = 0
        low = 0
        
        For r = 2 To LastRow
            'Scans all Tickers and stopS when there is a change (new ticker) does the following:
            If ws.Cells(r - 1, 1).Value <> ws.Cells(r, 1).Value Then
                'YEARLY OPEN
                Opening = ws.Cells(r, 3).Value
                ws.Range("J" & SummaryRow).Value = Opening
                SummaryRow = SummaryRow
                
                'referenced credit card charges activity for this (same as finding new cctype)
                'Scans all Tickers and stops when there is a change (new ticker) does the following:
                ElseIf ws.Cells(r + 1, 1).Value <> ws.Cells(r, 1).Value Then
                    'TICKER'
                    Ticker = ws.Cells(r, 1).Value
                    ws.Range("I" & SummaryRow).Value = Ticker
                    'YEARLY CLOSE
                    Closing = ws.Cells(r, 6).Value
                    ws.Range("K" & SummaryRow).Value = Closing
                    'TOTAL STOCK VOLUME'
                    Volume = Volume + ws.Cells(r, 7).Value
                    ws.Range("N" & SummaryRow).Value = Volume
                    'Reset to next row, and reset to 0
                    SummaryRow = SummaryRow + 1
                    Volume = 0
                    'YEARLY CHANGE AND FORMATING
                    change = Closing - Opening
                    ws.Range("L" & SummaryRow - 1).Value = change
                        If change > 0 Then
                        'used student grader for color formating
                        ws.Range("L" & SummaryRow - 1).Interior.ColorIndex = 4
                        Else
                        ws.Range("L" & SummaryRow - 1).Interior.ColorIndex = 3
                        End If
                        'PERCENT CHANGE AND FORMATING
                        If Opening = 0 Then
                        percent = "0"
                        Else
                        'finance.zacks.com/calculate-percentage-increase-stock-value-2648.html#:~:
                        'text=To%20compute%20percentage%20change%20in,means%20that%20the%20price%20decreased.
                        'changed  100 to 1 for multiple after adding in the numberformat for percentage
                        percent = ((change / Opening) * 1)
                        ws.Range("M" & SummaryRow - 1).Value = percent
                        'excelvbatutor.com/vba_lesson9.htm - used this for percent formating
                        ws.Range("M" & SummaryRow - 1).NumberFormat = "0.00%"
                        End If
                    Else
                    'this grabs the volume for all of the ticker cells that do match
                    'referenced credit card charges activity for this (same as charged total)
                    Volume = Volume + ws.Cells(r, 7).Value
            End If
        Next r
    Next ws

End Sub
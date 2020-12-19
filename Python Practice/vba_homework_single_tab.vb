Sub TestingHomeWork()

'Input column names for Ticker, Yearly Change, Percent Change, Total Stock Volume
    Range("I1").Value = "Ticker"
    Range("J1").Value = "Opening"
    Range("K1").Value = "Closing"
    Range("L1").Value = "Yearly Change"
    Range("M1").Value = "Percent Change"
    Range("N1").Value = "Total Stock Volume"
    
    Dim SummaryRow As Integer
    'This will have the data flow into the second+ row when printed
    SummaryRow = 2
    
    Dim Ticker As String
    Dim Day As Integer
    Dim Opening As Double
    Dim High As Double
    Dim low As Double
    Dim Closing As Double
    Dim Volume As Double
  
    
    Volume = 0
    Opening = 0
    Closing = 0
    High = 0
    low = 0
    
    
    LastRow = Cells(Rows.Count, 1).End(xlUp).Row
        For r = 2 To LastRow
        'Scan all Tickers and stop when there is a change (new ticker) does the following:
            If Cells(r - 1, 1).Value <> Cells(r, 1).Value Then
                'Yearly Open
                Opening = Cells(r, 3).Value
                Range("J" & SummaryRow).Value = Opening
                SummaryRow = SummaryRow
                
                ElseIf Cells(r + 1, 1).Value <> Cells(r, 1).Value Then
                    'TICKER'
                    Ticker = Cells(r, 1).Value
                    Range("I" & SummaryRow).Value = Ticker
                    'Yearly Close
                    Closing = Cells(r, 6).Value
                    Range("K" & SummaryRow).Value = Closing
                    'TOTAL STOCK VOLUME'
                    Volume = Volume + Cells(r, 7).Value
                    Range("N" & SummaryRow).Value = Volume
                    'Reset to next row, and reset to 0
                    SummaryRow = SummaryRow + 1
                    Volume = 0
                
                    Change = Closing - Opening
                    Range("L" & SummaryRow - 1).Value = Change
                    
                    Percent = (Change / Opening) * 100
                    Range("M" & SummaryRow - 1).Value = Percent

               Else
                    Volume = Volume + Cells(r, 7).Value

            End If
        Next r
   
End Sub
## Date Picker

```xml
    <Grid>
        <DatePicker x:Name="datePicker" HorizontalAlignment="Left"  VerticalAlignment="Top" Height="25" Width="220" Margin="145,120,0,0" DisplayDateStart="2023-01-01" DisplayDateEnd="2024-12-31" FirstDayOfWeek="Monday" SelectedDateFormat="Long" SelectedDateChanged="DatePicker_SelectedDateChanged">
            <DatePicker.BlackoutDates>
                <CalendarDateRange Start="2024-12-12" End="12/12/2024 23:59:00"/>
            </DatePicker.BlackoutDates>
        </DatePicker>
        <Label x:Name="lblDate" Content="" HorizontalAlignment="Left" Margin="467,115,0,0" VerticalAlignment="Top" Width="229"/>
    </Grid>
```
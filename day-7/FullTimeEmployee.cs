public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate{get; set;}
    public double MonthlyBonus{get; set;}

    public override double GetMonthlyPay()
    {
        double sum = 0;
        for(int i = 0; i < WeeklyHours.Length; i++)
        {
            sum += WeeklyHours[i];
        }

        return (sum * HourlyRate) + MonthlyBonus;
    }
}
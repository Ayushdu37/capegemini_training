public class Payroll
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);   
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach(EmployeeRecord emp in records)
        {
            int count = 0;

            foreach(double hours in emp.WeeklyHours)
            {
                if(hours >= hoursThreshold)
                {
                    count++;
                }
            }

            if(count > 0)
            {
                result.Add(emp.EmployeeName, count);
            }
        }
        return result;
    }

    public double CalculateAverageMonthlyPay()
    {
        if(PayrollBoard.Count == 0) return 0;

        double totalPay = 0;

        foreach(EmployeeRecord emp in PayrollBoard)
        {
            totalPay += emp.GetMonthlyPay();
        }

        double average = totalPay / PayrollBoard.Count;

        return average;
    }
}
class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;
    public decimal ConsultationFee;
    public decimal LabCharges;
    public decimal MedicineCharges;
    public decimal GrossAmount;
    public decimal DiscountAmount;
    public decimal FinalPayable;

    public void CalculateGrossAmount()
    {
        GrossAmount = ConsultationFee + LabCharges + MedicineCharges;
    }

    public void CalculateDiscountAmount()
    {
        if (HasInsurance == true)
        {
            DiscountAmount = GrossAmount * 10 / 100;
        }
        else
        {
            DiscountAmount = 0;
        }
    }

    public void CalculateFinalPayable()
    {
        FinalPayable = GrossAmount - DiscountAmount;
    }
}
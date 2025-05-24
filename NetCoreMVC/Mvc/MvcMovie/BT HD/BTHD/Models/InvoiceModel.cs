public class InvoiceModel
{
    public int Quantity { get; set; } 
    public double UnitPrice { get; set; }  
    public double TotalAmount { get; set; }  

    
    public void CalculateTotalAmount()
    {
        TotalAmount = Quantity * UnitPrice;
    }
}

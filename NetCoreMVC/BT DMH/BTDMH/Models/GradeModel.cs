public class GradeModel
{
    public double A { get; set; }  
    public double B { get; set; }  
    public double C { get; set; }  
    public double FinalScore { get; set; }  

    
    public void CalculateFinalScore()
    {
        FinalScore = (A * 0.6) + (B * 0.3) + (C * 0.1); 
    }
}

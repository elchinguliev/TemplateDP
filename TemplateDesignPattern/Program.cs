public enum PaymentType
{
    Cash,Credit   
}
public abstract class Shopping
{
    protected string ProductName;
    protected PaymentType paymentType;
    public void Start()
    {
        Console.WriteLine("Shopping started ");
    }
    public void End()
    {
        Console.WriteLine($"Shopping ended. {ProductName} is gained by   {paymentType} method");
    }
    abstract public void Product();
    abstract public void PaymentMethod();
    public void TemplateMethod()
    {
        Start();
        Product();
        PaymentMethod();
        End();
    }
}
class TV : Shopping
{
    public override void PaymentMethod()
    {
       paymentType = PaymentType.Cash;
    }

    public override void Product()
    {
        ProductName="TV";
    }
}

class Refrigator : Shopping
{
    public override void PaymentMethod()
    {
        paymentType = PaymentType.Credit;
    }

    public override void Product()
    {
        ProductName="Refrigator";
    }
}

class Program
{
    static void Main(string[] args)
    {
      

        Shopping sh1 = new TV();
        sh1.TemplateMethod();
        Console.WriteLine("******");
        Shopping sh2 = new Refrigator();
        sh2.TemplateMethod();
        Console.Read();
    }
}
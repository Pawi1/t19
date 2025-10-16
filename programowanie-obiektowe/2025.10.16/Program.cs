namespace _2025._10._16;

public interface IPayment {
    string Authorize();
    string DownloadDesc();
}

public class CreditCard : IPayment
{
    public string Authorize() => "";
}

public class PayPal : IPayment {

}


class Program {
    static void Main(string[] args) {
        
    }
}

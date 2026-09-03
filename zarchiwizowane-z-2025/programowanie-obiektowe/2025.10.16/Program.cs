namespace _2025._10._16;

public interface IPayment {
    string Authorize();
    string DownloadDesc();
}

public class CreditCard : IPayment {
    public string Authorize() => "KartaPłatnicza: Łączę się z systemem VISA/Mastercard.";
    public string DownloadDesc() => "KartaPłatnicza: Łączę się z systemem VISA/Mastercard.";
}

public class PayPal : IPayment {
    public string Authorize() => "PayPal: Łączę się z systemem .";
    public string DownloadDesc() => "PayPal: Łączę się z systemem .";
}

public abstract class PaymentFabric {
    protected abstract IPayment CreatePayment();
    public string RealizeTransaction(decimal money){
        IPayment payment = CreatePayment();
        return $"";
    }

}


class Program {
    static void Main(string[] args) {
        
    }
}

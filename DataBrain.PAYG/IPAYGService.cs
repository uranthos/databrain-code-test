namespace DataBrain.PAYG;

public interface IPAYGService
{
    float GetTax(float earnings, PaymentFrequency frequency);
}
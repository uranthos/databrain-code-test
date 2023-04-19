using DataBrain.Common.CommonDefs;

namespace DataBrain.Common.Interfaces;

public interface IPAYGService
{
    float GetTax(float earnings, PaymentFrequency frequency);
}
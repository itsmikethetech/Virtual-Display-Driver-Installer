namespace VDD_Config.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}

namespace DesignPatterns.Decorator.V1;

public interface IEmailValidator
{
    bool IsValid(string email);
}
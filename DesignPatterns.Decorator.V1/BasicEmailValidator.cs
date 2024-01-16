namespace DesignPatterns.Decorator.V1;

public class BasicEmailValidator : IEmailValidator
{
    public bool IsValid(string email)
    {
        bool isEmailValid = email.Contains('@') && email.Contains('.');

        return isEmailValid;
    }
}
using System.Net.Mail;

namespace DesignPatterns.Decorator.V1;

public class EmailFormatValidatorDecorator : IEmailValidator
{
    private readonly IEmailValidator _emailValidator;
    public EmailFormatValidatorDecorator(IEmailValidator emailValidator)
    {
        _emailValidator = emailValidator;
    }
    public bool IsValid(string email)
    {
        bool isEmailValid = _emailValidator.IsValid(email) && ValidateEmailFormat(email);

        return isEmailValid;
    }

    private static bool ValidateEmailFormat(string email)
    {
        try
        {
            MailAddress m = new(email);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
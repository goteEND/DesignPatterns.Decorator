namespace DesignPatterns.Decorator.V1;
class Program
{
    static void Main(string[] args)
    {
        const string testEmail1 = "test@test.com";
        const string testEmail2 = "@.";

        Console.WriteLine("Basic Email Validation");

        IEmailValidator basicEmailValidator = new BasicEmailValidator();

        Console.WriteLine($"Email: {testEmail1}, Valid: {basicEmailValidator.IsValid(testEmail1)}");
        Console.WriteLine($"Email: {testEmail2}, Valid: {basicEmailValidator.IsValid(testEmail2)}");
        Console.WriteLine();

        Console.WriteLine("Email Format Validation");

        IEmailValidator emailFormatValidatorDecorator = new EmailFormatValidatorDecorator(basicEmailValidator);

        Console.WriteLine($"Email: {testEmail1}, Valid: {emailFormatValidatorDecorator.IsValid(testEmail1)}");
        Console.WriteLine($"Email: {testEmail2}, Valid: {emailFormatValidatorDecorator.IsValid(testEmail2)}");
        Console.WriteLine();
    }
}

namespace BlazorApp5.Services;

public interface IValidationService
{
    bool IsPasswordStrong(string password);
    List<string> GetPasswordErrors(string password);
}
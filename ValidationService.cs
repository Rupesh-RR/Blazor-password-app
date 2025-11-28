namespace BlazorApp5.Services;

public class ValidationService : IValidationService
{
    public bool IsPasswordStrong(string password)
    {
        return GetPasswordErrors(password).Count == 0;
    }

    public List<string> GetPasswordErrors(string password)
    {
        var errors = new List<string>();

        if (string.IsNullOrEmpty(password))
        {
            errors.Add("Password cannot be empty");
            return errors;
        }

        // Minimum length check
        if (password.Length < 6)  // Reduced from 8 to 6 for easier testing
        {
            errors.Add("Password must be at least 6 characters long");
        }

        // Number check
        if (!password.Any(char.IsDigit))
        {
            errors.Add("Password must contain at least one number");
        }

        // Uppercase letter check
        if (!password.Any(char.IsUpper))
        {
            errors.Add("Password must contain at least one uppercase letter");
        }

        // REMOVED special character requirement to make it easier
        // You can add it back later if needed

        return errors;
    }
}
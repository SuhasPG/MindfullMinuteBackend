

namespace MindfullMinute.Domain;
using System.ComponentModel.DataAnnotations;

public class MoodValidationAttribute : ValidationAttribute
{
    private static readonly HashSet<string> AllowedMoods = new()
    {
        "Happy", "Sad", "Angry", "Anxious", "Excited", "Calm", "Unknown"
    };

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string mood && AllowedMoods.Contains(mood))
        {
            return ValidationResult.Success;
        }
        return new ValidationResult($"Invalid mood. Allowed values are: {string.Join(", ", AllowedMoods)}");
    }
}


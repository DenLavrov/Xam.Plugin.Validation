﻿using PropertiesValidation.Base;

namespace PropertiesValidation.Implementations
{
    class MatchOrLessLengthValidationAttribute: ValidationAttribute
    {
        public int Length { get; }

        public MatchOrLessLengthValidationAttribute(int length, string parameterName = null, bool defaultValue = true) : base(parameterName, defaultValue)
        {
            Length = length;
        }

        public override bool Validate(object input, object parameter = null)
        {
            var value = input?.ToString();
            return value == null || value.Length <= Length;
        }
    }
}

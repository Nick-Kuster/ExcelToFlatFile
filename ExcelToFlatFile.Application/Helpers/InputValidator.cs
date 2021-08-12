using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelToFlatFileFramework.Domain;

namespace ExcelToFlatFile.Application.Helpers
{
    public class InputValidator
    {
        public List<T> ValidateInput<T>(List<T> input, string errorFile) where T : ValidationBase
        {
            List<T> errors = new List<T>();
            Dictionary<T, string> validationDictionary = new Dictionary<T, string>();

            for (int i = 0; i < input.Count; i++)
            {
                var requiredPropsMissing = input[i].ValidateRequiredProps();
                var atLeastOneRequiredPropsMissing = input[i].ValidateAtLeastOnePropRequired();
                var overLength = input[i].ValidateLengthRequirement();
                var validationMessage = new StringBuilder();
                if (requiredPropsMissing.Any())
                {
                    validationMessage.Append($"Required value(s) missing: {string.Join("|",requiredPropsMissing)},");
                }

                if (atLeastOneRequiredPropsMissing.Any())
                {
                    foreach (var group in atLeastOneRequiredPropsMissing)
                    {
                        validationMessage.Append($"At least one of the following are required: {string.Join("|", group)},");
                    }
                }

                if (overLength.Any())
                {
                    validationMessage.Append($"The following properties were over max length and were trimmed to meet requirements: {string.Join("|", overLength)},");
                }

                if (requiredPropsMissing.Any() || atLeastOneRequiredPropsMissing.Any())
                {
                    errors.Add(input[i]);
                }

                if (requiredPropsMissing.Any() || atLeastOneRequiredPropsMissing.Any() || overLength.Any())
                {
                    validationDictionary.Add(input[i], validationMessage.ToString());
                }
            }

            foreach (var error in errors)
            {
                input.Remove(error);
            }

            CSVHelper csvHelper = new CSVHelper();
            csvHelper.WriteErrorsCSV(validationDictionary, errorFile);

            return input;
        }

        public class ValidationModel<T>
        {
            public T Model { get; set; }
            public string ErrorMessage { get; set; }
            public string WarningMessage { get; set; }
        }
    }
}
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
            Dictionary<T, string> errors = new Dictionary<T, string>();  
            for (int i = 0; i < input.Count; i++)
            {
                var requiredPropsMissing = input[i].ValidateRequiredProps();
                var atLeastOneRequiredPropsMissing = input[i].ValidateAtLeastOnePropRequired();
                var errorMessage = new StringBuilder();
                if (requiredPropsMissing.Any())
                {
                    errorMessage.Append($"Required value(s) missing: {string.Join("|",requiredPropsMissing)},");
                }

                if (atLeastOneRequiredPropsMissing.Any())
                {
                    foreach (var group in atLeastOneRequiredPropsMissing)
                    {
                        errorMessage.Append($"At least one of the following are required: {string.Join("|", group)},");
                    }
                }

                if (requiredPropsMissing.Any() || atLeastOneRequiredPropsMissing.Any())
                {
                    errors.Add(input[i], errorMessage.ToString());
                }
            }

            foreach (var error in errors)
            {
                input.Remove(error.Key);
            }

            CSVHelper csvHelper = new CSVHelper();
            csvHelper.WriteErrorsCSV(errors, errorFile);

            return input;
        }
    }
}
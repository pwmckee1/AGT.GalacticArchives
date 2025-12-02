using Microsoft.AspNetCore.Mvc.Filters;

namespace AGT.GalacticArchives.Filters;

public class ModelStatePropertyValidationFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        var errorMessages = new List<string>();
        if (!context.ModelState.IsValid)
        {
            foreach (var value in context.ModelState.Values.Where(v => v.Errors.Any()))
            foreach (var valueError in value.Errors)
                errorMessages.Add(valueError.ErrorMessage);

            throw new Exception(string.Join(Environment.NewLine, errorMessages));
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
}
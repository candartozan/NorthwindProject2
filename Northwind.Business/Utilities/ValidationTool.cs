using FluentValidation;


namespace Northwind.Business.Utilities
{
	public static class ValidationTool
	{
		public static void Validate(IValidator validator,object entity)
		{
			var result = validator.Validate((IValidationContext)entity);
			if (result.Errors.Count > 0)
			{
				throw new ValidationException(result.Errors);
			}
		}
	}
}

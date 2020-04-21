using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logincs)
        {
            foreach (var result in logincs)
            {
                if (!result.Success)
                {
                    return result;
                }
            }

            return null;
        }
    }
}
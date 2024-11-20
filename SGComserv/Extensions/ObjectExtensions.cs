namespace SGComserv.Extensions;

public static class ObjectExtensions
{
    public static TTarget MapCommonProperties<TSource, TTarget>(this TSource source, TTarget target)
    {
        if (source == null || target == null)
            throw new ArgumentNullException("Source or/and Target cannot be null");

        var sourceProperties = typeof(TSource).GetProperties();
        var targetProperties = typeof(TTarget).GetProperties();

        foreach (var sourceProp in sourceProperties)
        {
            var targetProp = targetProperties.FirstOrDefault(tp => tp.Name == sourceProp.Name && tp.PropertyType == sourceProp.PropertyType);

            if (targetProp != null && targetProp.CanWrite)
            {
                var value = sourceProp.GetValue(source, null);
                targetProp.SetValue(target, value, null);
            }
        }

        return target;
    }
}

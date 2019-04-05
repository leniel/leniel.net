public class ExcludeFilterAttribute : FilterAttribute
{
    private Type filterType;

    public ExcludeFilterAttribute(Type filterType)
    {
        this.filterType = filterType;
    }

    public Type FilterType
    {
        get
        {
            return this.filterType;
        }
    }
}
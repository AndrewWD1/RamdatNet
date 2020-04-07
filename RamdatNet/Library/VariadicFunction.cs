namespace RamdatNet.Library
{
    /// <summary>
    /// Represents a method that takes a abritrary number of elements of the same type
    /// </summary>
    /// <param name="args"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <returns></returns>
    public delegate K VariadicFunction<T, K>(params T[] args);

    /// <summary>
    /// Represents a method that takes a abritrary number of objects of arbitrary types
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public delegate object VariadicFunction(params object[] args);
}
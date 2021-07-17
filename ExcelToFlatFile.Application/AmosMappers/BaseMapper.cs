using System.Collections.Generic;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public abstract class BaseMapper<TIn, TOut>
    {
        public abstract TOut Map(List<TIn> input);
    }
}
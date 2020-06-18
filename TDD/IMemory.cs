using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IMemory<T>
    {
        void Store(T value);

        T Read();
    }
}

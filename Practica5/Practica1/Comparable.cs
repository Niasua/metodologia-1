using System;

namespace Practica4
{
    public interface Comparable
    {
        bool sosIgual(Comparable c);
        bool sosMayor(Comparable c);
        bool sosMenor(Comparable c);
    }
}
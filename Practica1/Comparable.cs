using System;

namespace Practica1
{
    public interface Comparable
    {
        bool sosIgual(Comparable c);
        bool sosMayor(Comparable c);
        bool sosMenor(Comparable c);
    }
}
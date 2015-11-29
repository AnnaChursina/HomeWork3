

using System;

namespace Model
{
    public static class IsEvent
    {
        // принять число, проверить на четность,
        //отправить значение на игроков
        public static bool isEvent(this int i)
        {
            return (i%2 == 0);
        }
    }
}

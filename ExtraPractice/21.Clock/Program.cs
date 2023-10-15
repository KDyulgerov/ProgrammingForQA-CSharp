
for (int hour = 00; hour <= 23; hour++)
{
    for (int minute = 1; minute <= 59; minute++)
    {
        for (int second = 1; second <= 59; second++)
        {
            string typeMin = "";
            string typeSec = "";
            string typeHour = "";

            if (minute <= 9)
            {
                typeMin = "0";
            }

            if (second <= 9)
            {
                typeSec = "0";
            }

            if (hour == 0 || hour < 10)
            {
                typeHour = "0";
            }
            Console.Clear();
            Console.Write($"{typeHour}{hour}:{typeMin}{minute}:{typeSec}{second}");
            Thread.Sleep(1000);
        }
    }
}

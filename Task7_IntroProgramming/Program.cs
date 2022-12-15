int count = 0,
    distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5,
    total_time = 0;
int friend = 2;

    while(distance >10)
    {
        if(friend == 1)
        {
            total_time = distance / (firstFriendSpeed + dogSpeed);
            friend = 2;
        }
        else
        {
            total_time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
        }

        distance = distance - (firstFriendSpeed + secondFriendSpeed) * total_time;
        count++;
    }

    Console.Write("Собака пробежит - ");
    Console.WriteLine(count);

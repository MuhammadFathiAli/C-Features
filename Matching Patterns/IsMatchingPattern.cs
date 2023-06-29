using System;

User user = new User("Ahmed", subscription.silver);
if (user != null && user.Name == "Ahmed" && user.Subscription == subscription.silver)
{
    Console.WriteLine(user);
}
else
{
    Console.WriteLine("Wrong");
}
// But You Can Use Pattern Matching
/* Pattern Matching
 * it lets you check if an object has specific charachetristics:
    - is null or is not null => asking with "is" takes care of null check
    - is of a particular type
    - property has a specific value
    * 
 * ther's an overhead of it, so don't use in the hot path in ur code
 */

//user = null;
//user.Subscription = null;
if (user is { Name: "Ahmed", Subscription: subscription.silver })
{
    Console.WriteLine(user);
}
else
{
    Console.WriteLine("Wrong");
}

class User
{
    public string Name { get; set; }
    public Subscription Subscription { get; set; }
    public User(string name, Subscription subscription)
    {
        Name = name;
        Subscription = subscription;
    }
    override ToString()
    {
        return $" User Name is {Name}, Subscription is {Subscription}";
    }

}
enum Subscription
{
    regular, prime, silver, gold, premuim
}

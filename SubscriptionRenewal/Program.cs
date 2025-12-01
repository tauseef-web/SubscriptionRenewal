Random random = new();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired now. Renew today to continue enjoying our services.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days");
}
else if(daysUntilExpiration <=5)
{
    discountPercentage = 15;
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days");
}
else if(daysUntilExpiration <=10)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days");
}
if(discountPercentage >0)
{
    Console.WriteLine($"Renew now and get {discountPercentage}% discount");
}
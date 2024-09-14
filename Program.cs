// See https://aka.ms/new-console-template for more information

using StackExchange.Redis;

var redisUrl = Environment.GetEnvironmentVariable("REDIS_URL");

Console.WriteLine("Connection server: " + redisUrl);

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(redisUrl);
var redisContext = redis.GetDatabase();

var nokotan = redisContext.StringGet("nokotan");
Console.WriteLine(nokotan);
if(nokotan.IsNullOrEmpty)
{
  Console.WriteLine("nokotan is not found.");
}

redisContext.StringSet("shika", "しかのこのこのここしたんたん");

var shika = redisContext.StringGet("shika");
Console.WriteLine(shika);

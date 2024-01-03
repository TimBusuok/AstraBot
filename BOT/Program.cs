using Telegram.Bot;

string token = File.ReadAllText("C:\\Users\\Тимофей\\Desktop\\AstroBot\\token");
var client = new TelegramBotClient(token);

client.StartReceiving(
(c, arg, _) =>
{
  // 
  // Чтобы показать ник -> Console.WriteLine(arg.Message.Chat.FirstName); и тд
  TelegramBot bot = new TelegramBot(token);
  return c.SendTextMessageAsync(arg.Message.Chat.Id,
  bot.GetAnswer(arg.Message.Text.ToLower()));
  
},
(_, _, _) => Task.CompletedTask

);
Console.WriteLine("StartReceiving ...");
Console.ReadLine();
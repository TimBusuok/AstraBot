class TelegramBot{
    string token;
    HttpClient hc = new HttpClient();
    string planet = "";
        int R = 0;
        int D = 0;
        long S = 0;
        long S1 = 0;
        long population = 0;
        int speed = 0;
    

    

    public TelegramBot(string token){
        this.token = token;
        hc = new HttpClient();
        hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/");
    }
    

    public string GetAnswer(string msg){
        switch(msg){
            case "/start":
            string content = "Приветствуем!\nℹ️ Информация о спутнике предоставлена в разделе /info";
            msg = content;
            return msg;

            case "/info":
            content = "Этот бот был создан ради того чтобы вам помочь в узновании космоса 🌌\nНаши функции:\nПодробности о всех известных планетах🪐(/planet);\nКакой праздник сегодня🎉🎉(/party)";
            msg = content;
            return msg;

            case "/stop":
            content = "Досвидание! Приятно с вами работать))😊";
            msg = content;
            return msg;

            case "/party":
            content = CheckDay();
            msg = content;
            return msg;

            case "/planet":
            string qweston = $"О какой планете вы хотите получить данные?🔭👾:\nМеркурий(/mercure)\nВенера(/venera)\nЗемля(/earth)\nМарс(/mars)\nЮптер(/jupiter)\nСатурн(/saturn)\nУран(/uran)\nНептун(/neptun)";
            msg = qweston;
            return msg;

            case "/mercure":
            planet = "Меркурий";
            R = R + 2440;
            D = D + 4880;
            S = S + 58000000;
            S1 = S1 + 91600000;
            speed = speed + 48;
            string infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;

            case "/venera":
            planet = "Венера";
            R = R + 6052;
            D = D +12104;
            S = S + 108000000;
            S1 = S1 + 41400000;
            speed = speed + 35;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;

            case "/earth":
            planet = "Земля";
            R = R + 6371;
            D = D + 12742;
            S = S + 150000000;
            population = population + 8000000000;
            speed = speed + 35;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = {population} человек\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;

            case "/mars":
            planet = "Марс";
            R = R + 3990;
            D = D + 7980;
            S = S + 228000000;
            S1 = S1 + 78300000;
            speed = speed + 24;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;

            case "/jupiter":
            planet = "Юпитер";
            R = R + 69911;
            D = R * 2;
            S = S + 778000000;
            S1 = S1 + 628400000;
            speed = speed + 13;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;

            case "/saturn":
            planet = "Сатурн";
            R = R + 58232;
            D = R * 2;
            S = S + 1492000000;
            S1 = S1 + 1227400000;
            speed = speed + 10;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;
            
            case "/uran":
            planet = "Уран";
            R = R + 25362;
            D = R * 2;
            S = S + 2875000000;
            S1 = S1 + 1227400000;
            speed = speed + 7;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;
            
            case "/neptun":
            planet = "Нептун";
            R = R + 24622;
            D = R * 2;
            S = S + 4497000000;
            S1 = S1 + 4347400000;
            speed = speed + 5;
            infoPlanet = $"Данные о планете📡 -{planet}- получены:\nРадиус = {R}км\nДиаметр = {D}км\nРасстояние до Солнца = {S}км\nРасстояние до Земли = {S1}км\nПопуляция = пару вездеходов))\nСкорость планеты = {speed}км/с";
            msg = infoPlanet;
            return msg;

        }
        return "Неккоректный ввод";
    }

    public string CheckDay(){
        // DateTime date = new DateTime();
        DateTime dateNow = DateTime.Now;
        // string incrementedDateTime = date.AddDays().ToString();
        string dataRes = dateNow.ToString().Remove(dateNow.ToString().Length - 13);
        string hollidays = ShowHolidays(dataRes);
        string res = $"Сегодня ({dataRes}) такие праздники🎉🎉:\n{hollidays}";
        return res;
    }
    public string ShowHolidays(string date)
    {
        string party = "";
    switch (date)
    {
        case "01.01":
        case "02.01":
        case "03.01":
        case "04.01":
        case "05.01":
        case "06.01":
        case "08.01":
            party = "Новогодние праздники⛄🎅";
            break;

        case "07.01":
            party = "Новогодние праздники⛄🎅\nРождество🎄";
            break;

        case "23.02":
            party = "День Защитника Отечества🏋️💪";
            break;

        case "08.03":
            party = "Международный женский день🌹🌹";
            break;

        case "01.05":
            party = "Праздник Весны и Труда🌿👔";
            break;

        case "09.05":
            party = "День Победы🎆🎆";
            break;

        case "04.11":
            party = "День народного единства👨👩👳🧕";
            break;

        case "12.06":
            party = "День России 🇷🇺";
            break;

        default:
            party = "Cегодня праздников нет😔";
            break;
    }

        return party;
    }

    //  private static IReplyMarkup GetDynamicButtons(string command_)
    //     {
    //         //так формируется список кнопок и их параметров, можно передать сюда список полученный строк из sql субд, на пример
    //         List<InlineKeyboardButton> list = new List<InlineKeyboardButton>();
    //         if (command_.Split('|')[0].ToLower() == "all_butt_show")    //по условию можно выводить разные списки кнопок под одним и тем же сообщением в чате
    //         {
    //             list.Add(new InlineKeyboardButton() { Text = $"Кнопка 1", CallbackData = $"что_то_там_1|{command_.Split('|')[1]}" });
    //             list.Add(new InlineKeyboardButton() { Text = $"Кнопка 2", CallbackData = $"что_то_там_2|{command_.Split('|')[1]}" });
    //             list.Add(new InlineKeyboardButton() { Text = $"Кнопка 3", CallbackData = $"что_то_там_3|{command_.Split('|')[1]}" });
    //         }
    //         if (command_.Split('|')[0].ToLower() == "back_show")
    //         {
    //             list.Add(new InlineKeyboardButton() { Text = $"Назад", CallbackData = $"back|{command_.Split('|')[1]}" });
    //         }
    //         //так выводятся кнопки на экран
    //         var twoMenu = new List<InlineKeyboardButton[]>();
    //         for (var i = 0; i < list.Count; i++)
    //         {
    //             twoMenu.Add(new[] { list[i] });
    //         }
    //         var menu = new InlineKeyboardMarkup(twoMenu.ToArray());
    //         return menu;
    //     }
   
   
}
